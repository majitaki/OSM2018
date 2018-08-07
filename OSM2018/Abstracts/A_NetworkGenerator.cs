using OSM2018.Factories;
using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Abstracts
{
    abstract class A_NetworkGenerator : I_NetworkGenerator
    {
        public abstract NetworkEnum MyNetworkEnum { get; }
        protected abstract string GeneratePath { get; }

        public I_Network Generate(int network_seed, bool seed_enable)
        {
            RandomPool.Declare(SeedEnum.LayoutSeed, network_seed);
            var state = 0;
            switch (state)
            {
                case 0:
                    Console.WriteLine("-----");
                    Console.WriteLine("ok Start Network Generation");
                    var delete_success = ConvertNetwork.DeleteNetworkOutput();
                    if (!delete_success) goto default;

                    var python_success = this.RawGenerate(network_seed, seed_enable);
                    if (!python_success) goto default;

                    var raw_edge_list = ConvertNetwork.GetRawEdgeList();
                    var node_num = ConvertNetwork.GetRawNodeNum();
                    var network_enum = this.MyNetworkEnum;
                    if (raw_edge_list == null || node_num == 0 || network_enum == NetworkEnum.Void) goto default;

                    Console.WriteLine("ok Load Raw Network");
                    Console.WriteLine("ok Node: " + node_num);
                    Console.WriteLine("ok Edge: " + raw_edge_list.Count);
                    Console.WriteLine("ok NetworkEnum: " + network_enum.ToString());
                    Console.WriteLine("ok Network Seed: " + network_seed);
                    var network = new NetworkFactory().Generate(node_num, raw_edge_list, network_enum, network_seed);
                    if (network == null) goto default;

                    Console.WriteLine("ok Success Network Generation");
                    return network;

                default:
                    Console.WriteLine("no Failure Network Generation");
                    return null;
            }
        }
        bool RawGenerate(int network_seed, bool seed_enable)
        {
            if (seed_enable)
            {
                PythonProxy.GenerateGraph(this.GeneratePath + " " + network_seed);
            }
            else
            {
                PythonProxy.GenerateGraph(this.GeneratePath);
            }
            bool exist_flag = false;
            while (!exist_flag)
            {
                exist_flag = File.Exists(Properties.Settings.Default.NetworkOutput + "flag");
                System.Threading.Thread.Sleep(100);
                if (PythonProxy.ErrorFlag)
                {
                    System.Threading.Thread.Sleep(100);
                    return false;
                }
            }
            return true;
        }
    }
}
