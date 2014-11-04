using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Midi;

namespace bubblegum_sequencer
{
    class Tone
    {
        private Pitch pitch;
        private Instrument instrument;

        public Tone(Pitch aPitch, Instrument aInstrument)
        {
            pitch = aPitch;
            instrument = aInstrument;
        }

        public virtual void play(OutputDevice oDevice)
        {
            oDevice.SendProgramChange(Channel.Channel1, instrument);
            oDevice.SendNoteOn(Channel.Channel1, pitch, 80);
        }

        public void stopSlowly(OutputDevice oDevice)
        {
            oDevice.SendNoteOff(Channel.Channel1, pitch, 80);
        }

        public Pitch getPitch()
        {
            return pitch;
        }

        public Instrument getInstrument()
        {
            return instrument;
        }

        public String getPitchName()
        {
            return pitch.ToString();
        }

        public String getInstrumentName()
        {
            return instrument.ToString();

        }
    }
}
