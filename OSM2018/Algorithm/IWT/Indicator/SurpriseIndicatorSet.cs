using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo.AAT;
using OSM2018.Interfaces.Algo.IWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.IWT.Indicator
{
    class SurpriseIndicatorSet : I_SurpriseIndicatorSet
    {
        public List<I_SurpriseIndicator> Value { get; }
        public List<Dictionary<int, double>> WeightDic { get; private set; }

        public SurpriseIndicatorSet(I_Network network, I_AgentSet agent_set)
        {
            this.Value = new List<I_SurpriseIndicator>();
            double init_value = 0.01;

            foreach (var node in network.NodeList)
            {
                foreach (var nei_id in node.NeighborNodeIDList)
                {
                    this.Value.Add(new SurpriseIndicator(node.NodeID, nei_id, init_value));
                }
            }
        }

        public void Initialize()
        {
            foreach (var indi in this.Value)
            {
                indi.Initialize();
            }
        }

        public void InitializeForPlaySteps()
        {
            foreach (var indi in this.Value)
            {
                indi.InitializeForPlaySteps();
            }
        }

        public void UpdateForNextRound()
        {
            foreach (var indi in this.Value)
            {
                indi.UpdateForNextRound();
            }
        }

        public void SetWeightDicList(List<I_CandidateSet> canset_list, I_Network network)
        {
            var wei_dic_list = new List<Dictionary<int, double>>();

            foreach (var node in network.NodeList)
            {
                var canset = canset_list.First(_canset => _canset.NodeID == node.NodeID);
                var can_wei = canset.GetCanWeight(canset.SelectCanIndex);
                var wei_dic = new Dictionary<int, double>();
                foreach (var nei_id in node.NeighborNodeIDList)
                {
                    var nei = network.NodeList.First(nei_node => nei_node.NodeID == nei_id);
                    var sur_indi_list = this.Value.Where(sur => sur.SourceNodeID == node.NodeID).ToList();
                    //var my_sur_indi = this.Value.First(sur => sur.SourceNodeID == node.NodeID);
                    var my_sur_indi = sur_indi_list.First(sur => sur.TargetNodeID == nei_id);
                    var max_sur_indi = sur_indi_list.OrderByDescending(sur => sur.CurValue).First();
                    var wei_value = (my_sur_indi.CurValue / max_sur_indi.CurValue) * can_wei + 0.5;

                    wei_dic.Add(nei_id, wei_value);
                }
                wei_dic_list.Add(wei_dic);
            }

            this.WeightDic = wei_dic_list;
        }

    }
}
