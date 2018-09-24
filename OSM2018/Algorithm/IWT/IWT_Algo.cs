using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Interfaces.Algo.AAT;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.IWT {
  class IWT_Algo : I_Algo {
    public AlgoEnum MyAlgoEnum { get; }
    I_GeneratingCanWeights GeneCanWeights;
    I_EstimatingAwaRates EstAwaRates;
    I_SelectingWeiStrategies SlctWeiStrategies;
    I_PlayOneStep MyPlayOneStep;
    public I_OSMLog MyOSMLog { get; }
    public List<I_CandidateSet> CandidateSetList { get; private set; }


    public IWT_Algo() {

    }

    public Dictionary<string, string> GetInfoString() {
      throw new NotImplementedException();
    }

    public void Initialize(I_Network network, I_AgentSet agent_set) {
      throw new NotImplementedException();
    }

    public void InitializePlaySteps(I_Network network, I_AgentSet agent_set) {
      throw new NotImplementedException();
    }

    public void InitializeRunRounds(I_Network network, I_AgentSet agent_set) {
      throw new NotImplementedException();
    }

    public void PlayOneStep(I_Network network, I_AgentSet agent_set, InfoEnum correct, InfoEnum incorrect) {
      throw new NotImplementedException();
    }

    public void PrintInfo() {
      throw new NotImplementedException();
    }

    public void PrintInfo(int node_id) {
      throw new NotImplementedException();
    }

    public void RunOneRound(I_Network network, I_AgentSet agent_set, int current_round, int round_steps) {
      throw new NotImplementedException();
    }

    public void RunOneRoundWithoutPlaySteps(I_Network network, I_AgentSet agent_set, int current_round) {
      throw new NotImplementedException();
    }
  }
}
