using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.AgentSets
{
    class BaseAgentSet : I_AgentSet
    {
        public int AgentSeed { get; }
        public List<I_Agent> AgentList { get; }
        public int SensorNum { get; private set; }
        public double SensorAcc { get; private set; }

        public BaseAgentSet(List<I_Agent> agent_list, int agent_seed)
        {
            this.AgentList = agent_list;
            this.AgentSeed = agent_seed;
        }

        public void SetSensors(int num, double sensor_acc)
        {
            this.SensorNum = num;
            this.SensorAcc = sensor_acc;

            var ir = RandomPool.Get(SeedEnum.AgentSeed);

            var list = this.AgentList.Select(agent => agent.NodeID).OrderBy(id => ir.Next()).Take(num)
                .ToList();
            this.AgentList.Where(agent => list.Contains(agent.NodeID)).ToList().ForEach(agent => agent.SetSensor(true, sensor_acc));
        }


        public void SetInitWeightList(List<double> init_weight_list)
        {
            if (this.AgentList.Count != init_weight_list.Count) return;

            foreach (var agent in this.AgentList)
            {
                agent.SetInitWeight(init_weight_list[agent.NodeID]);
            }

        }

        public void SetInitWeightDicList(List<Dictionary<int, double>> init_weight_dictionary_list)
        {
            if (this.AgentList.Count != init_weight_dictionary_list.Count) return;

            foreach (var agent in this.AgentList)
            {
                agent.SetInitWeightDic(init_weight_dictionary_list[agent.NodeID]);
            }
        }


        public void SetWeightList(List<double> weight_list)
        {
            if (this.AgentList.Count != weight_list.Count) return;

            foreach (var agent in this.AgentList)
            {
                agent.SetWeight(weight_list[agent.NodeID]);
            }
        }

        public void InitBelief()
        {
            foreach (var agent in this.AgentList)
            {
                agent.Belief = agent.InitBelief;
                agent.IsReceived = false;
            }
        }

        public void InitOpinion()
        {
            foreach (var agent in this.AgentList)
            {
                agent.Opinion = agent.InitOpinion;
                agent.IsChanged = false;
            }
        }

        public void InitWeight()
        {
            foreach (var agent in this.AgentList)
            {
                agent.WeightDic = new Dictionary<int, double>(agent.InitWeightDic);
            }
        }

        public void InitCounts()
        {
            foreach (var agent in this.AgentList)
            {
                agent.ReceiveGreenCounts = agent.ReceiveRedCounts = 0;
                agent.SendReadyMessageQueue = new Queue<I_Message>();
            }
        }

        public void InitRoundInfo()
        {
            foreach (var agent in this.AgentList)
            {
                agent.ChangedRoundList = new List<int>();
                agent.ReceiveRoundList = new List<int>();
            }
        }

        public Dictionary<string, string> GetInfoString()
        {
            var dic = new Dictionary<string, string>();
            dic.Add("agent_seed", this.AgentSeed.ToString());
            dic.Add("sensor_num", this.SensorNum.ToString());
            dic.Add("sensor_acc", this.SensorAcc.ToString());

            return dic;
        }

        public void SetWeightDicList(List<Dictionary<int, double>> weight_dic_list)
        {
            if (this.AgentList.Count != weight_dic_list.Count) return;

            foreach (var agent in this.AgentList)
            {
                agent.SetWeightDic(weight_dic_list[agent.NodeID]);
            }
        }
    }
}
