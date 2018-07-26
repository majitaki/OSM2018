using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_Agent
    {
        int NodeID { get; }
        double Belief { get; }
        double InitBelief { get; }
        InfoEnum Opinion { get; }
        InfoEnum InitOpinion { get; }
        Dictionary<int, double> WeightList { get; }
        Dictionary<int, double> InitWeightList { get; }
        double GreenSigma { get; }
        double RedSigma { get; }
        bool IsSensor { get; }

        void SetInitialize(double init_belief, InfoEnum init_op, Dictionary<int, double> init_weight_list);
        void SetSensor(bool is_sensor);
    }
}
