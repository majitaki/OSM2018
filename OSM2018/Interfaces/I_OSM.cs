using OSM2018.GUIs;
using OSM2018.Interfaces.Algo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_OSM
    {
        I_Network MyNetwork { get; set; }
        I_AgentSet MyAgentSet { get; set; }
        I_Algo MyAlgo { get; set; }

        void Initialize();
        void PlaySteps(int steps, int playstep_seed);
        void RunRounds(int rounds, int round_steps, int runround_seed);
    }
}
