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

        public BaseAgentSet(List<I_Agent> agent_list, int agent_seed)
        {
            this.AgentList = agent_list;
            this.AgentSeed = agent_seed;
        }

        public void SetSensors(int num, double sensor_acc)
        {
            var ir = RandomPool.Get(SeedEnum.AgentSeed);

            var list = this.AgentList.Select(agent => agent.NodeID).OrderBy(id => ir.Next()).Take(num)
                .ToList();
            this.AgentList.Where(agent => list.Contains(agent.NodeID)).ToList().ForEach(agent => agent.SetSensor(true, sensor_acc));
        }


        public void SetInitWeights(List<double> init_weight_list)
        {
            if (this.AgentList.Count != init_weight_list.Count) return;

            foreach (var agent in this.AgentList)
            {
                agent.SetInitWeight(init_weight_list[agent.NodeID]);
            }

        }

        public void SetInitWeights(List<Dictionary<int, double>> init_weight_dictionary_list)
        {
            if (this.AgentList.Count != init_weight_dictionary_list.Count) return;

            foreach (var agent in this.AgentList)
            {
                agent.SetInitWeightList(init_weight_dictionary_list[agent.NodeID]);
            }
        }

        public void InitBelief()
        {
            foreach (var agent in this.AgentList)
            {
                agent.Belief = agent.InitBelief;
            }
        }

        public void InitOpinion()
        {
            foreach (var agent in this.AgentList)
            {
                agent.Opinion = agent.InitOpinion;
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

    }
}
