using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Networks
{
    class BaseNetwork : I_Network
    {
        public NetworkEnum MyNetworkEnum { get; }
        public int NetworkSeed { get; }
        public List<I_Node> NodeList { get; }
        public List<I_Edge> EdgeList { get; }
        public I_Layout MyLayout { set; get; }

        public BaseNetwork(List<I_Node> node_list, List<I_Edge> edge_list, NetworkEnum network_enum, int seed)
        {
            this.NodeList = node_list;
            this.EdgeList = edge_list;
            this.MyNetworkEnum = network_enum;
            this.NetworkSeed = seed;
        }

        public void SetLayout(I_Layout layout)
        {
            this.MyLayout = layout;
        }
    }
}
