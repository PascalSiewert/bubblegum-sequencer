using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bubblegum_sequencer
{
    public partial class MainControllerGui : Form
    {
        public MainControllerGui()
        {
            InitializeComponent();
        }

        private void kameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cam Camoptions = new Cam();

            Camoptions.Show();
        }
    }
}
