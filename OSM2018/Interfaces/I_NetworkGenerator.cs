using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Interfaces
{
    interface I_NetworkGenerator
    {
        NetworkEnum MyNetworkEnum { get; }
        I_Network Generate(int network_seed);
    }
}
