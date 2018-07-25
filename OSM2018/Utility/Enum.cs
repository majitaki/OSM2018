using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Utility
{

    enum GUIEnum
    {
        AgentGUI,
        AnimationGUI,
        ExperimentGUI,
        LearningGUI,
        MainFormGUI,
        NetworkGUI,
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
        Orange,
        Blue
    }

    enum SeedEnum
    {
        NetworkSeed,
        AgentSeed,
        PlayStepSeed,
        RunRoundSeed,
        ExperimentSeed
    }


    enum AgentInitMode
    {
        Random,
        RandomWeakPulledByOpinion,
        RandomStrongPulledByOpinion,
        Normal,
        NormalWeakPulledByOpinion,
        NormalStrongPulledByOpinion
    }

    enum SetSensorMode
    {
        Number,
        Rate
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
