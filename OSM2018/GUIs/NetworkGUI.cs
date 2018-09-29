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
using OSM2018.Networks;
using OSM2018.Networks.LayoutGenerator;
using OSM2018.Networks.NetworkGenerator;
using OSM2018.Factories.AgentSetFactories;
using OSM2018.Utility;
using OSM2018.Interfaces.Algo;
using OSM2018.Algorithm.AAT;
using OSM2018.Algorithm.AAT.GeneCanWeights;
using OSM2018.Interfaces.Algo.AAT;
using OSM2018.Algorithm.AAT.EstAwaRates;
using OSM2018.Algorithm.AAT.SlctWeiStrategies;
using OSM2018.OSM;
using OSM2018.Algorithm.Common;

namespace OSM2018.GUIs
{
    public partial class NetworkGUI : UserControl
    {
        AnimationForm MyAF;
        MainForm MyMF;
        internal I_OSM MyOSM;

        public NetworkGUI(MainForm mf)
        {
            InitializeComponent();
            this.UserInitialize();
            this.MyMF = mf;
            this.MyAF = this.MyMF.MyAnimationForm;
        }

        void UserInitialize()
        {
            this.comboBoxSmallWorld.Items.Add(NetworkEnum.WS);
            this.comboBoxSmallWorld.Items.Add(NetworkEnum.NewmanWS);
            this.comboBoxSmallWorld.Items.Add(NetworkEnum.ConnectedWS);

            this.comboBoxScaleFree.Items.Add(NetworkEnum.BA);
            this.comboBoxScaleFree.Items.Add(NetworkEnum.PowerLawCluster);

            this.comboBoxRandom.Items.Add(NetworkEnum.ER);

            this.comboBoxOther.Items.Add(NetworkEnum.Grid2D);
            this.comboBoxOther.Items.Add(NetworkEnum.Hexagonal);

            this.comboBoxSmallWorld.SelectedIndex = 0;
            this.comboBoxScaleFree.SelectedIndex = 0;
            this.comboBoxRandom.SelectedIndex = 0;
            this.comboBoxOther.SelectedIndex = 0;

            this.IsGeneratingNetwork = false;
        }

        internal void SetOSM(I_OSM osm)
        {
            this.MyOSM = osm;
        }

        bool is_gene_network;
        bool IsGeneratingNetwork
        {
            get
            {
                return this.is_gene_network;
            }

            set
            {
                this.is_gene_network = value;
                if (!value)
                {
                    this.buttonGenerateGraph.Text = "Generate";
                    this.buttonGenerateGraph.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                }
                else
                {
                    this.buttonGenerateGraph.Text = "Progress";
                    this.buttonGenerateGraph.ForeColor = Color.DarkRed;
                    this.MyAF.ClearSelectAgent();
                }
            }
        }

        async private void buttonGenerateGraph_Click(object sender, EventArgs e)
        {
            this.MyMF.PlayStop();
            I_NetworkGenerator network_generator = null;
            this.MyOSM.MyNetwork = null;
            this.MyOSM.MyAgentSet = null;
            this.MyOSM.MyAlgo = null;

            bool seed_enable = true;
            int node_num = (int)this.numericUpDownNodeNum.Value;
            int network_seed = (int)this.numericUpDownGraphSeed.Value;
            double rewire_p = (double)this.numericUpDownWSrewirep.Value;
            int degree = (int)this.numericUpDownWSdegree.Value;
            int attach_edge_num = (int)this.numericUpDownBAattachEdge.Value;
            int rnd_edge_num = (int)this.numericUpDownPCrndEdge.Value;
            double triangle_p = (double)this.numericUpDownPCaddTriP.Value;
            double edge_creation_p = (double)this.numericUpDownEdgeCreationP.Value;
            int grid_m = (int)this.numericUpDownGridM.Value;
            int grid_n = (int)this.numericUpDownGridN.Value;

            if (this.radioButtonSmallWorld.Checked)
            {
                seed_enable = true;
                switch ((NetworkEnum)Enum.Parse(typeof(NetworkEnum), this.comboBoxSmallWorld.Text, true))
                {
                    case NetworkEnum.WS:
                        network_generator = new WS_NetworkGenerator(node_num, degree, rewire_p);
                        break;
                    case NetworkEnum.NewmanWS:
                        network_generator = new NewmanWS_NetworkGenerator(node_num, degree, rewire_p);
                        break;
                    case NetworkEnum.ConnectedWS:
                        network_generator = new ConnectedWS_NetworkGenerator(node_num, degree, rewire_p);
                        break;
                }
            }
            else if (this.radioButtonScaleFree.Checked)
            {
                seed_enable = true;
                switch ((NetworkEnum)Enum.Parse(typeof(NetworkEnum), this.comboBoxScaleFree.Text, true))
                {
                    case NetworkEnum.BA:
                        network_generator = new BA_NetworkGenerator(node_num, attach_edge_num);
                        break;
                    case NetworkEnum.PowerLawCluster:
                        network_generator = new PC_NetworkGenerator(node_num, rnd_edge_num, triangle_p);
                        break;
                }
            }
            else if (this.radioButtonRandom.Checked)
            {
                seed_enable = true;
                switch ((NetworkEnum)Enum.Parse(typeof(NetworkEnum), this.comboBoxRandom.Text, true))
                {
                    case NetworkEnum.ER:
                        network_generator = new ER_NetworkGenerator(node_num, edge_creation_p);
                        break;
                }
            }
            else if (this.radioButtonOther.Checked)
            {
                switch ((NetworkEnum)Enum.Parse(typeof(NetworkEnum), this.comboBoxOther.Text, true))
                {
                    case NetworkEnum.Grid2D:
                        seed_enable = false;
                        network_generator = new Grid2D_NetworkGenerator(grid_m, grid_n);
                        break;
                    case NetworkEnum.Hexagonal:
                        seed_enable = false;
                        network_generator = new Hexagonal_NetworkGenerator(grid_m, grid_n);
                        break;
                }
            }

            this.IsGeneratingNetwork = true;
            await Task.Run(() =>
            {
                this.MyOSM.MyNetwork = network_generator.Generate(network_seed, seed_enable);
                this.MyAF.UpdatePictureBox();
            });
            this.IsGeneratingNetwork = false;


            /*
            I_Network network = new WS_NetworkGenerator(100, 6, 0.01).Generate(1);
            I_Layout layout = new Circular_LayoutGenerator(network).Generate();
            network.SetLayout(layout);

            I_AgentSet agent_set = new BasicAgentSetFactory(network, InfoEnum.Undeter, 0.9, 0.1).Generate(1, AgentInitMode.Random);
            agent_set.SetSensors(SetSensorMode.Number, 20, 0.55);

            this.MyAnimationForm.MyNetwork = network;
            this.MyAnimationForm.MyAgentSet = agent_set;
            var pos = new PlayOneStep(new SendOpinion(0.1), new ReceiveOpinion());
            I_Algo algo = new AAT_Algo(new GeneratingCanWeights(), new EstimatingAwaRates(), new SelectingWeiStrategies(), pos);
            this.MyAnimationForm.MyAlgo = algo;

            I_OSM osm = new BaseOSM(network, agent_set, algo);
            osm.Initialize();
            osm.PlaySteps(1000, 1);
            this.MyAnimationForm.UpdatePictureBox();

            return;
            osm.RunRounds(100, 1000, 1);
            osm.PlaySteps(1000, 1);
            */
        }
    }
}
