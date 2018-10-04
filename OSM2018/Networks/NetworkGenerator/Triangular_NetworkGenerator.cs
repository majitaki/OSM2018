using OSM2018.Abstracts;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Networks.NetworkGenerator
{
    class Triangular_NetworkGenerator: A_NetworkGenerator
    {
        int M;
        int N;
        public override NetworkEnum MyNetworkEnum { get; }
        protected override string GeneratePath { get; }

        public Triangular_NetworkGenerator(int m, int n)
        {
            this.M = m;
            this.N = n;
            this.MyNetworkEnum = NetworkEnum.Triangular;
            var path = Properties.Settings.Default.NetworkGeneratorPath + "triangular_graph.py";
            this.GeneratePath = path + " " + this.M + " " + this.N;
        }
    }
}
