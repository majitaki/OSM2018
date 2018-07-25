using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.AgentSets
{
    class BaseAgentSet : I_AgentSet
    {
        public int AgentSeed { get; }
        public List<I_Agent> AgentList { get; }

        public BaseAgentSet(List<I_Agent> agent_list, int agent_seed)
        {
            this.AgentList = agent_list;
            this.AgentSeed = agent_seed;
        }

        public void SetSensors(SetSensorMode mode, int num)
        {
            if (mode != SetSensorMode.Number) return;

            var ir = RandomPool.Get(SeedEnum.AgentSeed);
            var list = this.AgentList.Select(agent => agent.NodeID).OrderBy(id => ir.Next()).Take(num)
                .ToList();

            this.AgentList.Where(agent => list.Contains(agent.NodeID)).ToList().ForEach(agent => agent.SetSensor(true));
        }

        public void SetSensors(SetSensorMode mode, double rate)
        {

        }
    }
}
