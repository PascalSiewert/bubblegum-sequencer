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
using AForge;
using AForge.Controls;
using AForge.Imaging;

namespace bubblegum_sequencer
{
    public partial class Cam : Form, IObserver
    {
        //GLOBALE VARIABLEN(FORMINTERN)
        private MainControllerGui mainController;
        VideoCaptureDevice videoSource;//Videoquelle/Kamera
        VideoSource source;
        public Grid grid;
        FilterInfoCollection videosources;//Kameraliste

        //FORM INITIEREN
        public Cam(MainControllerGui form, VideoSource aSource, Grid aGrid)
        {
            InitializeComponent();

            mainController = form;

            /*
            if (aVideoSource != null)//Wenn es bereits eine Videosource gibt, synchronisieren
            {
                videoSource.Source = aVideoSource.Source;
                videoSource.VideoResolution = aVideoSource.VideoResolution;
            }
             */
            source = aSource;//Übergabe des Obeserverable, um von Cam aus Bilder zu verteilen

            videoSource = source.Source;
           
            grid = aGrid;
        }               
        private void Cam_Load(object sender, EventArgs e)
        {
            videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo vsource in videosources)//Lädt alle verügbaren Kameras in cbxCam
            {
                cbxCam.Items.Add(vsource.Name);
            }

            if (videoSource != null)//Falls bereits eine Kamera ausgewählt wurde, wird diese hier geladen
            {
                for (int i = 0; i < videosources.Count; i++)//Sucht die bereits gewählte Kamera in den Sources und wählt diese in cbxCam aus
                {
                    VideoCaptureDevice tempVideoSource = new VideoCaptureDevice(videosources[i].MonikerString);//Zapft Videoquelle kurz an
                    if (videoSource.Source == tempVideoSource.Source)
                    {
                        cbxCam.SelectedIndex = i;
                    }
                    tempVideoSource.SignalToStop();
                    tempVideoSource = null;
                }
            }
        }

        //KAMERA- UND AUFLÖSUNGSAUSWAHL            
        private void cbxCam_SelectedIndexChanged(object sender, EventArgs e)//Wenn eine Kamera ausgewählt wird
        {
            videoSource = new VideoCaptureDevice(videosources[cbxCam.SelectedIndex].MonikerString);//Legt Videoquelle anhand der ausgewählten Kamera aus cbxCam fest

            cbxResolution.Items.Clear();

            try
            {
                if (videoSource.VideoCapabilities.Length > 0)//Versucht Auflösungen der Kamera zu ermitteln, speichter diese in cbxResolution und wählt automatisch die beste als Standard aus
                {
                    int highestSolutionIndex = 0;//Index der höchstmöglichen Auflösung
                    int highestSolution = 0;//Breite der höchstmöglichen Auflösung

                    for (int i = 0; i < videoSource.VideoCapabilities.Length; i++)
                    {
                        cbxResolution.Items.Add(videoSource.VideoCapabilities[i].FrameSize.Width.ToString() + "x" + videoSource.VideoCapabilities[i].FrameSize.Height.ToString());//Auflösung cbxResolution hinzufügen

                        if (videoSource.VideoCapabilities[i].FrameSize.Width > highestSolution)//Wenn es eine höhere Auflösung als die aktuell höchste gibt, dann diese als höchste nehmen
                        {
                            highestSolutionIndex = i;
                            highestSolution = videoSource.VideoCapabilities[i].FrameSize.Width;
                        }
                    }

                    cbxResolution.SelectedIndex = highestSolutionIndex;
                }
                else
                {
                    cbxResolution.Items.Add("keine Auflösungen verfügbar!");
                    cbxResolution.SelectedIndex = 0;
                }

                txtFps.Text = videoSource.VideoResolution.AverageFrameRate.ToString();
            }
            catch { }
        }
        private void cbxResolution_SelectedIndexChanged(object sender, EventArgs e)//Auflösung festlegen und Video starten
        {
            string selectedItem = cbxResolution.SelectedItem.ToString();
            double aspectRatio;

            if (vspStream.IsRunning)//Beende altes Signal, bevor du ein neues ausführst
            {
                vspStream.SignalToStop();
                vspStream.WaitForStop();
            }

            if (selectedItem != "keine Auflösungen verfügbar!")//Auflösung festlegen
            {
                videoSource.VideoResolution = videoSource.VideoCapabilities[cbxResolution.SelectedIndex];//Ausgewählte Auflösung übernehmen

                if (((Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height)) * 230) < 410)
                {
                    aspectRatio = Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height);//Berechnung mit Double um Nachkommastellen zu beachten
                    vspStream.Width = Convert.ToInt32(aspectRatio * 230);//Berechnet die passende Breite für die picPicture nach dem Seitenverhältnis(aspectRatio)
                }
                else
                {
                    aspectRatio = Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width);//Berechnung mit Double um Nachkommastellen zu beachten
                    vspStream.Height = Convert.ToInt32(aspectRatio * 410);//Berechnet die passende Breite für die picPicture nach dem Seitenverhältnis(aspectRatio)
                }
            }

            vspStream.VideoSource = videoSource;
            vspStream.Start();            
        }

        //JUSTIERUNG
        private void btnJustification_Click(object sender, EventArgs e)
        {
            grid.Cols = Convert.ToInt32(txtColumns.Text);
            grid.Rows = Convert.ToInt32(txtRows.Text);
        }

        //OBSERVERPATTERN        
        public void update(IObserverable subject)
        {
            //picPicture.Image = ((VideoSource)subject).Picture;


            //HIER: Bildanalyse
        }
        
        //BEENDEN
        private void btnResume_Click(object sender, EventArgs e)
        {
            if (cbxCam.SelectedItem != null)//Nur wenn eine Kamera ausgewählt wurde
            {
                source.Source = videoSource;

                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie erst eine Kamera aus!", "keine Kamera ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Cam_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (vspStream.IsRunning)//Stream beenden
            {
                vspStream.SignalToStop();
                vspStream.WaitForStop();
            }
        }
    }
}