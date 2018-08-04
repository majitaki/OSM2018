﻿using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces.Algo
{
    interface I_Algo
    {
        AlgoEnum MyAlgoEnum { get; }
        void Initialize(I_Network network, I_AgentSet agent_set);
        void RunOneRound(I_Network network, I_AgentSet agent_set, int current_round, int total_rounds, int round_steps);
        void PlayOneStep(I_Network network, I_AgentSet agent_set, InfoEnum correct, InfoEnum incorrect);
    }
}
