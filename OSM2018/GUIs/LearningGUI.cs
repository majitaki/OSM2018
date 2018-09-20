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
using OSM2018.Experiments;

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
            this.IsLearning = false;
        }

        internal void SetOSM(I_OSM osm)
        {
            this.MyOSM = osm;
        }

        bool is_learning;
        bool IsLearning
        {
            get
            {
                return this.is_learning;
            }

            set
            {
                this.is_learning = value;
                if (!value)
                {
                    this.buttonRunLearning.Text = "Learning";
                    this.buttonRunLearning.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                }
                else
                {
                    this.buttonRunLearning.Text = "Progress";
                    this.buttonRunLearning.ForeColor = Color.DarkRed;
                }
            }
        }

        async private void buttonRunLearning_Click(object sender, EventArgs e)
        {
            var total_rounds = (int)this.numericUpDownAllRounds.Value;
            var round_steps = (int)this.numericUpDownAllSteps.Value;
            var round_seed = (int)this.numericUpDownLearningSeed.Value;
            I_Network network = this.MyOSM.MyNetwork;
            I_Algo algo = this.MyOSM.MyAlgo;
            I_AgentSet agent_set = this.MyOSM.MyAgentSet;
            if (network == null || algo == null || agent_set == null) return;

            this.MyOSM.Initialize();

            this.IsLearning = true;
            await Task.Run(() =>
            {
                //var exp = new Exp_NoExperiment(total_rounds, round_steps, round_seed, this.MyOSM);
                //exp.Run();
                this.MyOSM.RunRounds(total_rounds, round_steps, round_seed);
                this.MyMF.MyAnimationForm.UpdatePictureBox();
            });
            this.IsLearning = false;
        }
    }
}
