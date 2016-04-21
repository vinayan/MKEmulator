using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Gma.System.MouseKeyHook;

namespace MKEmulator
{
    public class MouseClickRecorder : IMouseClickRecorder
    {
        private Stopwatch stopWatch = new Stopwatch();
        private bool isRecording = false;
        private IKeyboardMouseEvents m_GlobalHook;
        private int counter = 0;
        private List<KeyCaptureRecord> records = new List<KeyCaptureRecord>();

        public void StartRecording()
        {
            this.isRecording = true;
            stopWatch.Start();
        }

        public void AddMouseClick()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseDownExt += OnMouseDown;
        }

        void OnMouseDown(object sender, MouseEventExtArgs e)
        {
            m_GlobalHook.MouseDownExt -= OnMouseDown;
            //It is recommened to dispose it
            m_GlobalHook.Dispose();
 
            counter++;

            KeyCaptureRecord mouseRecord = new KeyCaptureRecord()
            {
                DurationSeconds = stopWatch.ElapsedMilliseconds / 1000,
                X = e.X,
                Y = e.Y
            };

            this.records.Add(mouseRecord);
        }

        public IRecord StopRecording()
        {
            IRecord rec = null;
            if (records.Count > 0)
            {
                rec = new Record(this.records);
            }

            return rec;
        }

        public bool IsRecording()
        {
            return this.isRecording;
        }
    }
}
