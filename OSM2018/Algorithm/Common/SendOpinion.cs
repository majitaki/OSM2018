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
        public List<I_Message> SendMessageList { get; private set; }
        public void Run(I_Network network, I_AgentSet agent_set, bool env_send)
        {
            this.SendMessageList = new List<I_Message>();

            if (env_send) this.SendEnvMessage(network, agent_set);
            this.SendAgentMessage(network, agent_set);

        }

        void SendEnvMessage(I_Network network, I_AgentSet agent_set)
        {
            foreach (var agent in agent_set.AgentList)
            {
                if (!(agent.IsSensor)) continue;
                var env_info = InfoEnum.Undeter;
                if (RandomPool.Get(SeedEnum.PlayStepSeed).NextDouble() <= agent.SensorAccuracy)
                {
                    env_info = InfoEnum.Green;
                }
                else
                {
                    env_info = InfoEnum.Red;
                }

                this.SendMessageList.Add(new Message(-1, agent.NodeID, env_info));
            }
        }

        void SendAgentMessage(I_Network network, I_AgentSet agent_set)
        {
            foreach (var agent in agent_set.AgentList)
            {
                if (agent.SendReadyMessageQueue.Count == 0) continue;

                while(agent.SendReadyMessageQueue.Count > 0)
                {
                    var message = agent.SendReadyMessageQueue.Dequeue();
                    this.SendMessageList.Add(message);
                }

            }
        }
    }
}
