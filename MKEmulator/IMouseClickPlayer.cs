using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MKEmulator
{
    public interface IMouseClickPlayer
    {
        void Start(IRecord record);
        void Stop();
    }
}
