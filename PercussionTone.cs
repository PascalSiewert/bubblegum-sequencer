using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Midi;

namespace bubblegum_sequencer
{
    class PercussionTone : Tone
    {
        private Percussion percussion;

        public PercussionTone(Percussion aPercussion)
            : base(Pitch.C0, Instrument.AcousticGrandPiano)
        {
            percussion = aPercussion;

        }

        public override void play(OutputDevice oDevice)
        {
            oDevice.SendPercussion(percussion, 80);
        }

        public Percussion getPercussionInstrument()
        {
            return percussion;
        }
    }
}
