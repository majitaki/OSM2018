using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_OSM
    {
        void Initialize();
        void PlaySteps(int steps, int playstep_seed);
        void RunRounds(int rounds, int round_steps, int runround_seed);
    }
}
