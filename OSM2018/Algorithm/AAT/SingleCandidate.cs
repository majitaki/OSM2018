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
        public double AwaRate { get; set; }
        public List<double> BeliefScaleList { get; }
        public int OpinionFormedSuccessCounts { get; }
        public int OpinionFormedFailureCounts { get; }

        public SingleCandidate(int can_index, I_Agent agent)
        {
            this.CanIndex = can_index;
            this.CanWeight = OpinionBeliefUpdater.GetWeightForScale(agent.InitBelief, agent.GreenSigma, agent.RedSigma, can_index);

            this.BeliefScaleList = new List<double>();
            this.BeliefScaleList.Add(agent.InitBelief);

            var current_belief = agent.InitBelief;
            while (current_belief < agent.GreenSigma)
            {
                current_belief = OpinionBeliefUpdater.UpdateBelief(current_belief, CanWeight, InfoEnum.Green);
                this.BeliefScaleList.Add(current_belief);
            }

            current_belief = agent.InitBelief;
            while (current_belief > agent.RedSigma)
            {
                current_belief = OpinionBeliefUpdater.UpdateBelief(current_belief, CanWeight, InfoEnum.Red);
                this.BeliefScaleList.Add(current_belief);
            }
        }
    }
}
