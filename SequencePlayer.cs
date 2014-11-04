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
        private Clock clock;
        private List<Message> toneMessages = new List<Message>();
        private int beats;

        public SequencePlayer(OutputDevice aDevice, Sequence aSequence)
        {
            output = aDevice;
            seq = aSequence;
            playerThread = new Thread(play);
            clock = new Clock(seq.getBPM());
        }

        private void play()
        {            
            isPlaying = true;

            if (!output.IsOpen)
            {
                output.Open();
            }            

            while (isPlaying)
            {
                clock.BeatsPerMinute = seq.getBPM();
                clock.Schedule(toneMessages, 0);
                clock.Start();
                Thread.Sleep((int)((16.0 / clock.BeatsPerMinute * 15000.0) / 4.0 * beats));
                output.SilenceAllNotes();
                clock.Stop();
                clock.Reset();
            }

            if (output.IsOpen)
            {
                output.Close();
            }
        }

        private void processSequence()
        {
            beats = 0;
            toneMessages.Clear();
            for (int i = 0; i < seq.getColSize(); i++)
            {
                for (int j = 0; j < seq.getRowSize(i); j++)
                {
                    Tone curTone = seq.getToneByColorIndex(i, j);
                    PercussionTone pTone = null;

                    if (curTone == null)
                    {
                        continue;
                    }

                    if (curTone is PercussionTone)
                    {
                        pTone = (PercussionTone)curTone;
                        toneMessages.Add(new PercussionMessage(output, pTone.getPercussionInstrument(), 80, i));
                        continue;
                    }

                    toneMessages.Add(new ProgramChangeMessage(output, Channel.Channel1, curTone.getInstrument(), i));
                    toneMessages.Add(new NoteOnMessage(output, Channel.Channel1, curTone.getPitch(), 80, i));
                    toneMessages.Add(new NoteOffMessage(output, Channel.Channel1, curTone.getPitch(), 80, i + 1));
                }
                beats++;
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

        public void setSequence(Sequence value)
        {
            seq = value;
            processSequence();
        }
    }
}
