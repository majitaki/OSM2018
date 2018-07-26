using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Interfaces.Algo.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.AAT
{
    class AAT_Algo:I_Algo
    {
        I_GeneratingCandidateWeights GeneCanWeights;
        I_EstimatingAwarenesRates EstAwaRates;
        I_SelectingWeightsStrategies SlctWeightsStrategies;

        public AAT_Algo(I_GeneratingCandidateWeights gcw, I_EstimatingAwarenesRates ear, I_SelectingWeightsStrategies sws)
        {
            this.GeneCanWeights = gcw;
            this.EstAwaRates = ear;
            this.SlctWeightsStrategies = sws;
        }

        public void Initialize(I_Network network, I_AgentSet agent_set)
        {
            this.GeneCanWeights.Generate(network, agent_set);
        }

        public void PlayStep(I_Network network, I_AgentSet agent_set)
        {
            throw new NotImplementedException();
        }

        public void RunRound(I_Network network, I_AgentSet agent_set)
        {

        }
    }
}
