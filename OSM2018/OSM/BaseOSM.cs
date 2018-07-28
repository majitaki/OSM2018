using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.OSM
{
    class BaseOSM : I_OSM
    {
        I_Network MyNetwork;
        I_AgentSet MyAgentSet;
        I_Algo MyAlgo;

        public BaseOSM(I_Network network, I_AgentSet agent_set, I_Algo algo)
        {
            this.MyNetwork = network;
            this.MyAgentSet = agent_set;
            this.MyAlgo = algo;
        }

        public void Initialize()
        {
            this.MyAlgo.Initialize(this.MyNetwork, this.MyAgentSet);
        }

        public void PlaySteps(int steps)
        {
            throw new NotImplementedException();
        }

        public void RunRounds(int total_rounds, int round_steps)
        {
            for (int current_round = 1; current_round <= total_rounds; current_round++)
            {
                this.MyAlgo.RunOneRound(this.MyNetwork, this.MyAgentSet, current_round, total_rounds);
            }
        }
    }
}
