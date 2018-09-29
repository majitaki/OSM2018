using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.IWT
{
    class SingleSusceptCandidate : I_SingleCandidate
    {
        public int CanIndex { get; }
        public double CanWeight { get; }
        public double AwaRate { get; set; }
        public int AwaCounts { get; set; }
        public int AwaCurrentRounds { get; set; }
        public List<double> BeliefScaleList { get; }
        public int OpinionFormedSuccessCounts { get; }
        public int OpinionFormedFailureCounts { get; }

        public SingleSusceptCandidate(int can_index, double step_size, I_Agent agent)
        {
            this.CanIndex = can_index;
            this.CanWeight = Math.Abs(can_index * step_size);
            this.AwaCounts = 0;
            this.AwaCurrentRounds = 0;

            this.BeliefScaleList = new List<double>();
        }
    }
}
