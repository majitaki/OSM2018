using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo.AAT;
using OSM2018.Utility;

namespace OSM2018.Algorithm.AAT.EstAwaRates
{
    class EstimatingAwaRates : I_EstimatingAwaRates
    {
        public void Run(I_AgentSet agent_set, List<I_CandidateSet> canset_list, int current_round)
        {
            foreach (var agent in agent_set.AgentList)
            {
                var canset = canset_list[agent.NodeID];
                int obs_u = Math.Abs(agent.ReceiveGreenCounts - agent.ReceiveRedCounts);
                if (obs_u == 0) continue;
                this.UpdateAveAwaRates(current_round, agent, canset);
            }
        }

        void UpdateAveAwaRates(int current_round, I_Agent agent, I_CandidateSet canset)
        {
            var select_can = canset.GetCandidate(canset.SelectCanIndex);
            foreach (var can in canset.SingleCandidateList)
            {
                var pre_counts = (current_round - 1) * can.AwaRate;

                if (this.IsEvsOpinionFormed(agent, select_can, can))
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

        bool IsEvsOpinionFormed(I_Agent agent, I_SingleCandidate select_can, I_SingleCandidate other_can)
        {
            bool evs1 = this.IsDetermined(agent) && this.IsBiggerWeight(select_can, other_can);
            bool evs2 = this.IsSmallerU(other_can, agent) && (other_can.CanWeight != select_can.CanWeight);

            return evs1 || evs2;
        }

        bool IsDetermined(I_Agent agent)
        {
            return (agent.Opinion != InfoEnum.Undeter) ? true : false;
        }

        bool IsBiggerWeight(I_SingleCandidate select_can, I_SingleCandidate other_can)
        {
            double other_canwei = other_can.CanWeight;
            double select_canwei = select_can.CanWeight;

            return (other_canwei >= select_canwei) ? true : false;
        }

        bool IsSmallerU(I_SingleCandidate other_can, I_Agent agent)
        {
            int req_u = Math.Abs(other_can.CanIndex);
            int obs_u = Math.Abs(agent.ReceiveGreenCounts - agent.ReceiveRedCounts);

            return (obs_u >= req_u) ? true : false;
        }
    }
}
