﻿using OSM2018.Algorithm.AAT;
using OSM2018.Algorithm.AAT.EstAwaRates;
using OSM2018.Algorithm.AAT.GeneCanWeights;
using OSM2018.Algorithm.AAT.SlctWeiStrategies;
using OSM2018.Algorithm.Common;
using OSM2018.Factories.AgentSetFactories;
using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Networks.LayoutGenerator;
using OSM2018.Networks.NetworkGenerator;
using OSM2018.OSM;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Experiments
{
    class Exp_LowRound_ChangeNetwork : I_Experiment
    {
        string ExpName;
        string DataName;
        string BasePath;
        string OutputFolderPath;
        string OutputRoundFilePath;

        public Exp_LowRound_ChangeNetwork()
        {
            this.ExpName = "AATD_LowRound_ChangeNetwork";
            var dt = DateTime.Now;
            this.DataName = dt.ToString("yyyy-MM-dd-HH-mm-ss");
            this.BasePath = Environment.CurrentDirectory;
            //this.OutputFolderPath = this.BasePath + "\\" + OutputLog.BaseLogFolderName + "\\" + this.ExpName + "\\" + this.DataName;
            this.OutputFolderPath = this.BasePath + "\\" + OutputLog.BaseLogFolderName + "\\" + this.ExpName + "\\" + this.DataName + "_" + this.PrintObject();
            OutputLog.SafeCreateDirectory(this.OutputFolderPath);
        }

        public string PrintObject()
        {
            string obj_str = "rate_14-19";
            return obj_str;
        }

        void MakeConditionFile(int round_seed, int total_rounds, int round_steps, I_OSM osm)
        {
            var round_dic = new Dictionary<string, string>();
            round_dic.Add("round_seed", round_seed.ToString());
            round_dic.Add("total_round", total_rounds.ToString());
            round_dic.Add("round_steps", round_steps.ToString());

            var condition_string = "";
            foreach (var dic in osm.MyNetwork.GetInfoString())
            {
                condition_string += dic.Key.ToString() + "." + dic.Value.ToString() + "_";
            }

            foreach (var dic in osm.MyAgentSet.GetInfoString())
            {
                condition_string += dic.Key.ToString() + "." + dic.Value.ToString() + "_";
            }

            foreach (var dic in osm.MyAlgo.GetInfoString())
            {
                condition_string += dic.Key.ToString() + "." + dic.Value.ToString() + "_";
            }

            foreach (var dic in round_dic)
            {
                condition_string += dic.Key.ToString() + "." + dic.Value.ToString() + "_";
            }
            var di = new DirectoryInfo(this.OutputFolderPath);
            var condition_path = OutputLog.SafeCreateCSV(di, condition_string);
            OutputLog.OutputLogCSV(new DataTable(), condition_path);
        }
        void MakeFile(NetworkEnum n_enum, int node_num, int n_seed, AlgoEnum a_enum)
        {
            var di = new DirectoryInfo(this.OutputFolderPath);
            string condition = "_nenum." + n_enum.ToString() + "_node." + node_num.ToString() + "_aenum." + a_enum.ToString();
            var condi_folder = di + "\\" + condition;
            OutputLog.SafeCreateDirectory(condi_folder);
            this.OutputRoundFilePath = OutputLog.SafeCreateCSV(new DirectoryInfo(condi_folder), "RoundOpinion" + condition + "_nseed." + n_seed.ToString());
        }


        public void Run()
        {
            //network
            int network_start_seed = 14;
            int network_finish_seed = 19;
            int total_rounds = 300;
            int round_steps = 1500;
            int round_seed = 0;
            List<int> node_num_list = new List<int> { 600, 700, 800, 900, 1000 };
            bool fix_sensor_num = false;
            double sensor_rate = 0.1;
            int sensor_num = 10;
            double rewire_p = 0.01;
            int degree = 6;
            int attach_edge_num = 2;
            int rnd_edge_num = 1;
            double triangle_p = 0.01;
            double edge_creation_p = 0.01;
            //int grid_m = 20;
            //int grid_n = 20;
            bool seed_enable = true;
            //List<NetworkEnum> network_enum_list = new List<NetworkEnum> { NetworkEnum.WS, NetworkEnum.BA, NetworkEnum.ER, NetworkEnum.Grid2D, NetworkEnum.Hexagonal, NetworkEnum.Triangular };
            List<NetworkEnum> network_enum_list = new List<NetworkEnum> { NetworkEnum.Grid2D, NetworkEnum.Hexagonal, NetworkEnum.Triangular };
            I_NetworkGenerator network_generator = null;

            //agent
            InfoEnum init_op = InfoEnum.Undeter;
            //int agent_seed = ;
            double g_sigma = 0.9;
            double r_sigma = 0.1;
            double sensor_acc = 0.55;
            double op_intro_rate = 0.1;
            int op_intro_duration = 1;
            var t_awa_rate = 0.9;

            //algo
            List<AlgoEnum> algo_enum_list = new List<AlgoEnum> { AlgoEnum.OriginalAAT, AlgoEnum.AATD_NoTargetH };
            //List<AlgoEnum> algo_enum_list = new List<AlgoEnum> { AlgoEnum.AATD_NoTargetH, AlgoEnum.AATD };

            for (int network_seed = network_start_seed; network_seed <= network_finish_seed; network_seed++)
            {
                foreach (var node_num in node_num_list)
                {
                    foreach (var network_enum in network_enum_list)
                    {
                        int grid_m, grid_n;
                        grid_m = grid_n = 0;
                        //grid_m = grid_n = (int)Math.Floor(Math.Sqrt(Convert.ToDouble(node_num)));


                        switch (network_enum)
                        {
                            case NetworkEnum.WS:
                                seed_enable = true;
                                network_generator = new WS_NetworkGenerator(node_num, degree, rewire_p);
                                break;
                            case NetworkEnum.BA:
                                seed_enable = true;
                                network_generator = new BA_NetworkGenerator(node_num, attach_edge_num);
                                break;
                            case NetworkEnum.ER:
                                seed_enable = true;
                                network_generator = new ER_NetworkGenerator(node_num, edge_creation_p);
                                break;
                            case NetworkEnum.Grid2D:
                                grid_m = grid_n = (int)Math.Floor(Math.Sqrt(Convert.ToDouble(node_num)));
                                seed_enable = false;
                                network_generator = new Grid2D_NetworkGenerator(grid_m, grid_n);
                                break;
                            case NetworkEnum.Hexagonal:
                                if (node_num == 100)
                                {
                                    grid_m = grid_n = 6;
                                }
                                else if (node_num == 200)
                                {
                                    grid_m = grid_n = 9;
                                }
                                else if (node_num == 300)
                                {
                                    grid_m = 12;
                                    grid_n = 11;
                                }
                                else if (node_num == 400)
                                {
                                    grid_m = 13;
                                    grid_n = 13;
                                }
                                else if (node_num == 500)
                                {
                                    grid_m = grid_n = 15;
                                }
                                else if (node_num == 600)
                                {
                                    grid_m = 18;
                                    grid_n = 15;
                                }
                                else if (node_num == 700)
                                {
                                    grid_m = 19;
                                    grid_n = 17;
                                }
                                else if (node_num == 800)
                                {
                                    grid_m = 20;
                                    grid_n = 18;
                                }
                                else if (node_num == 900)
                                {
                                    grid_m = 21;
                                    grid_n = 20;
                                }
                                else if (node_num == 1000)
                                {
                                    grid_m = 22;
                                    grid_n = 21;
                                }
                                seed_enable = false;
                                network_generator = new Hexagonal_NetworkGenerator(grid_m, grid_n);
                                break;
                            case NetworkEnum.Triangular:
                                if (node_num == 100)
                                {
                                    grid_m = 12;
                                    grid_n = 13;
                                }
                                else if (node_num == 200)
                                {
                                    grid_m = 18;
                                    grid_n = 19;
                                }
                                else if (node_num == 300)
                                {
                                    grid_m = 24;
                                    grid_n = 22;
                                }
                                else if (node_num == 400)
                                {
                                    grid_m = 27;
                                    grid_n = 27;
                                }
                                else if (node_num == 500)
                                {
                                    grid_m = grid_n = 30;
                                }
                                else if (node_num == 600)
                                {
                                    grid_m = 32;
                                    grid_n = 34;
                                }
                                else if (node_num == 700)
                                {
                                    grid_m = 36;
                                    grid_n = 36;
                                }
                                else if (node_num == 800)
                                {
                                    grid_m = 39;
                                    grid_n = 38;
                                }
                                else if (node_num == 900)
                                {
                                    grid_m = 42;
                                    grid_n = 40;
                                }
                                else if (node_num == 1000)
                                {
                                    grid_m = 42;
                                    grid_n = 45;
                                }
                                seed_enable = false;
                                network_generator = new Triangular_NetworkGenerator(grid_m, grid_n);
                                break;
                            default:
                                break;
                        }
                        var network = network_generator.Generate(network_seed, seed_enable);
                        I_Layout layout = new Square_LayoutGenerator(network).Generate();

                        int agent_seed = network_seed;
                        I_AgentSet agent_set = new BasicAgentSetFactory(network, init_op, g_sigma, r_sigma).Generate(agent_seed, AgentInitMode.Normal);
                        if (!fix_sensor_num)
                        {
                            agent_set.SetSensors((int)(node_num * sensor_rate), sensor_acc);
                        }
                        else
                        {
                            agent_set.SetSensors(sensor_num, sensor_acc);
                        }

                        I_Algo algo = null;

                        foreach (var algo_enum in algo_enum_list)
                        {
                            switch (algo_enum)
                            {
                                case AlgoEnum.OriginalAAT:
                                    var gcw = new GeneratingCanWeights();
                                    var ear = new EstimatingAwaRates();
                                    var sws = new SelectingWeiStrategies(t_awa_rate);
                                    var pos = new PlayOneStep(new SendOpinion(op_intro_rate, op_intro_duration), new ReceiveOpinion());
                                    algo = new AAT_Algo(AlgoEnum.OriginalAAT, gcw, ear, sws, pos);
                                    break;
                                case AlgoEnum.HCII_AATD:
                                    var hcii_aatd_gcw = new GeneratingCanWeights();
                                    var hcii_aatd_ear = new HCII_AATD_EstimatingAwaRates();
                                    var hcii_sws = new SelectingWeiStrategies(t_awa_rate);
                                    var hcii_aatd_pos = new PlayOneStep(new SendOpinion(op_intro_rate, op_intro_duration), new ReceiveOpinion());
                                    algo = new AAT_Algo(AlgoEnum.HCII_AATD, hcii_aatd_gcw, hcii_aatd_ear, hcii_sws, hcii_aatd_pos);
                                    break;
                                case AlgoEnum.AATD:
                                    var aatd_gcw = new GeneratingCanWeights();
                                    var aatd_ear = new AATD_EstimatingAwaRates();
                                    var aatd_sws = new AATD_SelectingWeiStrategies(t_awa_rate, 2, agent_set.AgentList.Count);
                                    var aatd_pos = new PlayOneStep(new SendOpinion(op_intro_rate, op_intro_duration), new ReceiveOpinion());
                                    algo = new AAT_Algo(AlgoEnum.AATD, aatd_gcw, aatd_ear, aatd_sws, aatd_pos);
                                    break;
                                case AlgoEnum.AATD_NoTargetH:
                                    var aatd_noth_gcw = new GeneratingCanWeights();
                                    var aatd_noth_ear = new AATD_EstimatingAwaRates();
                                    var aatd_noth_sws = new AATD_SelectingWeiStrategies(1.0, 2, agent_set.AgentList.Count);
                                    var aatd_noth_pos = new PlayOneStep(new SendOpinion(op_intro_rate, op_intro_duration), new ReceiveOpinion());
                                    algo = new AAT_Algo(AlgoEnum.AATD, aatd_noth_gcw, aatd_noth_ear, aatd_noth_sws, aatd_noth_pos);
                                    break;
                            }

                            I_OSM osm = new BaseOSM();
                            osm.MyNetwork = network;
                            osm.MyAgentSet = agent_set;
                            osm.MyAlgo = algo;
                            osm.Initialize();

                            this.MakeFile(network_enum, node_num, network_seed, algo_enum);

                            RandomPool.Declare(SeedEnum.RoundSeed, round_seed);
                            RandomPool.Declare(SeedEnum.PlayStepSeed, round_seed);

                            //Console.WriteLine(this.PrintObject());
                            osm.MyAlgo.MyOSMLog.StartRecordRounds(this.OutputRoundFilePath);
                            for (int current_round = 1; current_round <= total_rounds; current_round++)
                            {
                                osm.MyAlgo.RunOneRound(osm.MyNetwork, osm.MyAgentSet, current_round, round_steps);
                            }
                            osm.MyAlgo.MyOSMLog.StopRecordRounds();
                        }


                    }

                }

            }

        }
    }
}
