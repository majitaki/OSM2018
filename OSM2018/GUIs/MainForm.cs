using OSM2018.GUIs;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSM2018
{
    public partial class MainForm : Form
    {
        List<UserControl> SettingGUIList;
        NetworkGUI MyNetworkGUI;
        AgentGUI MyAgentGUI;
        LearningGUI MyLearningGUI;
        AnimationGUI MyAnimationGUI;
        ExperimentGUI MyExperimentGUI;
        AnimationForm MyAnimationForm;

        public MainForm()
        {
            this.UserInitializeComponent();
            InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            PythonProxy.StartUpPython();
        }

        void UserInitializeComponent()
        {
            this.SettingGUIList = new List<UserControl>();

            this.MyAnimationForm = new AnimationForm();
            this.MyAnimationForm.Show();
            this.MyAnimationForm.Left = this.Right;
            this.DoubleBuffered = true;

            this.MyNetworkGUI = new NetworkGUI(this.MyAnimationForm);
            this.MyNetworkGUI.Dock = DockStyle.Fill;
            this.MyNetworkGUI.Name = "NetworkGUI";
            this.Controls.Add(this.MyNetworkGUI);
            this.SettingGUIList.Add(this.MyNetworkGUI);
            this.MyNetworkGUI.Visible = true;

            this.MyAgentGUI = new AgentGUI();
            this.MyAgentGUI.Dock = DockStyle.Fill;
            this.MyAgentGUI.Name = "AgentGUI";
            this.Controls.Add(this.MyAgentGUI);
            this.SettingGUIList.Add(this.MyAgentGUI);
            this.MyAgentGUI.Visible = false;

            this.MyLearningGUI = new LearningGUI();
            this.MyLearningGUI.Dock = DockStyle.Fill;
            this.MyLearningGUI.Name = "LearningGUI";
            this.Controls.Add(this.MyLearningGUI);
            this.SettingGUIList.Add(this.MyLearningGUI);
            this.MyLearningGUI.Visible = false;

            this.MyAnimationGUI = new AnimationGUI();
            this.MyAnimationGUI.Dock = DockStyle.Fill;
            this.MyAnimationGUI.Name = "AnimationGUI";
            this.Controls.Add(this.MyAnimationGUI);
            this.SettingGUIList.Add(this.MyAnimationGUI);
            this.MyAnimationGUI.Visible = false;

            this.MyExperimentGUI = new ExperimentGUI();
            this.MyExperimentGUI.Dock = DockStyle.Fill;
            this.MyExperimentGUI.Name = "ExperimentGUI";
            this.Controls.Add(this.MyExperimentGUI);
            this.SettingGUIList.Add(this.MyExperimentGUI);
            this.MyExperimentGUI.Visible = false;

        }

        #region SettingChanged
        void SettingChanged(RadioButton b)
        {
            string name = b.Name;

            foreach (var setting in this.SettingGUIList)
            {
                setting.Visible = false;
            }

            switch (name)
            {
                case "radioButtonNetworkGUI":
                    this.SettingGUIList.First(s => s.Name == "NetworkGUI").Visible = true;
                    break;
                case "radioButtonAgentGUI":
                    this.SettingGUIList.First(s => s.Name == "AgentGUI").Visible = true;
                    break;
                case "radioButtonLearningGUI":
                    this.SettingGUIList.First(s => s.Name == "LearningGUI").Visible = true;
                    break;
                case "radioButtonAnimationGUI":
                    this.SettingGUIList.First(s => s.Name == "AnimationGUI").Visible = true;
                    break;
                case "radioButtonExperimentGUI":
                    this.SettingGUIList.First(s => s.Name == "ExperimentGUI").Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void radioButtonSetting_CheckedChanged(object sender, EventArgs e)
        {
            this.SettingChanged(sender as RadioButton);
        }




        #endregion

        private void timerAnimation_Tick(object sender, EventArgs e)
        {

        }
    }
}
