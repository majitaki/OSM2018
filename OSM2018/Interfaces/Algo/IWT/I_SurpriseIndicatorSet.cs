using OSM2018.Algorithm.IWT.Indicator;
using OSM2018.Interfaces.Algo.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces.Algo.IWT
{
    interface I_SurpriseIndicatorSet
    {
        List<I_SurpriseIndicator> Value { get; }
        List<Dictionary<int, double>> WeightDic { get; }
        void Initialize();
        void InitializeForPlaySteps();
        void UpdateForNextRound();
        void SetWeightDicList(List<I_CandidateSet> canset_list, I_Network network);
    }
}
