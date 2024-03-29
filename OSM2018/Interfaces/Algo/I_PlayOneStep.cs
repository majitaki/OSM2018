﻿using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces.Algo
{
    interface I_PlayOneStep
    {
        void Initialize();
        void Run(I_Network network, I_AgentSet agent_set, bool env_send, InfoEnum correct, InfoEnum incorrect);
    }
}
