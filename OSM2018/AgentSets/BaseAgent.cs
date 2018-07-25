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
        public List<double> WeightList { get; }
        public List<double> InitWeightList { get; private set; }
        public double OrangeSigma { get; }
        public double BlueSigma { get; }
        public InfoEnum Opinion { get; }
        public InfoEnum InitOpinion { get; private set; }
        public bool IsSensor { get; private set; }

        public BaseAgent(int id, double init_belief, List<double> init_weight_list, InfoEnum init_op, double o_sigma, double b_sigma)
        {
            this.NodeID = id;
            this.Belief = this.InitBelief = init_belief;
            this.WeightList = new List<double>(init_weight_list);
            this.InitWeightList = new List<double>(init_weight_list);
            this.Opinion = this.InitOpinion = init_op;
            this.OrangeSigma = o_sigma;
            this.BlueSigma = b_sigma;
            this.IsSensor = false;
        }

        public void SetInitialize(double init_belief, InfoEnum init_op, List<double> init_weight_list)
        {
            this.InitBelief = init_belief;
            this.InitOpinion = init_op;
            this.InitWeightList = new List<double>(init_weight_list);
        }

        public void SetSensor(bool is_sensor)
        {
            this.IsSensor = is_sensor;
        }
    }
}
