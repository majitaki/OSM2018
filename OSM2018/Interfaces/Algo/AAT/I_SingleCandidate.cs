using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces.Algo.AAT
{
    interface I_SingleCandidate
    {
        int CanIndex { get; }
        double CanWeight { get; }
        double AwaRate { get; set; }
        int AwaCounts { get; set; }
        int AwaCurrentRounds { get; set; }
        List<double> BeliefScaleList { get; }
        int OpinionFormedSuccessCounts { get; }
        int OpinionFormedFailureCounts { get; }
    }
}
