using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_AgentSet
    {
        int AgentSeed { get; }
        List<I_Agent> AgentList { get; }
        void SetSensors(SetSensorMode mode , int num);
        void SetSensors(SetSensorMode mode , double rate);
    }
}
