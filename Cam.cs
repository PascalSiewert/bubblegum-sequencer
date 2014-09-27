﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace bubblegum_sequencer
{
    public partial class Cam : Form
    {
        private MainControllerGui mainController;
        VideoCaptureDevice videoSource;//Videoquelle/Kamera

        public Cam(MainControllerGui form, VideoCaptureDevice aVideoSource)
        {
            InitializeComponent();

            mainController = form;

            videoSource = aVideoSource;
        }

        FilterInfoCollection videosources;//Kameraliste
        Bitmap picture;//Aktuelles Bild/aktueller Frame
        bool connection = false;//Gibt an, ob bereits eine Verbindung gestartet wurde

        //EVENTS
        private void Cam_Load(object sender, EventArgs e)
        {
            videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo source in videosources)//Lädt alle verügbaren Kameras in cbxCam
            {
                cbxCam.Items.Add(source.Name);
            }

            if (videoSource.Source != null)//Falls bereits eine Kamera ausgewählt wurde, wird diese hier geladen
            {
                connection = true;
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

        //FUNCTIONS
        void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            picture = (Bitmap)eventArgs.Frame.Clone();

            //HIER: Bildanalyse

            picPicture.BackgroundImage = picture;
        }

        //GUI
        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

            if (selectedItem != "keine Auflösungen verfügbar!")//Auflösung festlegen
            {
                videoSource.VideoResolution = videoSource.VideoCapabilities[cbxResolution.SelectedIndex];//Ausgewählte Auflösung übernehmen

                if (((Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height)) * 230) < 410)
                {
                    aspectRatio = Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height);//Berechnung mit Double um Nachkommastellen zu beachten
                    picPicture.Width = Convert.ToInt32(aspectRatio * 230);//Berechnet die passende Breite für die picPicture nach dem Seitenverhältnis(aspectRatio)
                }
                else
                {
                    aspectRatio = Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width);//Berechnung mit Double um Nachkommastellen zu beachten
                    picPicture.Height = Convert.ToInt32(aspectRatio * 410);//Berechnet die passende Breite für die picPicture nach dem Seitenverhältnis(aspectRatio)
                }
            }

            //Video starten
            if (!connection)
            {
                videoSource.NewFrame += new AForge.Video.NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
            }
        }

        private void Cam_FormClosed(object sender, FormClosedEventArgs e)
        {
            /* WIRD NUR NOCH BEI KOMPLETTER PROGRAMM BEENDUNG GESCHLOSSEN
            if (videoSource != null && videoSource.IsRunning)//Webcam als Source wieder ausbinden
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
             * */
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            if (cbxCam.SelectedItem.ToString() != "")//Nur wenn eine Kamera ausgewählt wurde
            {
                mainController.stream_start(videoSource);

                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie erst eine Kamera aus!", "keine Kamera ausgewählt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }       
    }
}
