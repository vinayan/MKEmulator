using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MKEmulator
{
    public class KeyCaptureRecord
    {
        public KeyCaptureRecord()
        {
            this.DurationSeconds = 1;
        }

        //public string Name { get; set; }
        [Browsable(false)]
        //public PressType Type { get; set; }
        //[Browsable(false)]
        public int X { get; set; }
        [Browsable(false)]
        public int Y { get; set; }
        [Browsable(false)]
        //public string KeyCharacter { get; set; }
        public long DurationSeconds { get; set; }
    }
}
