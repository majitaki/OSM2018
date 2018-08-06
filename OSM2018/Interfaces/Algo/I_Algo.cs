using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces.Algo
{
    interface I_Algo
    {
        AlgoEnum MyAlgoEnum { get; }
        void Initialize(I_Network network, I_AgentSet agent_set);
        void RunOneRound(I_Network network, I_AgentSet agent_set, int current_round, int round_steps);
        void RunOneRoundwithoutPlaySteps(I_Network network, I_AgentSet agent_set, int current_round);
        void PlayOneStep(I_Network network, I_AgentSet agent_set, InfoEnum correct, InfoEnum incorrect);
        void InitializePlaySteps(I_Network network, I_AgentSet agent_set);
        void InitializeRunRounds(I_Network network, I_AgentSet agent_set);
        void PrintInfo();
        void PrintInfo(int node_id);
    }
}
