using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace bubblegum_sequencer
{
    class ColorList : IObserverable//Verwaltet alle gespeicherten Farben
    {
        private List<String> colorNames;
        private List<Color> colors;
        private List<int> readingcounts;//Anzahl der Messungen

        public ColorList()
        {
            colorNames = new List<string>();
            colors = new List<Color>();
            readingcounts = new List<int>();
        }

        public bool addColor(string colorName, Color color, int readingcount)
        {
            bool colorInList = false;//Gibt an ob Farbe bereits in der Liste vorhanden ist
            bool success = false;

            foreach (Color vColor in colors)
            {
                if (color.R < (vColor.R - 10) && color.R > (vColor.R + 10))//Wenn Rotanteil in etwa gleich
                {
                    if (color.G < (vColor.G - 10) && color.G > (vColor.G + 10))//Wenn Grünanteil in etwa gleich
                    {
                        if (color.B < (vColor.B - 10) && color.B > (vColor.B + 10))//Wenn Blauanteil in etwa gleich
                        {
                            colorInList = true;//Farbe bereits vorhanden
                        }
                    }
                }
            }

            if (!colorInList)
            {
                colorNames.Add(colorName);
                colors.Add(color);
                readingcounts.Add(readingcount);
                success = true;
            }

            notify();

            return success;
        }

        public string getColorName(int id)
        {
            return colorNames[id];
        }
        public Color getColor(int id)
        {
            return colors[id];
        }        
        public int getReadingcount(int id)
        {
            return readingcounts[id];
        }

        public int Count()
        {
            return colors.Count;
        }

        public bool deleteColorById(int id)
        {
            bool success = false;

            try
            {
                colors.RemoveAt(id);
                success = true;
            }
            catch { }

            return success;
        }
    }
}
