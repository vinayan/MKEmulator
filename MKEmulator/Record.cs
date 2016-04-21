using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MKEmulator
{
    public class Record : IRecord
    {
        private List<KeyCaptureRecord> recordedItems = new List<KeyCaptureRecord>();

        public Record(List<KeyCaptureRecord> recordedItems)
        {
            this.recordedItems = recordedItems;
        }

        public List<KeyCaptureRecord> Items
        {
            get
            {
                return recordedItems;
            }
            set
            {
                this.recordedItems = value;
            }
        }


        public long MaxSecond
        {
            get { return this.recordedItems.Select(p => p.DurationSeconds).Max(); }
        }
    }
}
