using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_Message
    {
        int SourceNodeID { get; }
        int TargetNodeID { get; }
        InfoEnum MessageOpinion { get; }
    }
}
