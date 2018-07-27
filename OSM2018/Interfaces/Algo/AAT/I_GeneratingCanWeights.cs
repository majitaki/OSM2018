using OSM2018.Algorithm.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces.Algo.AAT
{
    interface I_GeneratingCanWeights
    {
        List<I_CandidateSet> Generate(I_Network network, I_AgentSet agent_set);
      
    }
}
