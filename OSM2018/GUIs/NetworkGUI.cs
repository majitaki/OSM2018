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

namespace OSM2018.GUIs
{
    public partial class NetworkGUI : UserControl
    {
        public NetworkGUI()
        {
            InitializeComponent();
            this.UserInitialize();
        }

        void UserInitialize()
        {
            this.comboBoxWS.SelectedIndex = 0;
            this.comboBoxSF.SelectedIndex = 0;
            this.comboBoxRandom.SelectedIndex = 0;
        }

        private void buttonGenerateGraph_Click(object sender, EventArgs e)
        {
            //I_Network network = new WS_NetworkGenerator(100, 6, 0.01).Generate(1);
            I_Network network = new BA_NetworkGenerator(100, 6).Generate(1);
            I_Layout layout = new Circular_LayoutGenerator(network).Generate();
            network.MyLayout = layout;
        }
    }
}
