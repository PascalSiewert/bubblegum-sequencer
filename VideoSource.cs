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
        private Bitmap picture;
        public VideoSource()
        {
            
        }

        public Bitmap Picture 
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
                notify();
            }
        }
    }
}
