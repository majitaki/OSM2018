using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
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
    class Exp_NoExperiment : I_Experiment
    {
        int TotalRounds;
        int RoundSteps;
        int RoundSeed;
        I_Algo MyAlgo;
        I_Network MyNetwork;
        I_AgentSet MyAgentSet;
        string ExpName;
        string DataName;
        string BasePath;
        string OutputFolderPath;
        string OutputRoundFilePath;

        public Exp_NoExperiment(int total_rounds, int round_steps, int round_seed, I_OSM osm)
        {
            this.TotalRounds = total_rounds;
            this.RoundSteps = round_steps;
            this.RoundSeed = round_seed;
            this.MyAlgo = osm.MyAlgo;
            this.MyNetwork = osm.MyNetwork;
            this.MyAgentSet = osm.MyAgentSet;
            this.ExpName = "NoExp";
            var dt = DateTime.Now;
            this.DataName = dt.ToString("yyyy-MM-dd-HH-mm-ss");
            this.BasePath = Environment.CurrentDirectory;
            this.OutputFolderPath = this.BasePath + "\\" + OutputLog.BaseLogFolderName + "\\" + this.ExpName + "\\" + this.DataName;
            OutputLog.SafeCreateDirectory(this.OutputFolderPath);
        }

        public string PrintObject()
        {
            string obj_str = "No Experiment";
            return obj_str;
        }

        void MakeFileAndFolder()
        {
            var di = new DirectoryInfo(this.OutputFolderPath);
            this.OutputRoundFilePath = OutputLog.SafeCreateCSV(di, "RoundOpinion" + "_" + this.DataName);

            var round_dic = new Dictionary<string, string>();
            round_dic.Add("round_seed", this.RoundSeed.ToString());
            round_dic.Add("total_round", this.TotalRounds.ToString());
            round_dic.Add("round_steps", this.RoundSteps.ToString());

            var condition_string = "";
            foreach (var dic in this.MyNetwork.GetInfoString())
            {
                condition_string += dic.Key.ToString() + "." + dic.Value.ToString() + "_";
            }

            foreach (var dic in MyAgentSet.GetInfoString())
            {
                condition_string += dic.Key.ToString() + "." + dic.Value.ToString() + "_";
            }

            foreach (var dic in MyAlgo.GetInfoString())
            {
                condition_string += dic.Key.ToString() + "." + dic.Value.ToString() + "_";
            }

            foreach (var dic in round_dic)
            {
                condition_string += dic.Key.ToString() + "." + dic.Value.ToString() + "_";
            }

            var condition_path = OutputLog.SafeCreateCSV(di, condition_string);
            OutputLog.OutputLogCSV(new DataTable(), condition_path);
        }

        public void Run()
        {
            this.MakeFileAndFolder();

            RandomPool.Declare(SeedEnum.RoundSeed, this.RoundSeed);
            RandomPool.Declare(SeedEnum.PlayStepSeed, this.RoundSeed);

            Console.WriteLine(this.PrintObject());
            this.MyAlgo.MyOSMLog.StartRecordRounds(this.OutputRoundFilePath);
            for (int current_round = 1; current_round <= this.TotalRounds; current_round++)
            {
                this.MyAlgo.RunOneRound(this.MyNetwork, this.MyAgentSet, current_round, this.RoundSteps);
            }
            this.MyAlgo.MyOSMLog.StopRecordRounds();
        }

    }
}
