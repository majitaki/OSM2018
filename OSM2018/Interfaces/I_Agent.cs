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
        double Belief { get; set; }
        double InitBelief { get; }
        InfoEnum Opinion { get; set; }
        InfoEnum InitOpinion { get; }
        Dictionary<int, double> WeightDic { get; set; }
        Dictionary<int, double> InitWeightDic { get; }
        double GreenSigma { get; }
        double RedSigma { get; }
        bool IsSensor { get; }
        int ReceiveGreenCounts { get; set; }
        int ReceiveRedCounts { get; set; }
        double SensorAccuracy { get; }
        bool IsChanged { get; set; }
        Queue<I_Message> SendReadyMessageQueue { get; set; }

        void Initialize();

        void SetInitialize(double init_belief, InfoEnum init_op, Dictionary<int, double> init_weight_list);
        void SetSensor(bool is_sensor, double sensor_acc);
        void SetInitWeight(double weight);
        void SetInitWeightList(Dictionary<int, double> weight_list);
    }
}
