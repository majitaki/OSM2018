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
    class ER_NetworkGenerator : A_NetworkGenerator
    {
        int NodeNum;
        double P;
        public override NetworkEnum MyNetworkEnum { get; }
        protected override string GeneratePath { get; }

        public ER_NetworkGenerator(int n, double p)
        {
            this.NodeNum = n;
            this.P = p;
            this.MyNetworkEnum = NetworkEnum.ER;
            var path = Properties.Settings.Default.NetworkGeneratorPath + "erdos_renyi_graph.py";
            this.GeneratePath = path + " " + this.NodeNum + " " + this.P;
        }
    }
}
