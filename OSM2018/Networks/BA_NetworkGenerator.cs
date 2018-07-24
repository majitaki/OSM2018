using OSM2018.Abstracts;
using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Networks {
  class BA_NetworkGenerator : A_NetworkGenerator {
    int NodeNum;
    int M;
    public override NetworkEnum MyNetworkEnum { get; }
    protected override string GeneratePath { get; }

    public BA_NetworkGenerator(int n, int m) {
      this.NodeNum = n;
      this.M = m;
      this.MyNetworkEnum = NetworkEnum.BA;
      var path = Properties.Settings.Default.NetworkGeneratorPath + "barabasi_albert_graph.py";
      this.GeneratePath = "" + path + " " + this.NodeNum + " " + this.M;
    }
  }
}
