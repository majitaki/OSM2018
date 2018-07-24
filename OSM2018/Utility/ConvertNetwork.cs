using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Utility
{
    static class ConvertNetwork
    {
        public static List<string[]> GetRawEdgeList()
        {
            string edge_path = Properties.Settings.Default.NetworkOutput + "edge.csv";
            var raw_edge_list = new List<string[]>();

            for (int count = 0; count < 5; count++)
            {
                try
                {
                    using (var sr = new StreamReader(edge_path, System.Text.Encoding.GetEncoding("utf-8")))
                    {
                        sr.ReadLine().Split(',');
                        while (sr.EndOfStream == false)
                        {
                            raw_edge_list.Add(sr.ReadLine().Split(','));
                        }
                        Console.WriteLine("ok Success Get RawEdgeList");
                        return raw_edge_list;
                    }
                }
                catch
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
            Console.WriteLine("no Failure Get RawEdgeList");
            return null;
        }

        public static int GetRawNodeNum()
        {
            string node_filePath = Properties.Settings.Default.NetworkOutput + "node.csv";
            var node_end = new string[2];

            for (int count = 0; count <= 5; count++)
            {
                try
                {
                    using (var sr = new StreamReader(node_filePath, System.Text.Encoding.GetEncoding("utf-8")))
                    {
                        while (sr.EndOfStream == false)
                        {
                            node_end = sr.ReadLine().Split(',');
                        }
                        Console.WriteLine("ok Success Get RawNodeNum");
                        return int.Parse(node_end[1]) + 1;
                    }
                }
                catch
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
            Console.WriteLine("no Failure Get RawNodeNum");
            return 0;
        }

        public static List<string[]> GetRawPositionList()
        {
            string position_filePath = Properties.Settings.Default.NetworkOutput + "position.csv";

            var raw_position_list = new List<string[]>();

            for (int count = 0; count <= 5; count++)
            {
                try
                {
                    using (var sr = new StreamReader(position_filePath, System.Text.Encoding.GetEncoding("utf-8")))
                    {
                        sr.ReadLine().Split(',');
                        while (sr.EndOfStream == false)
                        {
                            raw_position_list.Add(sr.ReadLine().Split(','));
                        }
                        Console.WriteLine("ok Success Get RawPositionList");
                        return raw_position_list;
                    }
                }
                catch
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
            Console.WriteLine("no Failure Get RawPositionList");
            return null;
        }


        public static bool DeleteNetworkOutput()
        {
            var path = Properties.Settings.Default.NetworkOutput;
            string[] filePaths = Directory.GetFiles(path);

            try
            {
                foreach (string filePath in filePaths)
                {
                    File.SetAttributes(filePath, FileAttributes.Normal);
                    File.Delete(filePath);
                }
                Console.WriteLine("ok Delete Output Network");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("no Failure Delete Output Network");
                return false;
            }
        }

        public static bool DeleteLayoutOutput()
        {
            var path = Properties.Settings.Default.NetworkOutput;
            string[] filePaths = Directory.GetFiles(path);

            try
            {
                foreach (string filePath in filePaths)
                {
                    if (filePath.Contains("position.csv") || filePath.Contains("layout_flag"))
                    {
                        File.SetAttributes(filePath, FileAttributes.Normal);
                        File.Delete(filePath);
                    }
                }
                Console.WriteLine("ok Delete Output Layout");
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("no Failure Delete Output Layout");
                return false;
            }
        }

    }
}
