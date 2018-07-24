using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_Layout
    {
        LayoutEnum MyLayoutEnum { get; }
        List<Position> PosList { get; }
    }
}
