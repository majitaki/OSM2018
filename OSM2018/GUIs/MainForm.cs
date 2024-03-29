﻿using OSM2018.GUIs;
using OSM2018.Interfaces;
using OSM2018.OSM;
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
        internal NetworkGUI MyNetworkGUI;
        internal AgentGUI MyAgentGUI;
        internal LearningGUI MyLearningGUI;
        internal AnimationGUI MyAnimationGUI;
        internal ExperimentGUI MyExperimentGUI;
        internal AnimationForm MyAnimationForm;
        I_OSM MyOSM;
        int CurrentWidth;
        int CurrentHeight;

        bool PlayStopFlag;

        public MainForm()
        {
            this.MyOSM = new BaseOSM();
            this.UserInitializeComponent();
            InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            PythonProxy.StartUpPython();
            this.radioButtonStepCheck.Checked = true;
            this.radioButtonNetworkGUI.Checked = true;
            this.numericUpDownStepsControl.Value = 3000;
            this.numericUpDownSpeedControl.Value = 1;
            this.labelRoundNum.Text = 1.ToString();
            this.PlayStopFlag = true;
        }

        void UserInitializeComponent()
        {
            this.SettingGUIList = new List<UserControl>();

            this.MyAnimationForm = new AnimationForm(this);
            this.MyAnimationForm.SetOSM(this.MyOSM);
            this.MyAnimationForm.Show();
            this.MyAnimationForm.Left = this.Right;
            this.DoubleBuffered = true;

            this.MyNetworkGUI = new NetworkGUI(this);
            this.MyNetworkGUI.SetOSM(this.MyOSM);
            this.MyNetworkGUI.Dock = DockStyle.Fill;
            this.MyNetworkGUI.Name = "NetworkGUI";
            this.Controls.Add(this.MyNetworkGUI);
            this.SettingGUIList.Add(this.MyNetworkGUI);
            this.MyNetworkGUI.Visible = true;

            this.MyAgentGUI = new AgentGUI(this);
            this.MyAgentGUI.SetOSM(this.MyOSM);
            this.MyAgentGUI.Dock = DockStyle.Fill;
            this.MyAgentGUI.Name = "AgentGUI";
            this.Controls.Add(this.MyAgentGUI);
            this.SettingGUIList.Add(this.MyAgentGUI);
            this.MyAgentGUI.Visible = false;

            this.MyLearningGUI = new LearningGUI(this);
            this.MyLearningGUI.SetOSM(this.MyOSM);
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

            this.MyExperimentGUI = new ExperimentGUI(this);
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

        /// <summary>
        /// ステップの更新を開始時に戻すための初期化
        /// </summary>
        internal void PlayStop()
        {
            this.PlayStopFlag = true;
            this.ChangePlayButton(false);
            int round_num = 1;
            int step_num = 0;

            this.labelRoundNum.Text = round_num.ToString();
            this.labelStepNum.Text = step_num.ToString();
            if (this.MyOSM == null || this.MyOSM.MyNetwork == null || this.MyOSM.MyAgentSet == null) return;

            if (this.radioButtonStepCheck.Checked)
            {
                this.MyOSM.InitializePlaySteps();
            }
            else if (this.radioButtonRoundCheck.Checked)
            {
                this.MyOSM.InitializeRunRounds();
            }
            this.MyAnimationForm.UpdatePictureBox();
        }

        void PlaySeedStop()
        {
            this.PlayStop();
            this.numericUpDownControlSeed.Value++;
        }

        void PlayOneStep()
        {
            var osm = this.MyAgentGUI.MyOSM;
            if (osm == null || osm.MyAgentSet == null || osm.MyAlgo == null) return;

            var control_seed = (int)this.numericUpDownControlSeed.Value;
            var control_speed = (int)this.numericUpDownSpeedControl.Value;
            var control_steps = (int)this.numericUpDownStepsControl.Value;

            var current_rounds = int.Parse(this.labelRoundNum.Text);
            var current_steps = int.Parse(this.labelStepNum.Text);

            control_seed += int.Parse(this.labelStepNum.Text);
            control_seed += int.Parse(this.labelRoundNum.Text);
            osm.PlaySteps(control_speed, control_seed);
            this.labelStepNum.Text = (current_steps + control_speed).ToString();
            current_steps += control_speed;

            if (this.radioButtonRoundCheck.Checked)
            {
                if (control_steps <= current_steps)
                {
                    osm.RunRoundWithoutPlaySteps(current_rounds, control_seed);
                    this.labelStepNum.Text = 0.ToString();
                    this.labelRoundNum.Text = (current_rounds + 1).ToString();
                }
            }

            this.MyAnimationForm.UpdatePictureBox();
        }

        void ChangePlayButton(bool turn_mode)
        {
            if (turn_mode)
            {
                this.PlayStopFlag = !this.PlayStopFlag;
            }

            if (!this.PlayStopFlag)
            {
                this.timerAnimation.Enabled = true;
                this.radioButtonPlay.Image = Properties.Resources.icon_pause;
            }
            else
            {
                this.timerAnimation.Enabled = false;
                this.radioButtonPlay.Image = Properties.Resources.icon_play;
            }


        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            this.PlayOneStep();
        }

        private void radioButtonPlayStop_Click(object sender, EventArgs e)
        {
            this.PlayStop();
        }

        private void radioButtonSeedPlus_Click(object sender, EventArgs e)
        {
            this.PlaySeedStop();
        }

        private void radioButtonPlay_Click(object sender, EventArgs e)
        {
            this.ChangePlayButton(true);
        }

        private void radioButtonPlayStep_Click(object sender, EventArgs e)
        {
            this.PlayOneStep();
        }

        private void buttonGraphShow_Click(object sender, EventArgs e)
        {
            this.MyAnimationForm.Left = this.Right;
            this.MyAnimationForm.Visible = !this.MyAnimationForm.Visible;
        }

        private void checkBoxMenu_CheckedChanged(object sender, EventArgs e)
        {
            var menu = (CheckBox)sender;
            if (this.WindowState == FormWindowState.Maximized)
            {
                menu.Checked = false;
                return;
            }

            if (menu.Checked)
            {
                this.CurrentHeight = this.Height;
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(this.CurrentWidth, this.CurrentHeight);
            }
        }
    }
}
