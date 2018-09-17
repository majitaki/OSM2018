using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;

namespace OSM2018.GUIs
{
    public partial class LearningGUI : UserControl
    {
        MainForm MyMF;
        I_OSM MyOSM;

        public LearningGUI(MainForm mf)
        {
            this.MyMF = mf;
            InitializeComponent();
        }

        internal void SetOSM(I_OSM osm)
        {
            this.MyOSM = osm;
        }

        private void buttonRunLearning_Click(object sender, EventArgs e)
        {
            var total_rounds = (int)this.numericUpDownAllRounds.Value;
            var round_steps = (int)this.numericUpDownAllSteps.Value;
            var round_seed = (int)this.numericUpDownLearningSeed.Value;
            I_Network network = this.MyOSM.MyNetwork;
            I_Algo algo = this.MyOSM.MyAlgo;
            I_AgentSet agent_set = this.MyOSM.MyAgentSet;
            if (network == null || algo == null || agent_set == null) return;

            this.MyOSM.Initialize();
            this.MyOSM.RunRounds(total_rounds, round_steps, round_seed);
        }
    }
}
