using OSM2018.Abstracts;
using OSM2018.Factories;
using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Networks.LayoutGenerator
{
    class Square_LayoutGenerator : A_LayoutGenerator
    {
        public override LayoutEnum MyLayoutEnum { get; }
        protected override string GeneratePath { get; }
        protected override I_Network MyNetwork { get; }

        public Square_LayoutGenerator(I_Network network)
        {
            this.MyNetwork = network;
            this.MyLayoutEnum = LayoutEnum.Square;
            var path = Properties.Settings.Default.LayoutGeneratorPath + "circular_layout.py";
            this.GeneratePath = path;
        }

        new public I_Layout Generate()
        {
            var state = 0;
            switch (state)
            {
                case 0:
                    Console.WriteLine("-----");
                    Console.WriteLine("ok Start Layout Generation");
                    var delete_success = ConvertNetwork.DeleteLayoutOutput();
                    if (!delete_success) goto default;

                    var layout = this.LayoutGenerate(this.MyNetwork.NodeList, this.MyLayoutEnum);
                    Console.WriteLine("ok Success Layout Generation");
                    return layout;
                default:
                    Console.WriteLine("no Failure Layout Generation");
                    return null;
            }
        }

        I_Layout LayoutGenerate(List<I_Node> node_list, LayoutEnum layout_enum)
        {
            var pos_list = new List<Position>();

            int width_nodes = (int)Math.Round(Math.Sqrt(node_list.Count));

            var wide_count = 0;
            var height_count = 0;
            foreach (var node in node_list)
            {
                if (wide_count < width_nodes)
                {
                    wide_count++;
                }
                else
                {
                    wide_count = 1;
                    height_count++;
                }
                pos_list.Add(new Position(wide_count, height_count));
            }

            return new BaseLayout(pos_list, layout_enum);
        }

    }
}
