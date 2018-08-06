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

        public void PrintInfo()
        {
            Console.WriteLine($"Network Enum: {this.MyNetworkEnum}");
            Console.WriteLine($"Network Seed: {this.NetworkSeed}");
            Console.WriteLine($"Total Nodes: {this.NodeList.Count}");
            Console.WriteLine($"Total Edges: {this.EdgeList.Count}");
            Console.WriteLine($"Layout Enum: {this.MyLayout.MyLayoutEnum}");
        }

        public void PrintInfo(int node_id)
        {
            if (!this.NodeList.Exists(node => node.NodeID == node_id))
            {
                Console.WriteLine($"Not Exist Node of {node_id}");
                return;
            }

            Console.WriteLine($"Node ID: {node_id}");
            Console.WriteLine($"Total Neighbors: {this.NodeList[node_id].NeighborNodeIDList.Count}");
        }
    }
}
