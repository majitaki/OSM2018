using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo.AAT;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.AAT
{
    class SingleCandidate : I_SingleCandidate
    {
        public int CanIndex { get; }
        public double CanWeight { get; }
        public double AwaRate { get; }
        public List<double> BeliefScaleList { get; }
        public int OpinionFormedSuccessCounts { get; }
        public int OpinionFormedFailureCounts { get; }

        public SingleCandidate(int can_index, I_Agent agent)
        {
            this.CanIndex = can_index;
            this.CanWeight = OpinionUpdater.GetWeightForScale(agent.InitBelief, agent.OrangeSigma, agent.BlueSigma, can_index);

            this.BeliefScaleList = new List<double>();
            this.BeliefScaleList.Add(agent.InitBelief);

            var current_belief = agent.InitBelief;
            while (current_belief < agent.OrangeSigma)
            {
                current_belief = OpinionUpdater.UpdateBelief(current_belief, CanWeight, InfoEnum.Orange);
                this.BeliefScaleList.Add(current_belief);
            }

            current_belief = agent.InitBelief;
            while (current_belief > agent.BlueSigma)
            {
                current_belief = OpinionUpdater.UpdateBelief(current_belief, CanWeight, InfoEnum.Blue);
                this.BeliefScaleList.Add(current_belief);
            }
        }
    }
}
