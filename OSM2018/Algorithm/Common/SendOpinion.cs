using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.Common
{
    class SendOpinion : I_SendOpinion
    {
        public Queue<I_Message> SendMessageQueue { get; private set; }
        public int EnvOpinionCounts { get; private set; }
        public double OpinionIntroductionRate { get; }

        public SendOpinion(double op_intro_rate)
        {
            this.OpinionIntroductionRate = op_intro_rate;
        }

        public void Run(I_Network network, I_AgentSet agent_set, bool env_send, InfoEnum correct, InfoEnum incorrect)
        {
            this.SendMessageQueue = new Queue<I_Message>();

            if (env_send) this.SendEnvMessage(network, agent_set, correct, incorrect, this.OpinionIntroductionRate);
            this.SendAgentMessage(network, agent_set);

        }

        void SendEnvMessage(I_Network network, I_AgentSet agent_set, InfoEnum correct, InfoEnum incorrect, double op_intro_rate)
        {
            if (RandomPool.Get(SeedEnum.PlayStepSeed).NextDouble() > op_intro_rate) return;
            this.EnvOpinionCounts++;

            var correct_opinion = correct;
            var incorrect_opinion = incorrect;

            foreach (var agent in agent_set.AgentList)
            {
                if (!(agent.IsSensor)) continue;
                var env_info = InfoEnum.Undeter;
                if (RandomPool.Get(SeedEnum.PlayStepSeed).NextDouble() <= agent.SensorAccuracy)
                {
                    env_info = correct_opinion;
                }
                else
                {
                    env_info = incorrect_opinion;
                }

                this.SendMessageQueue.Enqueue(new Message(-1, agent.NodeID, env_info));
            }
        }

        void SendAgentMessage(I_Network network, I_AgentSet agent_set)
        {
            foreach (var agent in agent_set.AgentList)
            {
                if (agent.SendReadyMessageQueue.Count == 0) continue;

                while (agent.SendReadyMessageQueue.Count > 0)
                {
                    var message = agent.SendReadyMessageQueue.Dequeue();
                    this.SendMessageQueue.Enqueue(message);
                }

            }
        }
    }
}
