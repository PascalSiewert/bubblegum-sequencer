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

            map.addColor(new Tone(Pitch.FSharp5, Instrument.ElectricGrandPiano), Color.Black);
            map.addColor(new Tone(Pitch.E5, Instrument.AltoSax), Color.Gray);
            map.addColor(new Tone(Pitch.D5, Instrument.DistortionGuitar), Color.Blue);
            map.addColor(new Tone(Pitch.CSharp5, Instrument.AcousticGuitarNylon), Color.Red);
            map.addColor(new Tone(Pitch.B4, Instrument.AcousticGuitarSteel), Color.Yellow);
            map.addColor(new Tone(Pitch.A4, Instrument.Trumpet), Color.Orange);
            map.addColor(new Tone(Pitch.B4, Instrument.ElectricGrandPiano), Color.Green);
            map.addColor(new PercussionTone(Percussion.HandClap), Color.Brown);
            map.addColor(new PercussionTone(Percussion.BassDrum2), Color.Chocolate);
            map.addColor(new PercussionTone(Percussion.OpenHiHat), Color.CornflowerBlue);
            map.addColor(new Tone(Pitch.E0, Instrument.ElectricBassFinger), Color.Cyan);

            sequence = new Sequence(map, (int)numBPM.Value);
            sequence.addColorAt(Color.Brown, 0);
            sequence.addColorAt(Color.Brown, 1);
            sequence.addColorAt(Color.Brown, 2);
            sequence.addColorAt(Color.Brown, 3);
            sequence.addColorAt(Color.Brown, 4);
            sequence.addColorAt(Color.Brown, 5);
            sequence.addColorAt(Color.Brown, 6);
            sequence.addColorAt(Color.Brown, 7);

            sequence.addColorAt(Color.Chocolate, 0);
            sequence.addColorAt(Color.Chocolate, 2);
            sequence.addColorAt(Color.Chocolate, 4);
            sequence.addColorAt(Color.Chocolate, 6);

            sequence.addColorAt(Color.Cyan, 0);
            sequence.addColorAt(Color.Cyan, 2);
            sequence.addColorAt(Color.Cyan, 4);
            sequence.addColorAt(Color.Cyan, 6);

            sequence.addColorAt(Color.CornflowerBlue, 3);
            sequence.addColorAt(Color.CornflowerBlue, 7);

            sequence.addColorAt(Color.Black, 0);
            sequence.addColorAt(Color.Red, 0);
            sequence.addColorAt(Color.Gray, 1);
            sequence.addColorAt(Color.Blue, 2);
            sequence.addColorAt(Color.Red, 3);
            sequence.addColorAt(Color.Yellow, 4);
            sequence.addColorAt(Color.Orange, 5);
            sequence.addColorAt(Color.Green, 6);
            sequence.addColorAt(Color.Red, 7);

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
