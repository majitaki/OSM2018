using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSM2018.Utility;
using OSM2018.Interfaces;
using OSM2018.Experiments;

namespace OSM2018.GUIs
{
    public partial class ExperimentGUI : UserControl
    {
        MainForm MyMF;
        public ExperimentGUI(MainForm mf)
        {
            this.MyMF = mf;
            InitializeComponent();
            this.UserInitialize();
        }

        void UserInitialize()
        {
            foreach (ExpEnum exp_enum in Enum.GetValues(typeof(ExpEnum)))
            {
                this.comboBoxExp.Items.Add(exp_enum.ToString());
            }
            this.comboBoxExp.SelectedIndex = 0;
            this.IsRunningExperiment = false;
        }

        bool is_running_experiment;
        bool IsRunningExperiment
        {
            get
            {
                return this.is_running_experiment;
            }

            set
            {
                this.is_running_experiment = value;
                if (!value)
                {
                    this.buttonRunExperiment.Text = "Run";
                    this.buttonRunExperiment.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                }
                else
                {
                    this.buttonRunExperiment.Text = "Progress";
                    this.buttonRunExperiment.ForeColor = Color.DarkRed;
                }
            }
        }

        private void buttonRunExperiment_Click(object sender, EventArgs e)
        {
            this.MyMF.PlayStop();
            I_Experiment exp = null;
            switch ((ExpEnum)Enum.Parse(typeof(ExpEnum), this.comboBoxExp.Text, true))
            {
                case ExpEnum.Exp_LowRound_ChangeNetwork:
                    exp = new Exp_LowRound_ChangeNetwork();
                    break;
                default:
                    break;
            }
            this.IsRunningExperiment = true;
            exp.Run();
            this.IsRunningExperiment = false;
        }
    }
}
