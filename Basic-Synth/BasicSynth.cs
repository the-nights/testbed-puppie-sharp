using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ymir_SoundEngine
{
    public partial class BasicSynth : Form
    {
      

        public BasicSynth()
        {
            InitializeComponent();
        }

        private void BasicSynth_KeyDown(object sender, KeyEventArgs e)
        {
            // switching oscolator type
            foreach (OscillatorController oscillatorController in oscilators)
            {
            }
        }
    }
}
