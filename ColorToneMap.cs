using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace bubblegum_sequencer
{
    class ColorToneMap
    {
        private List<Tone> tones;
        private List<Color> colors;

        public ColorToneMap()
        {
            tones = new List<Tone>();
            colors = new List<Color>();
        }

        public bool addColor(Tone key, Color color)//Farb-Ton-Zuordnung hinzufügen
        {
            bool success = false;

            if (!colors.Contains(color))
            {
                tones.Add(key);
                colors.Add(color);
                success = true;
            }

            return success;
        }

        public bool deleteColorByColor(Color aColor)//Löscht Farb-Ton-Zuordnung nach Angabe der Farbe(Ungetestet)
        {
            bool success = false;

            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i] == aColor)
                {
                    colors.RemoveAt(i);
                    i--;
                }
            }

            return success;
        }

        public Tone getToneByColor(Color by)//Ton nach Farbe erhalten
        {
            bool foundColor = false;
            int index = 0;
            Tone tone = null;

            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i].Equals(by))
                {
                    index = i;
                    foundColor = true;
                }
            }

            if (foundColor)
            {
                tone = tones[index];
            }

            return tone;
        }

        public Tone getToneAt(int index)//Ton nach Index erhalten
        {
            return tones[index];
        }

        public int getSize()
        {
            int size = (tones.Count > colors.Count) ? colors.Count : tones.Count;

            return size;
        }
    }
}
