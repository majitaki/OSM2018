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
        NetworkGUI MyNG;
        AnimationForm MyAF;
        MainForm MyMF;
        internal I_OSM MyOSM;

        public AgentGUI(MainForm mf)
        {
            this.MyMF = mf;
            this.MyNG = this.MyMF.MyNetworkGUI;
            this.MyAF = this.MyMF.MyAnimationForm;
            InitializeComponent();
            this.UserInitialize();
        }

        void UserInitialize()
        {
            //this.comboBoxAAT.Items.Add(AlgoEnum.OriginalAAT);
            //this.comboBoxAAT.Items.Add(AlgoEnum.AATD);
            foreach (AlgoEnum algo_enum in Enum.GetValues(typeof(AlgoEnum)))
            {
                this.comboBoxAAT.Items.Add(algo_enum.ToString());
            }
            this.comboBoxAAT.SelectedIndex = 0;

            foreach (InfoEnum op in Enum.GetValues(typeof(InfoEnum)))
            {
                this.comboBoxInitOpinion.Items.Add(op.ToString());
            }
            this.comboBoxInitOpinion.SelectedIndex = 0;

            this.checkBoxSensorRateEnabled.Checked = true;
            this.numericUpDownSensorRate.Value = (decimal)0.10;

            this.IsGeneratingAgentNetwork = false;
        }

        internal void SetOSM(I_OSM osm)
        {
            this.MyOSM = osm;
        }

        bool is_gene_agent_network;
        bool IsGeneratingAgentNetwork
        {
            get
            {
                return this.is_gene_agent_network;
            }

            set
            {
                this.is_gene_agent_network = value;
                if (!value)
                {
                    this.buttonGenerateAgentNetwork.Text = "Generate";
                    this.buttonGenerateAgentNetwork.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                }
                else
                {
                    this.buttonGenerateAgentNetwork.Text = "Progress";
                    this.buttonGenerateAgentNetwork.ForeColor = Color.DarkRed;
                }
            }
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
                        algo = new AAT_Algo(AlgoEnum.OriginalAAT, gcw, ear, sws, pos);
                        break;
                    case AlgoEnum.HCII_AATD:
                        var hcii_aatd_gcw = new GeneratingCanWeights();
                        var hcii_aatd_ear = new HCII_AATD_EstimatingAwaRates();
                        var hcii_sws = new SelectingWeiStrategies(t_awa_rate);
                        var hcii_aatd_pos = new PlayOneStep(new SendOpinion(op_intro_rate, op_intro_duration), new ReceiveOpinion());
                        algo = new AAT_Algo(AlgoEnum.HCII_AATD, hcii_aatd_gcw, hcii_aatd_ear, hcii_sws, hcii_aatd_pos);
                        break;
                    case AlgoEnum.AATD:
                        var aatd_gcw = new GeneratingCanWeights();
                        var aatd_ear = new AATD_EstimatingAwaRates();
                        var aatd_sws = new AATD_SelectingWeiStrategies(t_awa_rate, 2, agent_set.AgentList.Count);
                        var aatd_pos = new PlayOneStep(new SendOpinion(op_intro_rate, op_intro_duration), new ReceiveOpinion());
                        algo = new AAT_Algo(AlgoEnum.AATD, aatd_gcw, aatd_ear, aatd_sws, aatd_pos);
                        break;
                    case AlgoEnum.AATD_NoTargetH:
                        var aatd_noth_gcw = new GeneratingCanWeights();
                        var aatd_noth_ear = new AATD_EstimatingAwaRates();
                        var aatd_noth_sws = new AATD_SelectingWeiStrategies(1.0, 2, agent_set.AgentList.Count);
                        var aatd_noth_pos = new PlayOneStep(new SendOpinion(op_intro_rate, op_intro_duration), new ReceiveOpinion());
                        algo = new AAT_Algo(AlgoEnum.AATD, aatd_noth_gcw, aatd_noth_ear, aatd_noth_sws, aatd_noth_pos);

                        break;
                }
            }
            this.MyOSM.MyAlgo = algo;

            this.IsGeneratingAgentNetwork = true;
            await Task.Run(() =>
            {
                this.MyOSM.Initialize();
                this.MyAF.UpdatePictureBox();
            });
            this.IsGeneratingAgentNetwork = false;
        }


        private void buttonGenerateAgentNetwork_Click(object sender, EventArgs e)
        {
            this.MyMF.PlayStop();
            I_Network network = this.MyOSM.MyNetwork;
            if (network == null) return;
            this.GenerateAgentWithAlgo(network);

        }

    }
}