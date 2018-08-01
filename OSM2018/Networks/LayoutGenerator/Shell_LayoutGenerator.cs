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
    class Shell_LayoutGenerator : A_LayoutGenerator
    {
        public override LayoutEnum MyLayoutEnum { get; }
        protected override string GeneratePath { get; }
        protected override I_Network MyNetwork { get; }

        public Shell_LayoutGenerator(I_Network network)
        {
            this.MyNetwork = network;
            this.MyLayoutEnum = LayoutEnum.Shell;
            var path = Properties.Settings.Default.LayoutGeneratorPath + "shell_layout.py";
            this.GeneratePath = path;
        }
    }
}
