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
    class NewmanWS_NetworkGenerator : A_NetworkGenerator
    {
        int NodeNum;
        int K;
        double RewireP;
        public override NetworkEnum MyNetworkEnum { get; }
        protected override string GeneratePath { get; }

        public NewmanWS_NetworkGenerator(int n, int k, double p)
        {
            this.NodeNum = n;
            this.K = k;
            this.RewireP = p;
            this.MyNetworkEnum = NetworkEnum.NewmanWS;
            var path = Properties.Settings.Default.NetworkGeneratorPath + "newman_watts_strogatz_graph.py";
            this.GeneratePath = path + " " + this.NodeNum + " " + this.K + " " + this.RewireP;
        }
    }
}
