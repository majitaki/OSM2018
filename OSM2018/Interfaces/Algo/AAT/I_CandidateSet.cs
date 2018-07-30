using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces.Algo.AAT
{
    interface I_CandidateSet
    {
        List<I_SingleCandidate> SingleCandidateList { get; }
        int InitSelectCanIndex { get; }
        int SelectCanIndex { get; }
        List<int> DeterminedRoundList { get; }
        double GetCanWeight(int index);
        I_SingleCandidate GetCandidate(int can_index);
        I_SingleCandidate GetSelectCandidate();
    }
}
