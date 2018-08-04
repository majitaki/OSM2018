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

namespace OSM2018.GUIs
{
    public partial class LearningGUI : UserControl
    {
        I_OSM MyOSM;

        public LearningGUI()
        {
            InitializeComponent();
        }

        internal void SetOSM(I_OSM osm)
        {
            this.MyOSM = osm;
        }

        private void buttonRunLearning_Click(object sender, EventArgs e)
        {
            var total_rounds = (int)this.numericUpDownAllRounds.Value;
            var round_steps = (int)this.numericUpDownAllSteps.Value;
            var round_seed = (int)this.numericUpDownLearningSeed.Value;

            this.MyOSM.Initialize();
            this.MyOSM.RunRounds(total_rounds, round_steps, round_seed);
        }
    }
}
