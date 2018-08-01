using OSM2018.Abstracts;
using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Networks.LayoutGenerator
{
    class FR_LayoutGenerator : A_LayoutGenerator
    {
        public override LayoutEnum MyLayoutEnum { get; }
        protected override string GeneratePath { get; }
        protected override I_Network MyNetwork { get; }

        public FR_LayoutGenerator(I_Network network)
        {
            this.MyNetwork = network;
            this.MyLayoutEnum = LayoutEnum.FruchtermanReingold;
            var path = Properties.Settings.Default.LayoutGeneratorPath + "fruchterman_reingold_layout.py";
            this.GeneratePath = path;
        }
    }
}
