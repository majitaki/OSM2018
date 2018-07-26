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
        double AwaRate { get; }
        List<double> BeliefScaleList { get; }
        int OpinionFormedSuccessCounts { get; }
        int OpinionFormedFailureCounts { get; }
    }
}
