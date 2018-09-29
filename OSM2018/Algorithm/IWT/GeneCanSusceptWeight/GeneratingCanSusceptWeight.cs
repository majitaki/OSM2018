using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.IWT.GeneCanSusceptWeight
{
    class GeneratingCanSusceptWeight : I_GeneratingCanWeights
    {
        double StepSize;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="step_size">探索のため，weightの区切りの大きさ</param>
        public GeneratingCanSusceptWeight(double step_size = 0.1)
        {
            this.StepSize = step_size;
        }

        public List<I_CandidateSet> Generate(I_Network network, I_AgentSet agent_set)
        {
            List<I_CandidateSet> canset_list = new List<I_CandidateSet>();

            I_CandidateSet canset;
            foreach (var node in network.NodeList)
            {
                canset = new SusceptCandidateSet(node, agent_set.AgentList[node.NodeID], this.StepSize);
                canset_list.Add(canset);
            }
            return canset_list;
        }
    }
}
