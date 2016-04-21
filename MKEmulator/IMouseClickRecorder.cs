using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MKEmulator
{
    public interface IMouseClickRecorder
    {
        void StartRecording();
        /// <summary>
        /// internally listens to the hook mouse events and manages the mouse subscriptions
        /// </summary>
        void AddMouseClick();
        IRecord StopRecording();
        bool IsRecording();
    }
}
