using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.Common
{
    class Message : I_Message
    {
        public int SourceNodeID { get; }
        public int TargetNodeID { get; }
        public InfoEnum MessageOpinion { get; }

        public Message(int s_id, int t_id, InfoEnum m_op)
        {
            this.SourceNodeID = s_id;
            this.TargetNodeID = t_id;
            this.MessageOpinion = m_op;
        }
    }
}
