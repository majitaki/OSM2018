using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.AgentSets.IWT
{
    class IWT_Agent : I_Agent
    {
        public int NodeID { get; }
        public double Belief { get; set; }
        public double InitBelief { get; private set; }
        public Dictionary<int, double> WeightDic { get; set; }
        public Dictionary<int, double> InitWeightDic { get; private set; }
        public double GreenSigma { get; }
        public double RedSigma { get; }
        public InfoEnum Opinion { get; set; }
        public InfoEnum InitOpinion { get; private set; }
        public bool IsSensor { get; private set; }
        public int ReceiveGreenCounts { get; set; }
        public int ReceiveRedCounts { get; set; }
        public double SensorAccuracy { get; private set; }
        public bool IsChanged { get; set; }
        public bool IsReceived { get; set; }
        public Queue<I_Message> SendReadyMessageQueue { get; set; }
        public List<int> ChangedRoundList { get; set; }
        public List<int> ReceiveRoundList { get; set; }

        public IWT_Agent(int id, double init_belief, Dictionary<int, double> init_weight_list, InfoEnum init_op, double g_sigma, double r_sigma)
        {
            this.NodeID = id;
            this.Belief = this.InitBelief = init_belief;
            this.WeightDic = new Dictionary<int, double>(init_weight_list);
            this.InitWeightDic = new Dictionary<int, double>(init_weight_list);
            this.Opinion = this.InitOpinion = init_op;
            this.GreenSigma = g_sigma;
            this.RedSigma = r_sigma;
            this.IsSensor = false;
            this.SensorAccuracy = 0;
            this.ReceiveGreenCounts = this.ReceiveRedCounts = 0;
            this.IsChanged = false;
            this.IsReceived = false;
            this.SendReadyMessageQueue = new Queue<I_Message>();
        }

        public void Initialize()
        {
            this.Belief = this.InitBelief;
            this.Opinion = this.InitOpinion;
            this.WeightDic = new Dictionary<int, double>(this.InitWeightDic);
            this.ReceiveGreenCounts = this.ReceiveRedCounts = 0;
            this.IsChanged = false;
            this.IsReceived = false;
            this.ChangedRoundList = new List<int>();
            this.ReceiveRoundList = new List<int>();
            this.SendReadyMessageQueue = new Queue<I_Message>();
        }

        public void SetInitialize(double init_belief, InfoEnum init_op, Dictionary<int, double> init_weight_list)
        {
            this.InitBelief = init_belief;
            this.InitOpinion = init_op;
            this.InitWeightDic = new Dictionary<int, double>(init_weight_list);
        }

        public void SetSensor(bool is_sensor, double sensor_acc)
        {
            this.IsSensor = is_sensor;
            this.SensorAccuracy = sensor_acc;
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

        public void SetInitWeightDic(Dictionary<int, double> init_weight_dic)
        {
            this.InitWeightDic = init_weight_dic;
            this.WeightDic = new Dictionary<int, double>(this.InitWeightDic);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Belief:{this.Belief:f3}");
            Console.WriteLine($"Opinion:{this.Opinion}");
            Console.WriteLine($"Weight:{this.WeightDic.First().Value:f3}");
            foreach (var weight in this.WeightDic)
            {
                Console.WriteLine($"nei_id: {weight.Key,3} weight: {weight.Value:f3}");
            }
            Console.WriteLine($"Receive Green:{this.ReceiveGreenCounts}");
            Console.WriteLine($"Receive Red:{this.ReceiveRedCounts}");
            Console.WriteLine($"Is Changed:{this.IsChanged}");
            Console.WriteLine($"Is Received:{this.IsReceived}");
            Console.WriteLine($"Changed Rounds:{this.ChangedRoundList.Count}");
            Console.WriteLine($"Received Rounds:{this.ReceiveRoundList.Count}");
        }

        public void SetWeight(double weight)
        {
            Dictionary<int, double> weight_dic = new Dictionary<int, double>();

            foreach (var weight_element in this.WeightDic)
            {
                weight_dic.Add(weight_element.Key, weight);
            }
            this.WeightDic = weight_dic;
        }

        public void SetWeightDic(Dictionary<int, double> weight_dic)
        {
            this.WeightDic = weight_dic;
        }
    }
}
