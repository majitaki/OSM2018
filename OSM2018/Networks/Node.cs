using OSM2018.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Networks
{
    class Node : I_Node
    {
        public int NodeID { get; }
        public List<int> NeighborNodeIDList { set; get; }
        public List<int> AttachEdgeIDList { set; get; }

        public Node(int id)
        {
            this.NodeID = id;
            this.NeighborNodeIDList = new List<int>();
            this.AttachEdgeIDList = new List<int>();
        }
    }
}
