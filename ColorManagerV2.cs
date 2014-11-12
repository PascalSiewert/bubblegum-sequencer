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
    public partial class ColorManagerV2 : Form, IObserver
    {
        ColorList colorlist;
        VideoSource source;//Zwischenspeicher für ColorInsert

        public ColorManagerV2(VideoSource aSource)
        {
            InitializeComponent();
            source = aSource;
        }

        public void update(IObserverable subject)
        {
            colorlist = (ColorList)subject;
            ColorListRefresh();
        }

        private void ColorListRefresh()//Refresh für die ColorList
        {
            lstColors.Items.Clear();
            for (int i = 0; i < colorlist.getCount(); i++)
            {
                lstColors.Items.Add((i + 1).ToString() + ". | " + colorlist.getColorname(i));
            }
        }

        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstColors.SelectedIndex;

            txtColorname.Text = colorlist.getColorname(i);//Ruft Farbnamen des ausgewählten Elements ab

            Color color = colorlist.getColor(i);//Ruft Farbe des ausgewählten Elements ab
            txtRed.Text = color.R.ToString();
            txtGreen.Text = color.G.ToString();
            txtBlue.Text = color.B.ToString();
            pnlColor.BackColor = color;

            //txtReadingcount.Text = colorlist.getReadingcount(i).ToString();//Ruft Messanzahl des ausgewählten Elements ab
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            // Pruefen, ob Kamerabild da ist #Parasixx
            if (source.Source == null)
            {
                MessageBox.Show(this, "Bitte in den Kameraeinstellungen die Kamera auswählen, um die Farbe einzuscannen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ColorInsertALPHA colorinsert = new ColorInsertALPHA();
            colorlist.add(colorinsert);
            source.add(colorinsert);


            colorinsert.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstColors.SelectedIndex >= 0)//Wenn eine Farbe ausgewählt ist...
            {
                int oldSelected = lstColors.SelectedIndex;
                if (colorlist.deleteColorById(lstColors.SelectedIndex))//...diese löschen und die nachgeordnete Farbe auswählen, falls vorhanden
                {
                    if (oldSelected > lstColors.Items.Count - 1)//Wenn es kein nachgeordnete gibt...
                    {
                        lstColors.SelectedIndex = (lstColors.Items.Count - 1);//...letzte aus der Liste auswählen, sonst...
                    }
                    else
                    {
                        lstColors.SelectedIndex = oldSelected;//nachgeordnete Farbe auswählen
                    }
                }
            }
            else//Wenn keine Farbe ausgewählt ist...
            {
                MessageBox.Show(this, "Bitte wählen Sie erst eine zu löschende Farbe aus.", "Keine Farbe ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Error);//...Fehlermeldung
            }
        }   

        private void txtColorname_KeyDown(object sender, KeyEventArgs e)//Ändert Farbname
        {
            if (e.KeyCode == Keys.Return)//Wenn Return gedrückt wurde
            {
                if (lstColors.SelectedIndex >= 0)//Wenn eine Farbe ausgewählt ist
                {
                    bool success;//Gibt an, ob Änderung wirksam ist
                    int oldSelected = lstColors.SelectedIndex;//Speichert die Farbauswahl

                    success = colorlist.changeColorname(lstColors.SelectedIndex, txtColorname.Text);//Versucht Farbname zu ändern

                    if (!success)//Überprüft, ob die Änderung wirksam war
                    {
                        MessageBox.Show(this, "Stellen Sie sicher, dass der Farbname nicht bereits verwendet wurde.", "Farbänderung fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    lstColors.SelectedIndex = oldSelected;//Setzt wieder auf die alte Farbauswahl
                }
            }
        }       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }           
    }
}
