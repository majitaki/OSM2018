using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Networks
{
    class BaseLayout : I_Layout
    {
        public LayoutEnum MyLayoutEnum { get; }
        public List<Position> PosList { get; }

        public BaseLayout(List<Position> pos_list, LayoutEnum layout_enum)
        {
            this.MyLayoutEnum = layout_enum;
            this.PosList = pos_list;
        }
    }
}
