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
        AnimationForm MyAnimationForm;
        internal I_Network MyNetwork;

        public NetworkGUI(AnimationForm anime_form)
        {
            InitializeComponent();
            this.UserInitialize();
            this.MyAnimationForm = anime_form;
        }

        void UserInitialize()
        {
            this.comboBoxSmallWorld.Items.Add(NetworkEnum.WS);
            this.comboBoxSmallWorld.Items.Add(NetworkEnum.NewmanWS);
            this.comboBoxSmallWorld.Items.Add(NetworkEnum.ConnectedWS);
            this.comboBoxScaleFree.Items.Add(NetworkEnum.BA);
            this.comboBoxScaleFree.Items.Add(NetworkEnum.PowerLawCluster);
            this.comboBoxRandom.Items.Add(NetworkEnum.ER);

            this.comboBoxSmallWorld.SelectedIndex = 0;
            this.comboBoxScaleFree.SelectedIndex = 0;
            this.comboBoxRandom.SelectedIndex = 0;
        }

        private void buttonGenerateGraph_Click(object sender, EventArgs e)
        {
            I_Network network;
            int node_num = (int)this.numericUpDownNodeNum.Value;
            int network_seed = (int)this.numericUpDownGraphSeed.Value;
            double rewire_p = (double)this.numericUpDownWSrewirep.Value;
            int degree = (int)this.numericUpDownWSdegree.Value;
            int attach_edge_num = (int)this.numericUpDownBAattachEdge.Value;
            int rnd_edge_num = (int)this.numericUpDownPCrndEdge.Value;
            double triangle_p = (double)this.numericUpDownPCaddTriP.Value;
            double edge_creation_p = (double)this.numericUpDownEdgeCreationP.Value;


            if (this.radioButtonSmallWorld.Checked)
            {
                switch ((NetworkEnum)Enum.Parse(typeof(NetworkEnum), this.comboBoxSmallWorld.Text, true))
                {
                    case NetworkEnum.WS:
                        network = new WS_NetworkGenerator(node_num, degree, rewire_p).Generate(network_seed);
                        break;
                    case NetworkEnum.NewmanWS:
                        network = new NewmanWS_NetworkGenerator(node_num, degree, rewire_p).Generate(network_seed);
                        break;
                    case NetworkEnum.ConnectedWS:
                        network = new ConnectedWS_NetworkGenerator(node_num, degree, rewire_p).Generate(network_seed);
                        break;
                }
            }
            else if (this.radioButtonScaleFree.Checked)
            {
                switch ((NetworkEnum)Enum.ToObject(typeof(NetworkEnum), this.comboBoxSmallWorld.Text))
                {
                    case NetworkEnum.BA:
                        network = new BA_NetworkGenerator(node_num, attach_edge_num).Generate(network_seed);
                        break;
                    case NetworkEnum.PowerLawCluster:
                        network = new PC_NetworkGenerator(node_num, rnd_edge_num, triangle_p).Generate(network_seed);
                        break;
                }
            }
            else if (this.radioButtonRandom.Checked)
            {
                switch ((NetworkEnum)Enum.ToObject(typeof(NetworkEnum), this.comboBoxSmallWorld.Text))
                {
                    case NetworkEnum.ER:
                        network = new ER_NetworkGenerator(node_num, edge_creation_p).Generate(network_seed);
                        break;
                }
            }


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
