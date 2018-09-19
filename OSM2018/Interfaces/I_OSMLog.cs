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
        void StartRecordRounds(Dictionary<string, string> network_info, Dictionary<string, string> agent_info, Dictionary<string, string> algo_info, Dictionary<string, string> round_info, string exp_name);
        void RecordOneRound(I_Network network, I_AgentSet agent_set, int current_round);
        void StopRecordRounds();
        //step
        void StartRecordSteps();
        void RecordOneStep();
        void StopRecordSteps();
    }
}
