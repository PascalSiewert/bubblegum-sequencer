using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace bubblegum_sequencer
{
    class ColorList
    {
        private List<Color> colors;

        public ColorList()
        {
            colors = new List<Color>();
        }

        public bool addColor(Color color)
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
                colors.Add(color);
                success = true;
            }

            return success;
        }

        public Color getColor(int id)
        {
            return colors[id];
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
