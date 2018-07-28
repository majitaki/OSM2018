using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces.Algo
{
    interface I_Algo
    {
        void Initialize(I_Network network, I_AgentSet agent_set);
        void RunOneRound(I_Network network, I_AgentSet agent_set, int current_round, int total_rounds);
        void PlayOneStep(I_Network network, I_AgentSet agent_set);
    }
}
