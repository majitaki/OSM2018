using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces.Algo
{
    interface I_SendOpinion
    {
        List<I_Message> SendMessageList { get; }
        void Run(I_Network network, I_AgentSet agent_set, bool env_send);

    }
}
