using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubblegum_sequencer
{
    public partial class ColorInsert : Form, IObserver
    {
        ColorList colorlist;
        int picWidth = 0;//aktuelle original Bildbreite
        bool reading = false;//Soll gelesen werden?
        Point readingPos;//Position an der die Farbe bestimmt werden soll
        List<Color> readings;
        int readingcount;
        Color acColor;//aktuelle Farbe

        public ColorInsert()
        {
            InitializeComponent();
            readings = new List<Color>();
            acColor = new Color();
        }

        public void update(IObserverable subject)
        {
            if (subject is VideoSource)
            {
                VideoSource source;

                source = (VideoSource)subject;
                if (picWidth != source.Picture.Width)//Wenn sich Bildgröße geändert hat
                {
                    double aspectRatio;
                    if ((Convert.ToDouble(source.Picture.Width) / Convert.ToDouble(source.Picture.Height) * picPicture.Height) < picPicture.Width)
                    {
                        aspectRatio = Convert.ToDouble(source.Picture.Width) / Convert.ToDouble(source.Picture.Height);//Berechnung mit Double um Nachkommastellen zu beachten
                        picPicture.Width = Convert.ToInt32(aspectRatio * picPicture.Height);//Berechnet die passende Breite für die picPicture nach dem Seitenverhältnis(aspectRatio)
                    }
                    else
                    {
                        aspectRatio = Convert.ToDouble(source.Picture.Height) / Convert.ToDouble(source.Picture.Width);//Berechnung mit Double um Nachkommastellen zu beachten
                        picPicture.Height = Convert.ToInt32(aspectRatio * picPicture.Width);//Berechnet die passende Breite für die picPicture nach dem Seitenverhältnis(aspectRatio)
                    }
                    picWidth = source.Picture.Width;
                }

                picPicture.BackgroundImage = source.Picture;           

                if (reading)//MESSUNG
                {
                    if (readingcount > 0)//Wenn noch Messwerte gebraucht werden
                    {
                        Color color;
                        Bitmap picture = (Bitmap)picPicture.BackgroundImage;
                        color = picture.GetPixel(readingPos.X, readingPos.Y);//Farbe an Position bestimmen
                        readings.Add(color);//Farbe zu den Messdaten hinzufügen

                        prbWork.PerformStep();//Problem(Fliegt raus!)

                        readingcount--;
                    }
                    else//Sonst Messung beenden und Auswerten
                    {
                        reading = false;//Messung beenden


                        int r = 0;
                        int g = 0;
                        int b = 0;

                        //Durchschnittswerte für r,g,b ausrechnen
                        for (int i = 0; i < readings.Count; i++)
                        {
                            r = r + readings[i].R;
                            g = g + readings[i].G;
                            b = b + readings[i].B;
                        }
                        r = r / readings.Count;
                        g = g / readings.Count;
                        b = b / readings.Count;

                        acColor = Color.FromArgb(r, g, b);//aktuelle Farbe setzen
                        if (acColor.IsNamedColor)//Wenn es einen Namen für die Farbe gibt, diesen vorschlagen
                        {
                            txtColorName.Text = acColor.Name;
                        }
                        txtColor.Text = "R:" + acColor.R.ToString() + " | G:" + acColor.G.ToString() + " | B:" + acColor.B.ToString();//PROBLEM(Fliegt raus!)
                    }
                }
            }
            else if (subject is ColorList)
            {
                colorlist = (ColorList)subject;
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picPicture_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point picPoint = e.Location;//Mausposition auf picturebox

            if (!reading)//Wenn nicht bereits eine Messung läuft, starte eine
            {                
                readingPos = getBitmapPoint(picPoint);//Mausposition auf Bitmap
                if (txtReadingcount.Text == "")
                {
                    readingcount = 10;//STANDARDWERT für readingcount
                }
                else
                {
                    readingcount = Convert.ToInt32(txtReadingcount.Text);//Messungsanzahl
                }
                prbWork.Value = 0;
                prbWork.Maximum = readingcount;                
                reading = true;//Messungen werden gestartet
            }           
        }

        private Point getBitmapPoint(Point picPoint)
        {
            Point bitPoint = new Point();
            Bitmap picture = (Bitmap)picPicture.BackgroundImage;

            //X- und Y-Koordinaten umrechenen
            bitPoint.X = Convert.ToInt32((Convert.ToDouble(picture.Width) / Convert.ToDouble(picPicture.Width)) * picPoint.X);
            bitPoint.Y = Convert.ToInt32((Convert.ToDouble(picture.Height) / Convert.ToDouble(picPicture.Height)) * picPoint.Y);

            return bitPoint;
        }

    }
}
