using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;

namespace bubblegum_sequencer
{
    public class VideoSource : IObserverable 
    {
        private VideoCaptureDevice source;
        public VideoSource()
        {
            
        }       

        public VideoCaptureDevice Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                notify();
            }
        }
    }
}
