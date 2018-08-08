using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.AAT.SlctWeiStrategies
{
    class AATD_SelectingWeiStrategies : I_SelectingWeiStrategies
    {
        double TargetAwaRate;
        int QueueRange;
        List<Queue<bool>> ChangedQueueList;

        public AATD_SelectingWeiStrategies(double target_h, int q_range, int node_num)
        {
            this.TargetAwaRate = target_h;
            this.QueueRange = q_range;
            this.ChangedQueueList = new List<Queue<bool>>();

            for (int i = 0; i < node_num; i++)
            {
                this.ChangedQueueList.Add(new Queue<bool>());
            }
        }


        public void Run(List<I_CandidateSet> canset_list, I_AgentSet agent_set, int current_round)
        {
            int node_id = 0;
            foreach (var canset in canset_list)
            {
                //queue
                var agent_queue = this.ChangedQueueList[node_id];

                if (agent_queue.Count >= this.QueueRange)
                {
                    agent_queue.Dequeue();
                    //agent_queue = new Queue<bool>();
                }
                agent_queue.Enqueue(agent_set.AgentList[node_id].IsChanged);

                var changed_count = agent_queue.Count(q => q == true);
                var unchanged_count = agent_queue.Count(q => q == false);


                //small -> big
                var SortCanset = canset.SingleCandidateList.OrderBy(can => can.CanWeight).ToList();
                var l = SortCanset.IndexOf(canset.GetSelectCandidate());
                var h = SortCanset[l].AwaRate;


                if (l + 1 < SortCanset.Count)
                {
                    if (h < this.TargetAwaRate)
                    {
                        if (unchanged_count >= changed_count)
                        {
                            l = l + 1;
                        }
                    }
                }
                else if (l > 1)
                {
                    var h_pre = SortCanset[l - 1].AwaRate;
                    if (h_pre > this.TargetAwaRate)
                    {
                        if (changed_count > unchanged_count)
                        {
                            l = l - 1;
                        }
                    }
                }

                //if (l + 1 < SortCanset.Count)
                //{
                //    if (h < this.TargetAwaRate || unchanged_count >= changed_count)
                //    {

                //        l = l + 1;
                //    }
                //}
                //else if (l > 1)
                //{
                //    var h_pre = SortCanset[l - 1].AwaRate;
                //    if (h_pre > this.TargetAwaRate || changed_count > unchanged_count)
                //    {
                //        l = l - 1;
                //    }
                //}

                var true_index = SortCanset[l].CanIndex;
                canset.SelectCanIndex = true_index;

                node_id++;
            }
        }
    }
}
