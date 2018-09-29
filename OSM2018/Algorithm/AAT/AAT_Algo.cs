using OSM2018.Algorithm.Common;
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
        public I_OSMLog MyOSMLog { get; }
        public List<I_CandidateSet> CandidateSetList { get; private set; }


        public AAT_Algo(AlgoEnum algo_enum, I_GeneratingCanWeights gcw, I_EstimatingAwaRates ear, I_SelectingWeiStrategies sws, I_PlayOneStep pos)
        {
            this.GeneCanWeights = gcw;
            this.EstAwaRates = ear;
            this.SlctWeiStrategies = sws;
            this.MyPlayOneStep = pos;
            this.MyAlgoEnum = algo_enum;
            this.MyOSMLog = new OSMLog();
        }

        public void Initialize(I_Network network, I_AgentSet agent_set)
        {
            agent_set.InitBelief();
            agent_set.InitOpinion();
            agent_set.InitCounts();
            agent_set.InitRoundInfo();


            this.MyPlayOneStep.Initialize();

            this.CandidateSetList = GeneCanWeights.Generate(network, agent_set);
            var weight_list = this.CandidateSetList.Select(can => can.GetCanWeight(can.InitSelectCanIndex)).ToList();
            //weight_list = weight_list.Select(w => 0.8).ToList();

            agent_set.SetInitWeightList(weight_list);
        }

        public void PlayOneStep(I_Network network, I_AgentSet agent_set, InfoEnum correct, InfoEnum incorrect)
        {
            this.MyPlayOneStep.Run(network, agent_set, true, correct, incorrect);
        }

        public void RunOneRoundWithoutPlaySteps(I_Network network, I_AgentSet agent_set, int current_round)
        {
            foreach (var agent in agent_set.AgentList)
            {
                if (agent.IsChanged) agent.ChangedRoundList.Add(current_round);
                if (agent.IsReceived) agent.ReceiveRoundList.Add(current_round);
            }

            this.MyOSMLog.RecordOneRound(network, agent_set, current_round);

            this.EstAwaRates.Run(agent_set, this.CandidateSetList, current_round);
            this.SlctWeiStrategies.Run(this.CandidateSetList, agent_set, current_round);
            var weight_list = this.CandidateSetList.Select(can => can.GetCanWeight(can.SelectCanIndex)).ToList();
            agent_set.SetWeightList(weight_list);
            agent_set.InitBelief();
            agent_set.InitOpinion();
            agent_set.InitCounts();
            this.MyPlayOneStep.Initialize();
        }

        public void RunOneRound(I_Network network, I_AgentSet agent_set, int current_round, int round_steps)
        {
            for (int i = 0; i < round_steps; i++)
            {
                this.PlayOneStep(network, agent_set, InfoEnum.Green, InfoEnum.Red);
            }

            this.RunOneRoundWithoutPlaySteps(network, agent_set, current_round);
            return;
        }

        public void InitializePlaySteps(I_Network network, I_AgentSet agent_set)
        {
            agent_set.InitBelief();
            agent_set.InitOpinion();
            agent_set.InitCounts();
            this.MyPlayOneStep.Initialize();
        }

        public void InitializeRunRounds(I_Network network, I_AgentSet agent_set)
        {
            this.Initialize(network, agent_set);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Algo Enum: {this.MyAlgoEnum}");
        }

        public void PrintInfo(int node_id)
        {
            Console.WriteLine($"Algo: {this.MyAlgoEnum}");

            var canset = this.CandidateSetList[node_id];
            var sort_canset = canset.SingleCandidateList.OrderBy(can => can.CanWeight).ToList();

            foreach (var can in sort_canset)
            {
                var select = (can.CanIndex == canset.SelectCanIndex) ? "*" : "";
                var can_index = can.CanIndex;
                var can_weight = can.CanWeight;
                var h_count = can.AwaCounts;
                var h_round = can.AwaCurrentRounds;
                var h = can.AwaRate;
                Console.WriteLine($"index: {can_index,3} can_weight: {can_weight:f3} h_count: {h_count,3} h_round: {h_round,3} h: {h:f4} {select}");
            }
        }

        public Dictionary<string, string> GetInfoString()
        {
            var dic = new Dictionary<string, string>();
            dic.Add("algo", this.MyAlgoEnum.ToString());

            return dic;
        }
    }
}
