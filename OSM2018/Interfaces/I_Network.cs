using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_Network
    {
        NetworkEnum MyNetworkEnum { get; }
        int Seed { get; }
        List<I_Node> NodeList { get; }
        List<I_Edge> EdgeList { get; }
    }
}
