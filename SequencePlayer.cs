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

        public SequencePlayer(OutputDevice aDevice, Sequence aSequence)
        {
            output = aDevice;
            seq = aSequence;
            playerThread = new Thread(play);
        }

        private void play()
        {
            bool play = true;
            double seconds = 0;
            int waitMilliseconds = 1000;

            while (play)
            {
                if (!output.IsOpen)
                {
                    output.Open();
                }

                for (int i = 0; i < seq.getSize(); i++)
                {
                    seq.getToneByColor(i).play(output);
                    new Tone(Pitch.B5, Instrument.AcousticBass).play(output);
                    try
                    {
                        seconds = 16 / (double) seq.getBPM() * 15 / 4;
                        Thread.Sleep((int)(seconds * 1000));
                    }
                    catch (ThreadInterruptedException ex)
                    {
                        play = false;
                        break;
                    }

                    seq.getToneByColor(i).stopSlowly(output);
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
            playerThread.Interrupt();
        }
    }
}
