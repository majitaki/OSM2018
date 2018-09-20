using OSM2018.Interfaces;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Algorithm.Common
{
    class OSMLog : I_OSMLog
    {
        public bool IsRecordingRounds { get; private set; }
        public bool IsRecordingSteps { get; private set; }
        //public string BaseLogFolderName { get; private set; }
        //string ExpFolderName;
        string OutputRoundFilePath;
        //string OutputRoundFolderPath;
        DataTable RoundResults;
        DataTable StepResults;

        public OSMLog()
        {
            //this.BaseLogFolderName = "OutputLog";
            //this.ExpFolderName = "";
            this.InitializeRound();
        }

        void InitializeRound()
        {
            this.RoundResults = new DataTable();
            string[] columnList = { "round", "green_rate", "red_rate", "undeter_rate" };
            this.RoundResults.Columns.AddRange(columnList.Select(n => new DataColumn(n)).ToArray());
        }

        public void RecordOneRound(I_Network network, I_AgentSet agent_set, int current_round)
        {
            int green_count = 0;
            int red_count = 0;
            int undeter_count = 0;

            foreach (var agent in agent_set.AgentList)
            {
                switch (agent.Opinion)
                {
                    case InfoEnum.Undeter:
                        undeter_count++;
                        break;
                    case InfoEnum.Green:
                        green_count++;
                        break;
                    case InfoEnum.Red:
                        red_count++;
                        break;
                    default:
                        break;
                }
            }

            double all_count = green_count + red_count + undeter_count;
            var list = new List<double>();
            list.Add(green_count / all_count);
            list.Add(red_count / all_count);
            list.Add(undeter_count / all_count);
            this.RoundResults.Rows.Add(current_round, list[0], list[1], list[2]);

            Console.WriteLine($"round: {current_round,3} green: {list[0]:f3}  red: {list[1]:f3} undeter: {list[2]:f3}");

            if (!this.IsRecordingRounds) return;

            OutputLog.OutputLogCSV(this.RoundResults, this.OutputRoundFilePath);
        }

        public void StartRecordRounds(string output_round_filepath)
        {
            this.InitializeRound();
            this.OutputRoundFilePath = output_round_filepath;
            this.IsRecordingRounds = true;
        }

        public void StopRecordRounds()
        {
            this.OutputRoundFilePath = "";
            this.IsRecordingRounds = false;
        }

        public void StartRecordSteps()
        {
            throw new NotImplementedException();
        }

        public void RecordOneStep()
        {
            throw new NotImplementedException();
        }

        public void StopRecordSteps()
        {
            throw new NotImplementedException();
        }

    }
}
