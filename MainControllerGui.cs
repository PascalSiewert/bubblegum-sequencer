using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Midi;

namespace bubblegum_sequencer
{
    public partial class MainControllerGui : Form
    {
        private OutputDevice output;
        private Sequence sequence;
        private SequencePlayer player;        

        public MainControllerGui()
        {
            InitializeComponent();

            output = OutputDevice.InstalledDevices[0];

            ColorToneMap map = new ColorToneMap();

            map.addColor(new Tone(Pitch.C4, Instrument.Banjo), Color.Black);
            map.addColor(new PercussionTone(Percussion.SnareDrum1), Color.Gray);

            sequence = new Sequence(map, (int)numBPM.Value);

            player = new SequencePlayer(output, sequence);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.startPlayer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.stopPlayer();
        }

        private void MainControllerGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            player.stopPlayer();
        }

        private void numBPM_ValueChanged(object sender, EventArgs e)
        {
            sequence.setBPM((int)numBPM.Value);
        }
    }
}
