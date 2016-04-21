using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;


namespace MKEmulator
{
    public class MouseClickPlayer : IMouseClickPlayer
    {
        private Timer t;
        private int tick = 0;
        private IRecord record = null;

        public void Start(IRecord record)
        {
            this.record = record;

            t = new Timer();
            t.Interval = 1000;
            t.Start();
            t.Elapsed += t_Elapsed;
        }

        void t_Elapsed(object sender, ElapsedEventArgs e)
        {
            tick++;

            if (tick > this.record.MaxSecond)
            {
                tick = 0;
                System.Diagnostics.Debug.Print("timer stopped..");
            }

            KeyCaptureRecord r = this.record.Items.Where(p => p.DurationSeconds == tick).FirstOrDefault();
            if (r == null) return;

            MouseOperations.SetCursorPosition(r.X, r.Y);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftDown);
            MouseOperations.MouseEvent(MouseOperations.MouseEventFlags.LeftUp);
        }

        public void Stop()
        {
            this.t.Stop();
        }
    }
}
