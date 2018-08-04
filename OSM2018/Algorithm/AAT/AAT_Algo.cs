using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Interfaces.Algo.AAT;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.AAT
{
    class AAT_Algo : I_Algo
    {
        public AlgoEnum MyAlgoEnum { get; }
        I_GeneratingCanWeights GeneCanWeights;
        I_EstimatingAwaRates EstAwaRates;
        I_SelectingWeiStrategies SlctWeiStrategies;
        I_PlayOneStep MyPlayOneStep;
        public List<I_CandidateSet> CandidateSetList { get; private set; }


        public AAT_Algo(I_GeneratingCanWeights gcw, I_EstimatingAwaRates ear, I_SelectingWeiStrategies sws, I_PlayOneStep pos)
        {
            this.GeneCanWeights = gcw;
            this.EstAwaRates = ear;
            this.SlctWeiStrategies = sws;
            this.MyPlayOneStep = pos;
            this.MyAlgoEnum = AlgoEnum.OriginalAAT;
        }

        public void Initialize(I_Network network, I_AgentSet agent_set)
        {
            agent_set.InitBelief();
            agent_set.InitOpinion();
            this.MyPlayOneStep.Initialize();

            this.CandidateSetList = GeneCanWeights.Generate(network, agent_set);
            var weight_list = this.CandidateSetList.Select(can => can.GetCanWeight(can.InitSelectCanIndex)).ToList();
            //weight_list = weight_list.Select(w => 0.7).ToList();

            agent_set.SetInitWeights(weight_list);
        }

        public void PlayOneStep(I_Network network, I_AgentSet agent_set, InfoEnum correct, InfoEnum incorrect)
        {
            this.MyPlayOneStep.Run(network, agent_set, true, correct, incorrect);
        }

        public void RunOneRound(I_Network network, I_AgentSet agent_set, int current_round, int total_rounds, int round_steps)
        {
            for (int i = 0; i < round_steps; i++)
            {
                this.PlayOneStep(network, agent_set, InfoEnum.Green, InfoEnum.Red);
            }

            this.EstAwaRates.Run(agent_set, this.CandidateSetList, current_round, total_rounds);
            this.SlctWeiStrategies.Run(this.CandidateSetList);
            agent_set.InitBelief();
            agent_set.InitOpinion();
            this.MyPlayOneStep.Initialize();
        }

    }
}
