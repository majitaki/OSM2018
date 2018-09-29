using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces.Algo.IWT
{
    interface I_SurpriseIndicator
    {
        int SourceNodeID { get; }
        int TargetNodeID { get; }
        double InitValue { get; }
        double PreValue { get; }
        double CurValue { get; }
        List<double> SelfInfoList { get; }

        void Initialize();
        void InitializeForPlaySteps();
        void UpdateForNextRound();
        void InputOpinion(InfoEnum op, double belief);
    }
}
