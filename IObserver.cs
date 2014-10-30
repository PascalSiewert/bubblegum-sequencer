using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bubblegum_sequencer
{
    public interface IObserver
    {
        void update(IObserverable subject);
    }
}
