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
        public int ID { get; }
        public List<int> NeighborList { get; }

        public Node(int id)
        {
            this.ID = id;
        }
    }
}
