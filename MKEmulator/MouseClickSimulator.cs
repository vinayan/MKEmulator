using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
using WindowsInput;
using WindowsInput.Native;

namespace MKEmulator
{
    public partial class MouseClickSimulator : Form
    {

        IMouseClickRecorder recorder = new MouseClickRecorder();
        IMouseClickPlayer player = new MouseClickPlayer();
        IRecordRepository recordRepository = new FileRecordRepository();

        private IRecord activeRecord = null;

        public MouseClickSimulator()
        {
            InitializeComponent();
        }


        private void btnMouseEntry_Click(object sender, EventArgs e)
        {
            if (this.recorder.IsRecording())
            {
                this.recorder.AddMouseClick();
                //SubscribeMouse();
            }
        }

        private void btnStartRecord_Click(object sender, EventArgs e)
        {
            this.recorder.StartRecording();

            btnMouseEntry.Enabled = true;
            btnStartRecord.Enabled = false;
            btnStopRecord.Enabled = true;
        }

        private void btnStopRecord_Click(object sender, EventArgs e)
        {
            btnStopRecord.Enabled = false;
            btnStartRecord.Enabled = true;
            btnMouseEntry.Enabled = false;

            IRecord record = this.recorder.StopRecording();

            if (record != null)
            {
                this.recordRepository.SaveRecord(record, Path.Combine(Path.GetTempPath(), "mkrecording"));
            }
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                this.activeRecord = this.recordRepository.LoadRecord("mkrecording");

                if (this.activeRecord != null)
                {
                    this.player.Start(this.activeRecord);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStopPlayback_Click(object sender, EventArgs e)
        {
            this.player.Stop();
        }

        private void MouseClickSimulator_Load(object sender, EventArgs e)
        {
            btnMouseEntry.Enabled = false;
            btnStopRecord.Enabled = false;
        }
    }
}
