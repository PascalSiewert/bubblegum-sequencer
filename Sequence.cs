﻿using System;
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

        private List<List<Color>> colors;

        public Sequence(ColorToneMap aMap, int aBPM)
        {
            ctMap = aMap;
            bpm = aBPM;
            colors = new List<List<Color>>();
        }

        public Tone getToneByColorIndex(int col, int row)
        {
            Tone tone = ctMap.getToneByColor(colors[col][row]);

            return tone;
        }

        public void addColorAt(Color c, int col)
        {
            while (col >= colors.Count)
            {
                colors.Add(new List<Color>());
            }

            colors[col].Add(c);            
        }

        public Tone getToneAt(int index)
        {
            Tone tone = ctMap.getToneAt(index);
            return tone;
        }

        public int getColSize()
        {
            return colors.Count;
        }

        public int getRowSize(int col)
        {
            return colors[col].Count;
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
