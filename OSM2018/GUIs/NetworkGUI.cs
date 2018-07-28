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

namespace OSM2018.GUIs {
  public partial class NetworkGUI : UserControl {
    public NetworkGUI() {
      InitializeComponent();
      this.UserInitialize();
    }

    void UserInitialize() {
      this.comboBoxWS.SelectedIndex = 0;
      this.comboBoxSF.SelectedIndex = 0;
      this.comboBoxRandom.SelectedIndex = 0;
    }

    private void buttonGenerateGraph_Click(object sender, EventArgs e) {
      I_Network network = new WS_NetworkGenerator(100, 6, 0.01).Generate(1);
      I_Layout layout = new Circular_LayoutGenerator(network).Generate();
      network.SetLayout(layout);

      I_AgentSet agent_set = new BasicAgentSetFactory(network, InfoEnum.Undeter, 0.9, 0.1).Generate(1, AgentInitMode.RandomWeakPulledByOpinion);
      agent_set.SetSensors(SetSensorMode.Number, 10);

      I_Algo algo = new AAT_Algo(new GeneratingCanWeights(), new EstimatingAwaRates(), new SelectingWeiStrategies());
      algo.Initialize(network, agent_set);

    }
  }
}
