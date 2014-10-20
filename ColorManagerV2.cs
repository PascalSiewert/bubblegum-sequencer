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
            for (int i = 0; i < colorlist.Count(); i++)
            { 
                lstColors.Items.Add((i+1).ToString() + colorlist.getColorName(i));
            }
        }

        private void lstColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstColors.SelectedIndex;

            txtColorName.Text = colorlist.getColorName(i);//Ruft Farbnamen des ausgewählten Elements ab

            Color color = colorlist.getColor(i);//Ruft Farbe des ausgewählten Elements ab
            txtColor.Text = "R:" + color.R.ToString() +
                ";G:" + color.G.ToString() +
                ";B:" + color.B.ToString();

            txtReadingcount.Text = colorlist.getReadingcount(i).ToString();//Ruft Messanzahl des ausgewählten Elements ab
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            ColorInsert colorinsert = new ColorInsert();
            colorlist.add(colorinsert);
            source.add(colorinsert);


            colorinsert.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
