using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace bubblegum_sequencer
{
    class ColorList : IObserverable//Verwaltet alle gespeicherten Farben
    {
        private List<String> colornames;
        private List<Color> colors;
        //private List<int> readingcounts;//Anzahl der Messungen

        public ColorList()
        {
            colornames = new List<string>();
            colors = new List<Color>();
            //readingcounts = new List<int>();
        }

        public bool addColor(string aColorname, Color aColor)//Farbe hinzufügen
        {
            bool colorInList = false;//Gibt an ob Farbe bereits in der Liste vorhanden ist
            bool colornameInList = false;//Gibt an ob Farbname bereits in der Liste vorhanden ist
            bool success = false;

            foreach (Color vColor in colors)//Vergleicht mit jeder bereits vorhandenen Farbe
            {
                if (aColor.R > (vColor.R - 10) && aColor.R < (vColor.R + 10))//Wenn Rotanteil in etwa gleich
                {
                    if (aColor.G > (vColor.G - 10) && aColor.G < (vColor.G + 10))//Wenn Grünanteil in etwa gleich
                    {
                        if (aColor.B > (vColor.B - 10) && aColor.B < (vColor.B + 10))//Wenn Blauanteil in etwa gleich
                        {
                            colorInList = true;//Farbe bereits vorhanden
                        }
                    }
                }               
            }

            foreach (String colorname in colornames)//Vergleicht mit jedem bereit vorhandenen Farbnamen
            {
                if (colorname == aColorname)//Überprüft, ob Farbname schon vorhanden
                {
                    colornameInList = true;
                }
            }

            if (!colorInList && !colornameInList)//Wenn Farbname und Farbe einzigartig sind, dann füge neue Farbe hinzu
            {
                colornames.Add(aColorname);
                colors.Add(aColor);
                //readingcounts.Add(readingcount);
                success = true;
            }

            notify();

            return success;
        }

        //Farbinformationen abrufen
        public string getColorname(int id)
        {
            return colornames[id];
        }
        public Color getColor(int id)
        {
            return colors[id];
        }        
        /*public int getReadingcount(int id)
        {
            return readingcounts[id];
        }*/

        public int Count()//Anzahl der Farben
        {
            return colors.Count;
        }

        public bool changeColorname(int id, string newName)
        {
            bool colornameInList = false;
            bool success = false;            

            foreach (String colorname in colornames)//Vergleicht mit jedem bereit vorhandenen Farbnamen
            {
                if (colorname == newName)//Überprüft, ob Farbname schon vorhanden
                {
                    colornameInList = true;
                }
            }

            if (!colornameInList)//Wenn Farbname einzigartig
            {
                colornames[id] = newName;
                if (colornames[id] == newName)
                {
                    success = true;
                }
            }

            return success;
        }

        public bool deleteColorById(int id)//Farbe löschen
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
