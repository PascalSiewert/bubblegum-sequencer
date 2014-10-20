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
    public partial class MainControllerGui : Form, IObserver
    {
        public VideoSource source;
        private ColorList colorList;

        public MainControllerGui()
        {
            InitializeComponent();
            source = new VideoSource();
            colorList = new ColorList();
            source.add(this);
        }

        private VideoCaptureDevice videoSource;//Videoquelle/Kamera
        private bool connection = false;//Wird beim ersten Verbindungsaufbau auf true gesetzt

        public void stream_start(VideoCaptureDevice aVideoSource)
        {
            videoSource = aVideoSource;//Übernimmt neue Videoquelle

            //Anpassung der picPicture an die Seitenverhältnisse der Auflösung
            if (videoSource != null)
            {
                double aspectRatio;
                if (((Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height)) * 316) < 562)
                {
                    aspectRatio = Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height);//Berechnung mit Double um Nachkommastellen zu beachten
                    picPicture.Width = Convert.ToInt32(aspectRatio * 316);//Berechnet die passende Breite für die picPicture nach dem Seitenverhältnis(aspectRatio)
                }
                else
                {
                    aspectRatio = Convert.ToDouble(videoSource.VideoResolution.FrameSize.Height) / Convert.ToDouble(videoSource.VideoResolution.FrameSize.Width);//Berechnung mit Double um Nachkommastellen zu beachten
                    picPicture.Height = Convert.ToInt32(aspectRatio * 562);//Berechnet die passende Breite für die picPicture nach dem Seitenverhältnis(aspectRatio)
                }

                if (!connection)
                {
                    videoSource.NewFrame += new AForge.Video.NewFrameEventHandler(videoSource_NewFrame);//Verknüpft Videoquelle mit Event
                    videoSource.Start();//Startet Videoquelle
                    connection = true;
                }
            }
        }//startet Stream

        //EVENTS
        void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            source.Picture = (Bitmap)eventArgs.Frame.Clone();

            //HIER: Bildanalyse            
        }


        //GUI
        private void kameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cam Camoptions = new Cam(this, videoSource, source);
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
            if (videoSource != null && videoSource.IsRunning)//Webcam als Source wieder ausbinden
            {
                this.videoSource.SignalToStop();
                this.videoSource = null;
            }
            Environment.Exit(0);//Alle Threads beenden
        }

        public void update(IObserverable subject)
        {
            //HIER: Bildanalyse   
            try
            {
                picPicture.BackgroundImage = ((VideoSource)subject).Picture;
            }
            catch { }
        }
    }
}
