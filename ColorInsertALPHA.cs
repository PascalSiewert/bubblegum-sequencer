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
    public partial class ColorInsertALPHA : Form, IObserver
    {
        ColorList colorlist;
        int picWidth = 0;//aktuelle original Bildbreite

        public ColorInsertALPHA()
        {
            InitializeComponent();
        }

        //Bild "einfangen"
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
            }
            else if (subject is ColorList)
            {
                colorlist = (ColorList)subject;
            }
        }

        //Farbe ermitteln
        private void picPicture_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point measurePoint = getBitmapPoint(e.Location);
            Bitmap measurePicture = (Bitmap)picPicture.BackgroundImage;
            Color color = measurePicture.GetPixel(measurePoint.X, measurePoint.Y);

            //gemessene Farbe in Textboxen eintragen
            txtMeasureRed.Text = color.R.ToString();
            txtMeasureGreen.Text = color.G.ToString();
            txtMeasureBlue.Text = color.B.ToString();

            //gemessene Farbe in Panel anzeigen
            pnlMeasureColor.BackColor = color;
        }
        private Point getBitmapPoint(Point picPoint)
        {
            Point bitPoint = new Point();
            Bitmap picture = (Bitmap)picPicture.BackgroundImage;

            //X- und Y-Koordinaten umrechenen
            bitPoint.X = Convert.ToInt32((Convert.ToDouble(picture.Width) / Convert.ToDouble(picPicture.Width)) * picPoint.X);
            bitPoint.Y = Convert.ToInt32((Convert.ToDouble(picture.Height) / Convert.ToDouble(picPicture.Height)) * picPoint.Y);

            return bitPoint;
        }//Mausposition auf picPicture in Mausposition auf Bitmap umrechnen

        //Messung in Farbe kopieren
        private void btnGetMeasure_Click(object sender, EventArgs e)
        {
            txtRed.Text = txtMeasureRed.Text;
            txtGreen.Text = txtMeasureGreen.Text;
            txtBlue.Text = txtMeasureBlue.Text;
        }

        //Farbpanel aktualisieren und Werte überprüfen
        private void pnlColor_Refresh()//aktuelle Farbe in Panel anzeigen  
        {
            pnlColor.BackColor = Color.FromArgb(Convert.ToInt32(txtRed.Text), Convert.ToInt32(txtGreen.Text), Convert.ToInt32(txtBlue.Text));       
        }
        private void txtRed_TextChanged(object sender, EventArgs e)
        {
            int redValue;
            if (Int32.TryParse(txtRed.Text, out redValue))//Versucht text in Zahl zu konvertieren
            {
                if (redValue > 255)//Wert zu groß
                {
                    txtRed.Text = "255";
                }
                if (redValue < 0)//Wert zu klein
                {
                    txtRed.Text = "0";
                }

                pnlColor_Refresh();
            }
            else
            {
                MessageBox.Show(this, "Aufgrund eines ungültigen Zeichens wird der Wert auf 255 gesetzt!", "Falsche Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRed.Text = "255";
            }
        }
        private void txtGreen_TextChanged(object sender, EventArgs e)
        {
            int greenValue;
            if (Int32.TryParse(txtGreen.Text, out greenValue))//Versucht text in Zahl zu konvertieren
            {
                if (greenValue > 255)//Wert zu groß
                {
                    txtGreen.Text = "255";
                }
                if (greenValue < 0)//Wert zu klein
                {
                    txtGreen.Text = "0";
                }

                pnlColor_Refresh();
            }
            else
            {
                MessageBox.Show(this, "Aufgrund eines ungültigen Zeichens wird der Wert auf 255 gesetzt!", "Falsche Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGreen.Text = "255";
            }
        }
        private void txtBlue_TextChanged(object sender, EventArgs e)
        {
            int blueValue;
            if (Int32.TryParse(txtBlue.Text, out blueValue))//Versucht text in Zahl zu konvertieren
            {
                if (blueValue > 255)//Wert zu groß
                {
                    txtBlue.Text = "255";
                }
                if (blueValue < 0)//Wert zu klein
                {
                    txtBlue.Text = "0";
                }

                pnlColor_Refresh();
            }
            else
            {
                MessageBox.Show(this, "Aufgrund eines ungültigen Zeichens wird der Wert auf 255 gesetzt!", "Falsche Eingabe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBlue.Text = "255";
            }
        }

        //neue Farbe hinzufügen und Form schließen
        private void btnInsertColor_Click(object sender, EventArgs e)
        {
            if (txtColorname.Text != "")//Überprüfen ob ein Farbname gegeben wurde
            {
                if (!colorlist.addColor(txtColorname.Text, pnlColor.BackColor))//Farbe hinzufügen und überprüfen ob Vorgang erfolgreich war
                {
                    //Fehlgeschlagen
                    MessageBox.Show(this, "Die Farbe konnte nicht hinzugefügt werden. Stellen Sie sicher, dass der Farbname und/oder die Farbe nicht bereits vorhanden ist.", "Farbe hinzufügen fehlgeschlagen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Erfolgreich
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(this, "Bitte legen Sie erst einen bisher ungebrauchten Farbnamen fest.", "Kein Farbname!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Form schließen(keine neue Farbe)
        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
