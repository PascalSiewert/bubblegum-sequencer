using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Midi;

namespace bubblegum_sequencer
{
    class Sequence
    {
        private ColorToneMap ctMap;

        private int bpm;

        private Color[] colors = { Color.Black, Color.Black, Color.Black, Color.Gray };

        public Sequence(ColorToneMap aMap, int aBPM)
        {
            ctMap = aMap;
            bpm = aBPM;
        }

        public Tone getToneByColor(int index)
        {
            Tone tone = ctMap.getToneByColor(colors[index]);

            return tone;
        }

        public Tone getToneAt(int index)
        {
            Tone tone = ctMap.getToneAt(index);
            return tone;
        }

        public int getSize()
        {
            return colors.Length;
        }

        public int getBPM()
        {
            return bpm;
        }

        public void setBPM(int value)
        {
            bpm = value;
        }
    }
}
