using OSM2018.Abstracts;
using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Networks.NetworkGenerator
{
    class PC_NetworkGenerator : A_NetworkGenerator
    {
        int NodeNum;
        int M;
        double P;
        public override NetworkEnum MyNetworkEnum { get; }
        protected override string GeneratePath { get; }

        public PC_NetworkGenerator(int n, int m, double p)
        {
            this.NodeNum = n;
            this.M = m;
            this.P = p;
            this.MyNetworkEnum = NetworkEnum.PowerLawCluster;
            var path = Properties.Settings.Default.NetworkGeneratorPath + "powerlaw_cluster_graph.py";
            this.GeneratePath = "" + path + " " + this.NodeNum + " " + this.M + " " + this.P;
        }
    }
}
