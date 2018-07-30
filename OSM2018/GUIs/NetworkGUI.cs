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

        public NetworkGUI(AnimationForm anime_form)
        {
            InitializeComponent();
            this.UserInitialize();
            this.MyAnimationForm = anime_form;
        }

        void UserInitialize()
        {
            this.comboBoxWS.SelectedIndex = 0;
            this.comboBoxSF.SelectedIndex = 0;
            this.comboBoxRandom.SelectedIndex = 0;
        }

        private void buttonGenerateGraph_Click(object sender, EventArgs e)
        {
            I_Network network = new WS_NetworkGenerator(100, 6, 0.01).Generate(1);
            I_Layout layout = new Circular_LayoutGenerator(network).Generate();
            network.SetLayout(layout);

            I_AgentSet agent_set = new BasicAgentSetFactory(network, InfoEnum.Red, 0.9, 0.1).Generate(1, AgentInitMode.Random);
            agent_set.SetSensors(SetSensorMode.Number, 20, 0.75);

            this.MyAnimationForm.MyNetwork = network;
            this.MyAnimationForm.MyAgentSet = agent_set;
            var pos = new PlayOneStep(new SendOpinion(0.1), new ReceiveOpinion());
            I_Algo algo = new AAT_Algo(new GeneratingCanWeights(), new EstimatingAwaRates(), new SelectingWeiStrategies(), pos);
            this.MyAnimationForm.MyAlgo = algo;

            I_OSM osm = new BaseOSM(network, agent_set, algo);
            osm.Initialize();
            osm.PlaySteps(10000, 1);
            this.MyAnimationForm.UpdatePictureBox();

            return;
            osm.RunRounds(100, 1000, 1);
            osm.PlaySteps(1000, 1);
        }
    }
}
