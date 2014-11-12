using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Midi;

namespace bubblegum_sequencer
{
    public partial class MainControllerGui : Form, IObserver
    {
        public VideoSource source;
        private ColorList colorList;
        public Grid grid;
        ColorToneMap colorToneMap;

        private OutputDevice output;
        private List<Midi.Message> toneMessages;
        private Sequence sequence;
        private SequencePlayer player;
        private List<Color> nonListedColors = new List<Color>();


        bool colorToneInChange = false;//Gibt an, ob gerade eine andere Kombination ausgewählt wird

        public MainControllerGui()
        {
            InitializeComponent();
            source = new VideoSource();
            grid = new Grid(1, 1);
            colorToneMap = new ColorToneMap();
            toneMessages = new List<Midi.Message>();
            colorList = new ColorList();
            source.add(this);
            grid.add(this);
            colorList.add(this);          

            output = OutputDevice.InstalledDevices[0];
      
            //TEST BEGINN
            /*
            colorToneMap.addColor(new Tone(Pitch.D4, Instrument.AcousticGrandPiano), Color.Black);
            colorToneMap.addColor(new PercussionTone(Percussion.SnareDrum1), Color.Gray);
            colorToneMap.addColor(new Tone(Pitch.A4, Instrument.AcousticGuitarSteel), Color.Blue);
             */
            ColorTone_Refresh();
            //TEST ENDE

            Tones_Refresh();
            sequence = new Sequence(colorToneMap, (int)numBPM.Value);

            player = new SequencePlayer(output, sequence);
        }

        private VideoCaptureDevice videoSource;//Videoquelle/Kamera
        private bool connection = false;//Wird beim ersten Verbindungsaufbau auf true gesetzt

        //EVENTS
        /*
        void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            source.Picture = (Bitmap)eventArgs.Frame.Clone();
            //HIER: Bildanalyse            
        }
         * */


        //GUI
        private void kameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cam Camoptions = new Cam(this, source, grid);
            source.add(Camoptions);

            Camoptions.Show();
        }

        private void farbverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorManagerV2 colorManager = new ColorManagerV2(source);
            colorList.add(colorManager);

            colorManager.Show();
        }

        private void MainControllerGui_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (vspStream.IsRunning)//Stream beenden
            {
                vspStream.SignalToStop();
                vspStream.WaitForStop();
            }
            Environment.Exit(0);//Alle Threads beenden
         }

        public void update(IObserverable subject)
        {
            //HIER: Bildanalyse   

            if (subject is VideoSource)
            {
                if (vspStream.IsRunning)//Beende alten Stream, falls vorhanden
                {
                    vspStream.SignalToStop();
                    vspStream.WaitForStop();
                }

                videoSource = ((VideoSource)subject).Source;//Übernimmt die neue Videoquelle

                if (videoSource != null)
                {
                    //Anpassung der picPicture an die Seitenverhältnisse der Auflösung                
                    double aspectRatio;
                    if (((Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height)) * 316) < 562)
                    {
                        aspectRatio = Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height);//Berechnung mit Double um Nachkommastellen zu beachten
                        vspStream.Width = Convert.ToInt32(aspectRatio * 316);//Berechnet die passende Breite für die picPicture nach dem Seitenverhältnis(aspectRatio)
                    }
                    else
                    {
                        aspectRatio = Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width);//Berechnung mit Double um Nachkommastellen zu beachten
                        vspStream.Height = Convert.ToInt32(aspectRatio * 562);//Berechnet die passende Breite für die picPicture nach dem Seitenverhältnis(aspectRatio)
                    }

                    //Neu Vermessung des Gitters
                    grid.setSize(vspStream.Size);
                    grid.calcIntersections();
                }
                
                //Starte neuen Stream
                vspStream.VideoSource = ((VideoSource)subject).Source;
                vspStream.Start();              
            }


            if (subject is Grid)
            {
                grid = (Grid)subject;
            }

            if (subject is ColorList)
            {
                colorList = (ColorList)subject;
                ColorTone_Refresh();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.startPlayer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.stopPlayer();
        }

        private void numBPM_ValueChanged(object sender, EventArgs e)
        {
            sequence.setBPM((int)numBPM.Value);
        }

        private void btnGetColor_Click(object sender, EventArgs e)
        {
            Color testcolor = grid.getColorAtIntersection(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtY.Text), (Bitmap)vspStream.GetCurrentVideoFrame());

            txtColor.Text = "R:" + testcolor.R.ToString() + "| G:" + testcolor.G.ToString() + "| B:" + testcolor.B.ToString();

            btnGetColor.BackColor = testcolor;
        }

        private void vspStream_NewFrame(object sender, ref Bitmap image)//Wird bei jedem neuen Bild ausgelöst
        {
            if (image != null)
            {
                // Funktion zum einspeichern der abzuspielenden Töne #Pascal
                sequence.addColors(grid, (Bitmap)image);

                // Sequence beim Player aktualisieren #Pascal
                player.setSequence(sequence);
            }
        }

        private void vspStream_Paint(object sender, PaintEventArgs e)//Wird bei jeder neuzeichnung des Players ausgelöst
        {
            if (chkGrid.Checked)
            {
                grid.draw(e.Graphics, vspStream.Size);
            }
        }

        //COLOR-TONE-MAP-CONTROLLER
        private void ColorTone_Refresh()
        {
            int selectedItem = lstColorTone.SelectedIndex;//Alte Listenauswahl
            lstColorTone.Items.Clear();//Löscht alle Einträge in der ColorTone-Liste
            nonListedColors.RemoveRange(0, nonListedColors.Count);//Löscht alle Einträge in der Liste aller nicht verwendeten Farben


            for (int i = 0; i < colorToneMap.getSize(); i++)//Alle Farben die einen Ton haben
            {
                lstColorTone.Items.Add((i + 1).ToString() + ". | Farbe:" + colorList.getColornameByColor(colorToneMap.getColorByID(i)) + " | Ton:" + (colorToneMap.getToneAt(i)).getInstrumentName() + "(" + (colorToneMap.getToneAt(i)).getPitchName() + ")");
            }

            int number = colorToneMap.getSize() + 1;
            for (int i = 0; i < colorList.getCount(); i++)//Alle Farben die keinen Ton haben
            {
                bool colorInList = false;
                for (int j = 0; j < colorToneMap.getSize(); j++)
                {
                    if (colorList.getColor(i) == colorToneMap.getColorByID(j))
                    {
                        colorInList = true;
                    }
                }
                if (!colorInList)
                {
                    lstColorTone.Items.Add(number.ToString() + ". | Farbe:" + colorList.getColorname(i));
                    nonListedColors.Add(colorList.getColor(i));
                    number++;
                }
            }

            if (selectedItem < lstColorTone.Items.Count)//Wenn es die alte Auswahlposition noch gibt...
            {
                lstColorTone.SelectedIndex = selectedItem;//...auf alte Position, sonst...
            }
            else
            {
                lstColorTone.SelectedIndex = (lstColorTone.Items.Count - 1);//Auf die letzte Auswahlposition der Tabelle
            }
        }
        private void Tones_Refresh()//Tonauswahl initiieren
        {
            cbxInstrument.Items.Add("(Instrument)");
            for (int i = 0; i < Enum.GetNames(typeof(Instrument)).Length; i++)
            {
                cbxInstrument.Items.Add(Enum.GetNames(typeof(Instrument))[i]);
            }
            for (int i = 0; i < Enum.GetNames(typeof(Pitch)).Length; i++)
            {
                cbxPitch.Items.Add(Enum.GetNames(typeof(Pitch))[i]);
            }
            cbxInstrument.SelectedIndex = 0;
            cbxPitch.SelectedIndex = -1;
        }
        private void lstColorTone_SelectedIndexChanged(object sender, EventArgs e)//Auswahländerung in der ColorTone-Liste
        {
            colorToneInChange = true;
            if (lstColorTone.SelectedIndex < (colorToneMap.getSize()))
            {
                string instrument = colorToneMap.getToneAt(lstColorTone.SelectedIndex).getInstrumentName();
                string pitch = colorToneMap.getToneAt(lstColorTone.SelectedIndex).getPitchName();
                for (int i = 0; i < Enum.GetNames(typeof(Instrument)).Length; i++)
                {
                    if (Enum.GetNames(typeof(Instrument))[i] == instrument)
                    {
                        cbxInstrument.SelectedIndex = i + 1;
                        break;
                    }
                }
                for (int i = 0; i < Enum.GetNames(typeof(Pitch)).Length; i++)
                {
                    if (Enum.GetNames(typeof(Pitch))[i] == pitch)
                    {
                        cbxPitch.SelectedIndex = i;
                        break;
                    }
                }
            }
            else
            {
                cbxInstrument.SelectedIndex = 0;
                cbxPitch.SelectedIndex = -1;
            }
            colorToneInChange = false;
        }        
        private void cbxInstrument_SelectedIndexChanged(object sender, EventArgs e)//Auswahländerung in der Instrumentliste
        {
            if (cbxInstrument.SelectedIndex == 0)//Es gibt nur ein Pitch, wenn ein Instrument ausgewählt wurde
            {
                cbxPitch.SelectedIndex = -1;
                cbxPitch.Enabled = false;
            }
            else
            {
                cbxPitch.Enabled = true;
                
                if (cbxPitch.SelectedIndex == -1)//Wenn vorher kein Element ausgewählt war
                {
                    cbxPitch.SelectedIndex = 0;
                }
            }
            if (!colorToneInChange)//Nicht ausführen, wenn gerade ein anderes Element in der ColorTone-Liste ausgewählt wird/wurde
            {
                newTone();
            }
        }
        private void cbxPitch_SelectedIndexChanged(object sender, EventArgs e)//Auswahländerung in der Pitchliste
        {
            if (!colorToneInChange && lstColorTone.SelectedIndex < colorToneMap.getSize())//Nicht ausführen, wenn gerade ein anderes Element in der ColorTone-Liste ausgewählt wird/wurde
            {
                newTone();
            }
        }
        private void newTone()//Wenn ein neuer Ton ausgewählt wurde
        {
            if (cbxInstrument.SelectedIndex != 0)
            {
                if (lstColorTone.SelectedIndex < colorToneMap.getSize() && lstColorTone.SelectedIndex != -1)
                {
                    colorToneMap.modifyToneByID(lstColorTone.SelectedIndex, new Tone((Pitch)(cbxPitch.SelectedIndex), (Instrument)(cbxInstrument.SelectedIndex - 1)));
                }
                else
                {
                    colorToneMap.addColor(new Tone((Pitch)(cbxPitch.SelectedIndex), (Instrument)(cbxInstrument.SelectedIndex - 1)), nonListedColors[(lstColorTone.Items.Count - colorToneMap.getSize()) - 1]);
                }
                // Sequence mit der neuen ColorToneMap aktualisieren
                sequence.setColorToneMap(colorToneMap);
            }
            else
            {
                colorToneMap.deleteColorToneByID(lstColorTone.SelectedIndex);
            }

            ColorTone_Refresh();
        }       
    }
}
