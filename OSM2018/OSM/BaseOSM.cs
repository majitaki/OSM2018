﻿using OSM2018.Experiments;
using OSM2018.GUIs;
using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.OSM
{
    class BaseOSM : I_OSM
    {
        public I_Network MyNetwork { get; set; }
        public I_AgentSet MyAgentSet { get; set; }
        public I_Algo MyAlgo { get; set; }

        public BaseOSM()
        {
            this.MyNetwork = null;
            this.MyAgentSet = null;
            this.MyAlgo = null;
        }

        public void Initialize()
        {
            this.MyAlgo.Initialize(this.MyNetwork, this.MyAgentSet);
        }

        public void PlaySteps(int steps, int playstep_seed)
        {
            RandomPool.Declare(SeedEnum.PlayStepSeed, playstep_seed);
            for (int i = 0; i < steps; i++)
            {
                this.MyAlgo.PlayOneStep(this.MyNetwork, this.MyAgentSet, InfoEnum.Green, InfoEnum.Red);
            }
        }

        public void RunRoundWithoutPlaySteps(int current_round, int runround_seed)
        {
            RandomPool.Declare(SeedEnum.RoundSeed, runround_seed);
            this.MyAlgo.RunOneRoundWithoutPlaySteps(this.MyNetwork, this.MyAgentSet, current_round);
        }

        public void RunRounds(int total_rounds, int round_steps, int runround_seed, string exp_name)
        {
            var exp = new Exp_NoExperiment(total_rounds, round_steps, runround_seed, this);
            exp.Run();
        }

        public void InitializePlaySteps()
        {
            this.MyAlgo.InitializePlaySteps(this.MyNetwork, this.MyAgentSet);
        }

        public void InitializeRunRounds()
        {
            this.MyAlgo.InitializeRunRounds(this.MyNetwork, this.MyAgentSet);
        }

        public void PrintNetworkInfo()
        {
            this.MyNetwork.PrintInfo();
        }

        public void PrintNodeInfo(int node_id)
        {
            this.MyNetwork.PrintInfo(node_id);
        }

        public void PrintAgentInfo(int node_id)
        {
            this.MyAgentSet.AgentList[node_id].PrintInfo();
        }

        public void PrintAlgoAgentInfo(int node_id)
        {
            this.MyAlgo.PrintInfo(node_id);
        }

    }
}
