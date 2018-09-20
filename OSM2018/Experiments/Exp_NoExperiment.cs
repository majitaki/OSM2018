using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
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

        public Exp_NoExperiment(int total_rounds, int round_steps, int round_seed, I_Algo algo, I_Network network, I_AgentSet agent_set)
        {
            this.TotalRounds = total_rounds;
            this.RoundSteps = round_steps;
            this.RoundSeed = round_seed;
            this.MyAlgo = algo;
            this.MyNetwork = network;
            this.MyAgentSet = agent_set;
            this.ExpName = "NoExp";
        }

        public string PrintObject()
        {
            string obj_str = "No Experiment";
            return obj_str;
        }

        public void Run()
        {
            RandomPool.Declare(SeedEnum.RoundSeed, this.RoundSeed);
            RandomPool.Declare(SeedEnum.PlayStepSeed, this.RoundSeed);

            var round_dic = new Dictionary<string, string>();
            round_dic.Add("round_seed", this.RoundSeed.ToString());
            round_dic.Add("total_round", this.TotalRounds.ToString());
            round_dic.Add("round_steps", this.RoundSteps.ToString());

            this.MyAlgo.MyOSMLog.StartRecordRounds(this.MyNetwork.GetInfoString(), this.MyAgentSet.GetInfoString(), this.MyAlgo.GetInfoString(), round_dic, this.ExpName);
            for (int current_round = 1; current_round <= this.TotalRounds; current_round++)
            {
                this.MyAlgo.RunOneRound(this.MyNetwork, this.MyAgentSet, current_round, this.RoundSteps);
            }
            this.MyAlgo.MyOSMLog.StopRecordRounds();
        }
    }
}
