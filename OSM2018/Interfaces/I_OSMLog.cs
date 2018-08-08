using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_OSMLog
    {
        bool IsRecordingRounds { get; }
        bool IsRecordingSteps { get; }

        //round
        void StartRecordRounds(string cnd_name = "normal");
        void RecordOneRound(I_Network network, I_AgentSet agent_set, int current_round);
        void StopRecordRounds();
        //step
        void StartRecordSteps();
        void RecordOneStep();
        void StopRecordSteps();
    }
}
