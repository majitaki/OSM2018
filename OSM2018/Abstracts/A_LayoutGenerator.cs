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
    abstract class A_LayoutGenerator : I_LayoutGenerator
    {
        public abstract LayoutEnum MyLayoutEnum { get; }
        protected abstract string GeneratePath { get; }
        protected abstract I_Network MyNetwork { get; }

        public I_Layout Generate()
        {
            var state = 0;
            switch (state)
            {
                case 0:
                    Console.WriteLine("-----");
                    Console.WriteLine("ok Start Layout Generation");
                    var delete_success = ConvertNetwork.DeleteLayoutOutput();
                    if (!delete_success) goto default;

                    var python_success = this.RawGenerate();
                    if (!python_success) goto default;

                    var raw_position_list = ConvertNetwork.GetRawPositionList();
                    if (raw_position_list == null) goto default;
                    var layout = new LayoutFactory().Create(raw_position_list, this.MyNetwork.NodeList, this.MyLayoutEnum);
                    Console.WriteLine("ok Success Layout Generation");
                    return layout;
                default:
                    Console.WriteLine("no Failure Layout Generation");
                    return null;
            }
        }

        bool RawGenerate()
        {
            PythonProxy.GeneratePosition(this.GeneratePath);

            bool exist_flag = false;
            while (!exist_flag)
            {
                exist_flag = File.Exists(Properties.Settings.Default.NetworkOutput + "layout_flag");
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
