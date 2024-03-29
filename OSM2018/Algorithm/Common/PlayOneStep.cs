﻿using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.Common
{
    class PlayOneStep : I_PlayOneStep
    {
        I_SendOpinion SendOpinion { get; }
        I_ReceiveOpinion ReceiveOpinion { get; }


        public PlayOneStep(I_SendOpinion send_op, I_ReceiveOpinion rec_op)
        {
            this.SendOpinion = send_op;
            this.ReceiveOpinion = rec_op;
            this.Initialize();
        }

        public void Run(I_Network network, I_AgentSet agent_set, bool env_send, InfoEnum correct, InfoEnum incorrect)
        {
            this.SendOpinion.Run(network, agent_set, env_send, correct, incorrect);
            var send_message_queue = this.SendOpinion.SendMessageQueue;

            this.ReceiveOpinion.ReceiveMessageQueue = send_message_queue;
            this.ReceiveOpinion.Run(network, agent_set);
        }

        public void Initialize()
        {
            this.SendOpinion.Initialize();
            this.ReceiveOpinion.Initialize();
        }
    }
}
