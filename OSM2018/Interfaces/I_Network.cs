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
        int NetworkSeed { get; }
        List<I_Node> NodeList { get; }
        List<I_Edge> EdgeList { get; }
        I_Layout MyLayout { get; }
        void SetLayout(I_Layout layout);
        void PrintInfo();
        void PrintInfo(int node_id);
    }
}
