using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Interfaces.Algo.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.AAT {
  class AAT_Algo : I_Algo {
    I_GeneratingCanWeights GeneCanWeights;
    I_EstimatingAwaRates EstAwaRates;
    I_SelectingWeiStrategies SlctWeiStrategies;
    public List<I_CandidateSet> CandidateSetList { get; private set; }

    public AAT_Algo(I_GeneratingCanWeights gcw, I_EstimatingAwaRates ear, I_SelectingWeiStrategies sws) {
      this.GeneCanWeights = gcw;
      this.EstAwaRates = ear;
      this.SlctWeiStrategies = sws;
    }

    public void Initialize(I_Network network, I_AgentSet agent_set) {
      this.CandidateSetList = GeneCanWeights.Generate(network, agent_set);
      var weight_list = this.CandidateSetList.Select(can => can.GetCanWeight(can.InitSelectCanIndex)).ToList();
      agent_set.SetInitWeights(weight_list);
    }

    public void PlayStep(I_Network network, I_AgentSet agent_set) {
      throw new NotImplementedException();
    }

    public void RunRound(I_Network network, I_AgentSet agent_set) {

    }
  }
}
