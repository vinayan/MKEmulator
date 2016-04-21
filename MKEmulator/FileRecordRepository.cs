using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MKEmulator
{
    public class FileRecordRepository : IRecordRepository
    {
        public IRecord LoadRecord(string fileName)
        {
            IRecord rec = null;

            List<KeyCaptureRecord> records = new List<KeyCaptureRecord>();

            string recordedFile = Path.Combine(Path.GetTempPath(), fileName);
            if (File.Exists(recordedFile))
            {
                using (StreamReader reader = new StreamReader(recordedFile))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] splits = line.Split(',');

                        KeyCaptureRecord r = new KeyCaptureRecord();
                        r.X = int.Parse(splits[0]);
                        r.Y = int.Parse(splits[1]);
                        r.DurationSeconds = int.Parse(splits[2]);

                        records.Add(r);
                    }

                    if (records.Count > 0)
                    {
                        rec = new Record(records);
                    }

                }

                //maxTick = this.records.Select(p => p.DurationSeconds).Max();
            }

            return rec;
        }

        public void SaveRecord(IRecord record, string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (KeyCaptureRecord r in record.Items)
                {
                    writer.WriteLine(string.Format("{0},{1},{2}", r.X, r.Y, r.DurationSeconds));
                }
            }
        }
    }
}
