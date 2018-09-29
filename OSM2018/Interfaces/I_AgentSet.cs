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
        void SetSensors(int num, double sensor_acc);
        void SetInitWeightList(List<double> init_weight_list);
        void SetInitWeightDicList(List<Dictionary<int, double>> init_weight_dictionary_list);
        void SetWeightList(List<double> weight_list);
        void SetWeightDicList(List<Dictionary<int, double>> weight_dic_list);
        void InitBelief();
        void InitOpinion();
        void InitWeight();
        void InitCounts();
        void InitRoundInfo();
        Dictionary<string, string> GetInfoString();
    }
}
