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
        public Dictionary<int, double> WeightList { get; }
        public Dictionary<int, double> InitWeightList { get; private set; }
        public double GreenSigma { get; }
        public double RedSigma { get; }
        public InfoEnum Opinion { get; }
        public InfoEnum InitOpinion { get; private set; }
        public bool IsSensor { get; private set; }


        public BaseAgent(int id, double init_belief, Dictionary<int, double> init_weight_list, InfoEnum init_op, double g_sigma, double r_sigma)
        {
            this.NodeID = id;
            this.Belief = this.InitBelief = init_belief;
            this.WeightList = new Dictionary<int, double>(init_weight_list);
            this.InitWeightList = new Dictionary<int, double>(init_weight_list);
            this.Opinion = this.InitOpinion = init_op;
            this.GreenSigma = g_sigma;
            this.RedSigma = r_sigma;
            this.IsSensor = false;
        }

        public void SetInitialize(double init_belief, InfoEnum init_op, Dictionary<int,double> init_weight_list)
        {
            this.InitBelief = init_belief;
            this.InitOpinion = init_op;
            this.InitWeightList = new Dictionary<int, double>(init_weight_list);
        }

        public void SetSensor(bool is_sensor)
        {
            this.IsSensor = is_sensor;
        }
    }
}
