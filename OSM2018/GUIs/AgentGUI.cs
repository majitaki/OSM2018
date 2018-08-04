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
using OSM2018.Factories.AgentSetFactories;
using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Algorithm.AAT;
using OSM2018.Algorithm.AAT.GeneCanWeights;
using OSM2018.Algorithm.AAT.EstAwaRates;
using OSM2018.Algorithm.AAT.SlctWeiStrategies;
using OSM2018.Algorithm.Common;
using OSM2018.OSM;

namespace OSM2018.GUIs
{
    public partial class AgentGUI : UserControl
    {
        NetworkGUI MyNetworkGUI;
        AnimationForm MyAnimationForm;
        internal I_OSM MyOSM;

        public AgentGUI(NetworkGUI network_gui, AnimationForm anime_form)
        {
            this.MyNetworkGUI = network_gui;
            this.MyAnimationForm = anime_form;
            InitializeComponent();
            this.UserInitialize();
        }

        void UserInitialize()
        {
            this.comboBoxAAT.Items.Add(AlgoEnum.OriginalAAT);
            this.comboBoxAAT.SelectedIndex = 0;

            foreach (InfoEnum op in Enum.GetValues(typeof(InfoEnum)))
            {
                this.comboBoxInitOpinion.Items.Add(op.ToString());
            }
            this.comboBoxInitOpinion.SelectedIndex = 0;
        }

        internal void SetOSM(I_OSM osm)
        {
            this.MyOSM = osm;
        }

        async void GenerateAgentWithAlgo(I_Network network)
        {
            InfoEnum init_op = (InfoEnum)Enum.Parse(typeof(InfoEnum), this.comboBoxInitOpinion.Text, true);
            int agent_seed = (int)this.numericUpDownAgentSeed.Value;
            double g_sigma = (double)this.numericUpDownGreenSigma.Value;
            double r_sigma = (double)this.numericUpDownRedSigma.Value;
            int sensor_num = (int)this.numericUpDownSensorNum.Value;
            double sensor_rate = (double)this.numericUpDownSensorRate.Value;
            double sensor_acc = (double)this.numericUpDownSensorAccuracy.Value;
            double op_intro_rate = (double)this.numericUpDownOpinionIntroRate.Value;
            int op_intro_duration = (int)this.numericUpDownOpinionIntroDuration.Value;
            var t_awa_rate = (double)this.numericUpDownTargetH.Value;

            I_AgentSet agent_set = new BasicAgentSetFactory(network, init_op, g_sigma, r_sigma).Generate(agent_seed, AgentInitMode.Random);
            I_Algo algo = null;

            //agent
            if (this.checkBoxSensorRateEnabled.Checked)
            {
                var s_num = (int)Math.Floor(network.NodeList.Count * sensor_rate);
                agent_set.SetSensors(s_num, sensor_acc);
            }
            else
            {
                agent_set.SetSensors(sensor_num, sensor_acc);
            }
            this.MyOSM.MyAgentSet = agent_set;

            //algo
            if (this.radioButtonAAT.Checked)
            {
                switch ((AlgoEnum)Enum.Parse(typeof(AlgoEnum), this.comboBoxAAT.Text, true))
                {
                    case AlgoEnum.OriginalAAT:
                        var gcw = new GeneratingCanWeights();
                        var ear = new EstimatingAwaRates();
                        var sws = new SelectingWeiStrategies(t_awa_rate);
                        var pos = new PlayOneStep(new SendOpinion(op_intro_rate, op_intro_duration), new ReceiveOpinion());
                        algo = new AAT_Algo(gcw, ear, sws, pos);
                        break;
                }
            }
            this.MyOSM.MyAlgo = algo;

            await Task.Run(() =>
            {
                this.MyOSM.Initialize();
                this.MyAnimationForm.UpdatePictureBox();
            });
        }


        private void buttonGenerateAgentNetwork_Click(object sender, EventArgs e)
        {
            I_Network network = this.MyNetworkGUI.MyOSM.MyNetwork;
            if (network == null) return;
            this.GenerateAgentWithAlgo(network);

        }

    }
}