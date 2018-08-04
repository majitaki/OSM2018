using OSM2018.Interfaces.Algo.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.AAT.SlctWeiStrategies
{
    class SelectingWeiStrategies : I_SelectingWeiStrategies
    {
        double TargetAwaRate;

        public SelectingWeiStrategies(double target_h)
        {
            this.TargetAwaRate = target_h;
        }

        public void Run(List<I_CandidateSet> canset_list)
        {
            foreach (var canset in canset_list)
            {
                //small -> big
                var SortCanset = canset.SingleCandidateList.OrderBy(can => can.CanWeight).ToList();
                var l = SortCanset.IndexOf(canset.GetSelectCandidate());
                var h = SortCanset[l].AwaRate;

                if ((l + 1 < SortCanset.Count) && h < this.TargetAwaRate)
                {
                    l = l + 1;
                }
                else if (l > 1)
                {
                    var h_pre = SortCanset[l - 1].AwaRate;
                    if (h_pre > this.TargetAwaRate)
                    {
                        l = l - 1;
                    }
                }

                var true_index = SortCanset[l].CanIndex;
                canset.SelectCanIndex = true_index;
            }
        }
    }
}
