using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.AAT.GeneCanWeights
{
    class GeneratingCanWeights : I_GeneratingCanWeights
    {
        public List<I_CandidateSet> Generate(I_Network network, I_AgentSet agent_set)
        {
            List<I_CandidateSet> canset_list = new List<I_CandidateSet>();

            I_CandidateSet canset;
            foreach (var node in network.NodeList)
            {
                canset = new CandidateSet(node, agent_set.AgentList[node.NodeID]);
                canset_list.Add(canset);
            }
            return canset_list;
        }
    }
}
