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
        public int ID { get; }
        public int SourceID { get; }
        public int TargetID { get; }

        public Edge(int id, int source_id, int target_id)
        {
            this.ID = id;
            this.SourceID = source_id;
            this.TargetID = target_id;
        }
    }
}
