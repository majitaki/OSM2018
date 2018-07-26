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
        void RunRound(I_Network network, I_AgentSet agent_set);
        void PlayStep(I_Network network, I_AgentSet agent_set);
    }
}
