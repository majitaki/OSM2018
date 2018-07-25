using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_Node
    {
        int NodeID { get; }
        List<int> NeighborNodeIDList { get; }
        List<int> AttachEdgeIDList { set; get; }

    }
}
