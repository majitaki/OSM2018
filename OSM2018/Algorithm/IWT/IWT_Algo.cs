using OSM2018.Algorithm.Common;
using OSM2018.Algorithm.IWT.Indicator;
using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Interfaces.Algo.AAT;
using OSM2018.Interfaces.Algo.IWT;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.IWT
{
    class IWT_Algo : I_Algo
    {
        public AlgoEnum MyAlgoEnum { get; }
        I_GeneratingCanWeights GeneCanWeights;
        I_EstimatingAwaRates EstAwaRates;
        I_SelectingWeiStrategies SlctWeiStrategies;
        I_PlayOneStep MyPlayOneStep;
        public I_OSMLog MyOSMLog { get; }
        public List<I_CandidateSet> CandidateSetList { get; private set; }
        I_SurpriseIndicatorSet SurpriseIndicatorSet { get; }

        public IWT_Algo(AlgoEnum algo_enum, I_GeneratingCanWeights gcw, I_EstimatingAwaRates ear, I_SelectingWeiStrategies sws, I_PlayOneStep pos, I_SurpriseIndicatorSet sur_indi_set)
        {
            this.GeneCanWeights = gcw;
            this.EstAwaRates = ear;
            this.SlctWeiStrategies = sws;
            this.MyPlayOneStep = pos;
            this.MyAlgoEnum = algo_enum;
            this.MyOSMLog = new OSMLog();
            this.SurpriseIndicatorSet = sur_indi_set;
        }

        public Dictionary<string, string> GetInfoString()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 生成とラウンド開始時に呼び出してagentsetを初期化．
        /// </summary>
        /// <param name="network"></param>
        /// <param name="agent_set"></param>
        public void Initialize(I_Network network, I_AgentSet agent_set)
        {
            agent_set.InitBelief();
            agent_set.InitOpinion();
            agent_set.InitCounts();
            agent_set.InitRoundInfo();
            this.SurpriseIndicatorSet.Initialize();

            this.MyPlayOneStep.Initialize();
            this.CandidateSetList = GeneCanWeights.Generate(network, agent_set);

            this.SurpriseIndicatorSet.SetWeightDicList(this.CandidateSetList, network);
            var wei_dic_list = this.SurpriseIndicatorSet.WeightDic;
            agent_set.SetInitWeightDicList(wei_dic_list);
        }

        public void InitializePlaySteps(I_Network network, I_AgentSet agent_set)
        {
            agent_set.InitBelief();
            agent_set.InitOpinion();
            agent_set.InitCounts();
            this.SurpriseIndicatorSet.InitializeForPlaySteps();
            this.MyPlayOneStep.Initialize();
        }

        public void InitializeRunRounds(I_Network network, I_AgentSet agent_set)
        {
            this.Initialize(network, agent_set);
        }

        public void PlayOneStep(I_Network network, I_AgentSet agent_set, InfoEnum correct, InfoEnum incorrect)
        {
            this.MyPlayOneStep.Run(network, agent_set, true, correct, incorrect);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Algo Enum: {this.MyAlgoEnum}");
        }

        public void PrintInfo(int node_id)
        {
            Console.WriteLine($"Algo: {this.MyAlgoEnum}");

            var sus_indi_list = this.SurpriseIndicatorSet.Value.Where(indi => indi.SourceNodeID == node_id).ToList();
            var wei_dic_list = this.SurpriseIndicatorSet.WeightDic;
            var wei_dic = wei_dic_list[node_id];

            foreach (var sus_indi in sus_indi_list)
            {
                var weight = wei_dic[sus_indi.TargetNodeID];
                Console.WriteLine($"nei_id: {sus_indi.TargetNodeID,3} weight: {weight:f3} pre: {sus_indi.PreValue:f3} cur: {sus_indi.CurValue:f3}");
            }

            Console.WriteLine();

            Console.WriteLine();

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

        public void RunOneRound(I_Network network, I_AgentSet agent_set, int current_round, int round_steps)
        {
            for (int i = 0; i < round_steps; i++)
            {
                this.PlayOneStep(network, agent_set, InfoEnum.Green, InfoEnum.Red);
            }

            this.RunOneRoundWithoutPlaySteps(network, agent_set, current_round);
            return;
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
            this.SurpriseIndicatorSet.UpdateForNextRound();
            this.SurpriseIndicatorSet.SetWeightDicList(this.CandidateSetList, network);
            var wei_dic_list = this.SurpriseIndicatorSet.WeightDic;

            //var weight_list = this.CandidateSetList.Select(can => can.GetCanWeight(can.SelectCanIndex)).ToList();
            agent_set.SetWeightDicList(wei_dic_list);
            agent_set.InitBelief();
            agent_set.InitOpinion();
            agent_set.InitCounts();
            this.MyPlayOneStep.Initialize();
        }
    }
}
