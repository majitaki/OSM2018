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
        double GreenSigma;
        double RedSigma;

        public BasicAgentSetFactory(I_Network network, InfoEnum init_op, double g_sigama, double r_sigma)
        {
            this.MyNetwork = network;
            this.InitOpinion = init_op;
            this.GreenSigma = g_sigama;
            this.RedSigma = r_sigma;
        }

        public I_AgentSet Generate(int agent_seed, AgentInitMode mode)
        {
            List<I_Agent> agent_list = new List<I_Agent>();
            RandomPool.Declare(SeedEnum.AgentSeed, agent_seed);
            foreach (var node in this.MyNetwork.NodeList)
            {
                var agent = new AgentFactory().Generate(node, this.InitOpinion, this.GreenSigma, this.RedSigma, mode);
                agent_list.Add(agent);
            }
            return new BaseAgentSet(agent_list, agent_seed);
        }
    }
}
