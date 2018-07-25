using OSM2018.AgentSets;
using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Factories.AgentSetFactories
{
    class BasicAgentSetFactory
    {
        I_Network MyNetwork;
        InfoEnum InitOpinion;
        double OrangeSigma;
        double BlueSigma;

        public BasicAgentSetFactory(I_Network network, InfoEnum init_op, double o_sigama, double b_sigma)
        {
            this.MyNetwork = network;
            this.InitOpinion = init_op;
            this.OrangeSigma = o_sigama;
            this.BlueSigma = b_sigma;
        }

        public I_AgentSet Generate(int agent_seed)
        {
            List<I_Agent> agent_list = new List<I_Agent>();
            RandomPool.Declare(SeedEnum.AgentSeed, agent_seed);
            foreach (var node in this.MyNetwork.NodeList)
            {
                var agent = new AgentFactory().Generate(node, this.InitOpinion, this.OrangeSigma, this.BlueSigma, AgentInitMode.Random);
                agent_list.Add(agent);
            }
            return new BaseAgentSet(agent_list, agent_seed);
        }

    }
}
