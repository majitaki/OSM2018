using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_AgentSet
    {
        int AgentSeed { get; }
        List<I_Agent> AgentList { get; }
        void SetSensors(SetSensorMode mode , int num, double sensor_acc);
        void SetSensors(SetSensorMode mode , double rate, double sensor_acc);
        void SetInitWeights(List<double> init_weight_list);
        void SetInitWeights(List<Dictionary<int, double>> init_weight_dictionary_list);
    }
}
