using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MKEmulator
{
    public interface IRecordRepository
    {
        IRecord LoadRecord(string fileName);
        void SaveRecord(IRecord record, string fileName);
    }
}
