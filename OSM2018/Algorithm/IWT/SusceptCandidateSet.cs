using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.IWT
{
    class SusceptCandidateSet : I_CandidateSet
    {
        public int NodeID { get; }
        public List<I_SingleCandidate> SingleCandidateList { get; private set; }
        public int InitSelectCanIndex { get; private set; }
        public int SelectCanIndex { get; set; }

        public SusceptCandidateSet(I_Node node, I_Agent agent, double step_size)
        {
            this.NodeID = node.NodeID;
            this.SingleCandidateList = new List<I_SingleCandidate>();
            int max_index = Convert.ToInt32(0.5 / step_size);

            for (int can_index = 1; can_index <= max_index; can_index++)
            {
                this.SingleCandidateList.Add(new SingleSusceptCandidate(can_index, step_size, agent));
            }

            this.SetInitSelectCanIndex();
            this.SelectCanIndex = this.InitSelectCanIndex;
        }

        void SetInitSelectCanIndex()
        {
            this.InitSelectCanIndex = this.SingleCandidateList.OrderBy(single_can => single_can.CanWeight).First().CanIndex;
        }

        public double GetCanWeight(int index)
        {
            return this.SingleCandidateList.First(sc => sc.CanIndex == index).CanWeight;
        }

        public I_SingleCandidate GetCandidate(int can_index)
        {
            return this.SingleCandidateList.First(can => can.CanIndex == can_index);
        }

        public I_SingleCandidate GetSelectCandidate()
        {
            return this.SingleCandidateList.First(can => can.CanIndex == this.SelectCanIndex);
        }
    }
}
