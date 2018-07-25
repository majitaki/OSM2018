using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_Edge
    {
        int EdgeID { get; }
        int SourceNodeID { get; }
        int TargetNodeID { get; }
    }
}
