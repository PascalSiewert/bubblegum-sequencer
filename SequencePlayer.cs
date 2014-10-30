using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Midi;

namespace bubblegum_sequencer
{
    class SequencePlayer
    {
        private OutputDevice output;
        private Sequence seq;
        private Thread playerThread;
        private bool isPlaying;

        public SequencePlayer(OutputDevice aDevice, Sequence aSequence)
        {
            output = aDevice;
            seq = aSequence;
            playerThread = new Thread(play);
        }

        private void play()
        {
            isPlaying = true;
            double seconds = 0;

            while (isPlaying)
            {
                if (!output.IsOpen)
                {
                    output.Open();
                }

                for (int i = 0; i < seq.getSize(); i++)
                {
                    seq.getToneByColorIndex(i).play(output);
                       
                    try
                    {
                        seconds = 16 / (double) seq.getBPM() * 15 / 4;
                        Thread.Sleep((int)(seconds * 1000));
                    }
                    catch (ThreadInterruptedException)
                    {
                        isPlaying = false;
                        break;
                    }                   
                    
                    seq.getToneByColorIndex(i).stopSlowly(output);
                }                
            }

            if (output.IsOpen)
            {
                output.Close();
            }
        }

        public void startPlayer()
        {
            if (!playerThread.IsAlive)
            {
                playerThread = new Thread(play);
                playerThread.Start();
            }
            
        }

        public void stopPlayer()
        {
            isPlaying = false;
        }
    }
}
