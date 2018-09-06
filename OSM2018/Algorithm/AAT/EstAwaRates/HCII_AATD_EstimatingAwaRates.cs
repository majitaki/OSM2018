using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.AAT.EstAwaRates
{
    class HCII_AATD_EstimatingAwaRates : I_EstimatingAwaRates
    {
        public void Run(I_AgentSet agent_set, List<I_CandidateSet> canset_list, int current_round)
        {
            foreach (var agent in agent_set.AgentList)
            {
                var canset = canset_list[agent.NodeID];
                if (!agent.IsReceived) continue;
                this.UpdateAveAwaRates(current_round, agent, canset);
            }
        }

        void UpdateAveAwaRates(int current_round, I_Agent agent, I_CandidateSet canset)
        {
            var select_can = canset.GetCandidate(canset.SelectCanIndex);
            foreach (var can in canset.SingleCandidateList)
            {
                var pre_counts = (current_round - 1) * can.AwaRate;

                if (this.IsEvsOpinionFormed(agent, select_can, can, canset))
                {
                    can.AwaRate = (pre_counts + 1) / current_round;
                    can.AwaCounts = (int)pre_counts + 1;
                    can.AwaCurrentRounds = current_round;
                }
                else
                {
                    can.AwaRate = (pre_counts + 0) / current_round;
                    can.AwaCounts = (int)pre_counts + 0;
                    can.AwaCurrentRounds = current_round;
                }
            }
        }

        bool IsEvsOpinionFormed(I_Agent agent, I_SingleCandidate select_can, I_SingleCandidate other_can, I_CandidateSet canset)
        {
            bool evs1 = this.IsChanged(agent) && this.IsBiggerWeight(select_can, other_can);
            bool evs2 = this.IsBigWeightOfReqU(other_can, agent, canset);

            return evs1 || evs2;
        }

        bool IsChanged(I_Agent agent)
        {
            return (agent.Opinion != agent.InitOpinion) ? true : false;
        }

        bool IsBiggerWeight(I_SingleCandidate select_can, I_SingleCandidate other_can)
        {
            double other_canwei = other_can.CanWeight;
            double select_canwei = select_can.CanWeight;

            return (other_canwei >= select_canwei) ? true : false;
        }

        bool IsBigWeightOfReqU(I_SingleCandidate other_can, I_Agent agent, I_CandidateSet canset)
        {
            int obs_u = Math.Abs(agent.ReceiveGreenCounts - agent.ReceiveRedCounts);

            if (obs_u <= 0)
            {
                obs_u = Math.Abs(canset.SingleCandidateList.OrderBy(can => can.CanWeight).Last().CanIndex);
            }

            if (obs_u > canset.SingleCandidateList.OrderBy(can => can.CanIndex).Last().CanIndex)
            {
                obs_u = Math.Abs(canset.SingleCandidateList.OrderBy(can => can.CanWeight).First().CanIndex);
            }

            double req_w = canset.SingleCandidateList.Where(can => Math.Abs(can.CanIndex) == obs_u).Select(can => can.CanWeight).Min();
            double other_w = other_can.CanWeight;

            return (other_w >= req_w) ? true : false;
        }

    }
}
