using OSM2018.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Networks
{
    class Edge : I_Edge
    {
        public int EdgeID { get; }
        public int SourceNodeID { get; }
        public int TargetNodeID { get; }

        public Edge(int id, int source_id, int target_id)
        {
            this.EdgeID = id;
            this.SourceNodeID = source_id;
            this.TargetNodeID = target_id;
        }
    }
}
