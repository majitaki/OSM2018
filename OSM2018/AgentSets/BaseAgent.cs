using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.AgentSets
{
    class BaseAgent : I_Agent
    {
        public int NodeID { get; }
        public double Belief { get; }
        public double InitBelief { get; private set; }
        public Dictionary<int, double> WeightDic { get; private set; }
        public Dictionary<int, double> InitWeightDic { get; private set; }
        public double GreenSigma { get; }
        public double RedSigma { get; }
        public InfoEnum Opinion { get; }
        public InfoEnum InitOpinion { get; private set; }
        public bool IsSensor { get; private set; }


        public BaseAgent(int id, double init_belief, Dictionary<int, double> init_weight_list, InfoEnum init_op, double g_sigma, double r_sigma)
        {
            this.NodeID = id;
            this.Belief = this.InitBelief = init_belief;
            this.WeightDic = new Dictionary<int, double>(init_weight_list);
            this.InitWeightDic = new Dictionary<int, double>(init_weight_list);
            this.Opinion = this.InitOpinion = init_op;
            this.GreenSigma = g_sigma;
            this.RedSigma = r_sigma;
            this.IsSensor = false;
        }

        public void SetInitialize(double init_belief, InfoEnum init_op, Dictionary<int, double> init_weight_list)
        {
            this.InitBelief = init_belief;
            this.InitOpinion = init_op;
            this.InitWeightDic = new Dictionary<int, double>(init_weight_list);
        }

        public void SetSensor(bool is_sensor)
        {
            this.IsSensor = is_sensor;
        }

        public void SetInitWeight(double init_weight)
        {
            Dictionary<int, double> init_weight_dic = new Dictionary<int, double>();

            foreach (var weight_element in this.WeightDic)
            {
                init_weight_dic.Add(weight_element.Key, init_weight);
            }
            this.InitWeightDic = init_weight_dic;
            this.WeightDic = new Dictionary<int, double>(this.InitWeightDic);
        }

        public void SetInitWeightList(Dictionary<int, double> init_weight_dic)
        {
            this.InitWeightDic = init_weight_dic;
            this.WeightDic = new Dictionary<int, double>(this.InitWeightDic);
        }
    }
}
