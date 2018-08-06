using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces.Algo.AAT
{
    interface I_EstimatingAwaRates
    {
        void Run(I_AgentSet agent_set, List<I_CandidateSet> canset_list, int current_round);
    }
}
