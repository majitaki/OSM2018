using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo.IWT;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.IWT.Indicator
{
    class SurpriseIndicator : I_SurpriseIndicator
    {
        public int SourceNodeID { get; }
        public int TargetNodeID { get; }
        public double InitValue { get; }
        public double CurValue { get; private set; }
        public double PreValue { get; private set; }
        public List<double> SelfInfoList { get; private set; }

        public SurpriseIndicator(int s_id, int t_id, double init_value)
        {
            this.SourceNodeID = s_id;
            this.TargetNodeID = t_id;
            this.InitValue = init_value;
            this.CurValue = this.PreValue = this.InitValue;
            this.SelfInfoList = new List<double>();
        }

        public void InputOpinion(InfoEnum op, double belief)
        {
            double p;
            if (op == InfoEnum.Green)
            {
                p = belief;
            }
            else
            {
                p = 1 - belief;
            }

            double self_info = -1 * Math.Log(p, 2.0);
            this.SelfInfoList.Add(self_info);
            this.CurValue = this.SelfInfoList.Average();
            if (this.CurValue == 0) this.CurValue = this.InitValue;
            if (Double.IsNaN(this.CurValue)) this.CurValue = this.InitValue;
        }



        public void Initialize()
        {
            this.CurValue = this.PreValue = this.InitValue;
            this.SelfInfoList = new List<double>();
        }

        public void UpdateForNextRound()
        {
            this.PreValue = this.CurValue;
            //this.CurValue = this.InitValue;
            this.SelfInfoList = new List<double>();
        }

        public void InitializeForPlaySteps()
        {
            this.CurValue = this.PreValue;
            this.SelfInfoList = new List<double>();
        }
    }
}
