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
        PowerLawCluster,
        RandomKernel,
        RandomLobster,
        Grid2D,
        Hexagonal,
        Triangular,
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
        Square,
        Null
    }

    enum AlgoEnum
    {
        OriginalAAT,
        HCII_AATD,
        AATD,
        AATD_NoTargetH,
        IWT,
        Custom,
        Fool
    }

    enum InfoEnum
    {
        Undeter,
        Green,
        Red
    }

    enum SeedEnum
    {
        NetworkSeed,
        LayoutSeed,
        AgentSeed,
        PlayStepSeed,
        RoundSeed,
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

    enum ExpEnum
    {
        //Exp_NoExperiment,
        Exp_LowRound_ChangeNetwork,

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
