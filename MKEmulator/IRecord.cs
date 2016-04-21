using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MKEmulator
{
    public interface IRecord
    {
        List<KeyCaptureRecord> Items { get; set; }
        long MaxSecond { get;  }
    }
}
