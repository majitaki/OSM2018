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
    class Hexagonal_NetworkGenerator : A_NetworkGenerator
    {
        int M;
        int N;
        public override NetworkEnum MyNetworkEnum { get; }
        protected override string GeneratePath { get; }

        public Hexagonal_NetworkGenerator(int m, int n)
        {
            this.M = m;
            this.N = n;
            this.MyNetworkEnum = NetworkEnum.Hexagonal;
            var path = Properties.Settings.Default.NetworkGeneratorPath + "hexagonal_lattice_graph.py";
            this.GeneratePath = path + " " + this.M + " " + this.N;
        }
    }
}
