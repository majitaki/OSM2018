using OSM2018.Interfaces;
using OSM2018.Networks;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Factories
{
    class NetworkFactory
    {
        public I_Network Generate(int node_num, List<string[]> raw_edge_list, NetworkEnum network_enum, int network_seed)
        {
            var node_list = new List<I_Node>();
            var edge_list = new List<I_Edge>();

            if (node_num == 0 || raw_edge_list == null) return null;

            //node
            for (int i = 0; i < node_num; i++)
            {
                node_list.Add(new Node(i));
            }

            //edge
            for (int i = 0; i < raw_edge_list.Count; i++)
            {
                var edge = new Edge(i, int.Parse(raw_edge_list[i][1]), int.Parse(raw_edge_list[i][2]));
                node_list[edge.SourceNodeID].AttachEdgeIDList.Add(edge.EdgeID);
                node_list[edge.SourceNodeID].NeighborNodeIDList.Add(edge.TargetNodeID);
                node_list[edge.TargetNodeID].AttachEdgeIDList.Add(edge.EdgeID);
                node_list[edge.TargetNodeID].NeighborNodeIDList.Add(edge.SourceNodeID);
                edge_list.Add(edge);
            }

            return new BaseNetwork(node_list, edge_list, network_enum, network_seed);
        }
    }
}
