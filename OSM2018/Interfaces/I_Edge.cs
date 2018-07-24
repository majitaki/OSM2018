using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_Edge
    {
        int ID { get; }
        int SourceID { get; }
        int TargetID { get; }
    }
}
