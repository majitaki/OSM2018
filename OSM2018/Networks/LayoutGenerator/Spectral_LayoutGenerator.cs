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
    class Spectral_LayoutGenerator : A_LayoutGenerator
    {
        public override LayoutEnum MyLayoutEnum { get; }
        protected override string GeneratePath { get; }
        protected override I_Network MyNetwork { get; }

        public Spectral_LayoutGenerator(I_Network network)
        {
            this.MyNetwork = network;
            this.MyLayoutEnum = LayoutEnum.Spectral;
            var path = Properties.Settings.Default.LayoutGeneratorPath + "spectral_layout.py";
            this.GeneratePath = path;
        }
    }
}
