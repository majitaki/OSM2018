﻿using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.Common
{
    class ReceiveOpinion : I_ReceiveOpinion
    {
        public Queue<I_Message> ReceiveMessageQueue { get; set; }

        public void Run(I_Network network, I_AgentSet agent_set)
        {
            if (this.ReceiveMessageQueue.Count == 0) return;

            while (this.ReceiveMessageQueue.Count > 0)
            {
                var message = this.ReceiveMessageQueue.Dequeue();
                var target_agent = agent_set.AgentList.First(agent => agent.NodeID == message.TargetNodeID);
                var pre_opinion = target_agent.Opinion;
                var belief = target_agent.Belief;
                double wei = 0;

                if (message.SourceNodeID < 0)
                {
                    wei = target_agent.SensorAccuracy;
                }
                else
                {
                    wei = target_agent.WeightDic.First(dic => dic.Key == message.SourceNodeID).Value;
                }

                var message_op = message.MessageOpinion;

                //belief update
                if (target_agent.IsSensor)
                {
                    target_agent.Belief = OpinionBeliefUpdater.UpdateBelief(belief, target_agent.SensorAccuracy, message_op);
                }
                else
                {
                    target_agent.Belief = OpinionBeliefUpdater.UpdateBelief(belief, wei, message_op);
                }
                if (message_op == InfoEnum.Green) target_agent.ReceiveGreenCounts++;
                if (message_op == InfoEnum.Red) target_agent.ReceiveRedCounts++;

                //opinion update
                target_agent.Opinion = OpinionBeliefUpdater.UpdateOpinion(pre_opinion, target_agent.Belief, target_agent.GreenSigma, target_agent.RedSigma);
                target_agent.IsChanged = (pre_opinion != target_agent.Opinion) ? true : false;

                //send message
                if (target_agent.IsChanged)
                {
                    var neighbor_id_list = network.NodeList[target_agent.NodeID].NeighborNodeIDList;
                    foreach (var nei_id in neighbor_id_list)
                    {
                        var new_message = new Message(target_agent.NodeID, nei_id, target_agent.Opinion);
                        target_agent.SendReadyMessageQueue.Enqueue(new_message);
                    }
                }
            }
        }
    }
}
