using OSM2018.AgentSets;
using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Factories
{
    class AgentFactory
    {
        public I_Agent Generate(I_Node node, InfoEnum init_op, double o_sigma, double b_sigma, AgentInitMode mode)
        {
            var node_id = node.NodeID;
            var init_weight_list = new Dictionary<int, double>();
            foreach (var neighbor in node.NeighborNodeIDList)
            {
                init_weight_list.Add(neighbor, 1.0);
            }
            double init_belief = 0;

            var ir = RandomPool.Get(SeedEnum.AgentSeed);
            switch (mode)
            {
                case AgentInitMode.Random:
                    init_belief = ir.NextDouble(b_sigma, o_sigma);
                    break;
                case AgentInitMode.RandomWeakPulledByOpinion:
                    if (init_op == InfoEnum.Orange)
                    {
                        init_belief = ir.NextDouble(0.5, o_sigma);
                    }
                    else
                    {
                        init_belief = ir.NextDouble(b_sigma, 0.5);
                    }
                    break;
                case AgentInitMode.RandomStrongPulledByOpinion:
                    if (init_op == InfoEnum.Orange)
                    {
                        init_belief = ir.NextDouble(o_sigma, 1.0);
                    }
                    else
                    {
                        init_belief = ir.NextDouble(0, b_sigma);
                    }
                    break;
                case AgentInitMode.Normal:
                    init_belief = ir.NextNormal(0.5, o_sigma);
                    break;
                case AgentInitMode.NormalWeakPulledByOpinion:
                    break;
                case AgentInitMode.NormalStrongPulledByOpinion:
                    break;
                default:
                    break;
            }
            return new BaseAgent(node_id, init_belief, init_weight_list, init_op, o_sigma, b_sigma);
        }
    }
}
