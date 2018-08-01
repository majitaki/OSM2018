using OSM2018.Interfaces;
using OSM2018.Networks;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Factories
{
    class LayoutFactory
    {
        public I_Layout Generate(List<string[]> raw_pos_list, List<I_Node> node_list, LayoutEnum layout_enum)
        {
            var pos_list = new List<Position>();

            foreach (var node in node_list)
            {
                var id = node.NodeID;
                var posX = 0.0;
                var posY = 0.0;

                if (id >= raw_pos_list.Count)
                {
                    posX = 0;
                    posY = 0;
                    pos_list.Add(new Position());
                }
                else
                {
                    posX = double.Parse(raw_pos_list[id][1]);
                    posY = double.Parse(raw_pos_list[id][2]);
                    pos_list.Add(new Position(posX, posY));
                }
            }
            return new BaseLayout(pos_list, layout_enum);
        }
    }
}
