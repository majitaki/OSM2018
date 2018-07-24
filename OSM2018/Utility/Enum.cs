using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Utility
{

    enum GUIEnum
    {
        GraphSetting,
        AgentNetworkSetting,
        LearningSetting,
        AnimationSetting,
        ExperimentSetting
    }

    enum NetworkEnum
    {
        WS,
        NewmanWS,
        ConnectedWS,
        BA,
        FastGnp,
        GnpRandom,
        DenseGnm,
        Gnm,
        ER,
        Binomial,
        RandomRegular,
        PC,
        RandomKernel,
        RandomLobster,
        Custom,
        Void
    }

    enum LayoutEnum
    {
        Circular,
        FruchtermanReingold,
        KamadaKawai,
        Random,
        Shell,
        Spectral,
        Spring,
        Null
    }

    enum AlgoEnum
    {
        AAT,
        AATinit,
        AATtu,
        AATrm,
        AATque,
        AATit,
        AATir,
        AATiq,
        AATitr,
        AATitq,
        AATirq,
        AATitrq,
        AATD,
        AATwithoutH,
        Custom,
        Fool
    }

    enum InfoEnum
    {
        Undeter,
        Correct,
        Incorrect
    }

    enum SeedEnum
    {
        AgentSeed,
        AnimationSeed,
        LearningSeed
    }

    enum TextEnum
    {
        Normal,
        OK,
        NO,
    }

    struct Position
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }

    }
}
