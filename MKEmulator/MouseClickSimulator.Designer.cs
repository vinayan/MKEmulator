namespace MKEmulator
{
    partial class MouseClickSimulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseClickSimulator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStartRecord = new System.Windows.Forms.Button();
            this.btnStopRecord = new System.Windows.Forms.Button();
            this.btnMouseEntry = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStopPlayback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStartRecord);
            this.groupBox1.Controls.Add(this.btnStopRecord);
            this.groupBox1.Controls.Add(this.btnMouseEntry);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record New";
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.BackgroundImage = global::MKEmulator.Properties.Resources.Record;
            this.btnStartRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartRecord.Location = new System.Drawing.Point(14, 20);
            this.btnStartRecord.Name = "btnStartRecord";
            this.btnStartRecord.Size = new System.Drawing.Size(40, 39);
            this.btnStartRecord.TabIndex = 5;
            this.btnStartRecord.UseVisualStyleBackColor = true;
            this.btnStartRecord.Click += new System.EventHandler(this.btnStartRecord_Click);
            // 
            // btnStopRecord
            // 
            this.btnStopRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopRecord.BackgroundImage")));
            this.btnStopRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStopRecord.Location = new System.Drawing.Point(72, 20);
            this.btnStopRecord.Name = "btnStopRecord";
            this.btnStopRecord.Size = new System.Drawing.Size(40, 39);
            this.btnStopRecord.TabIndex = 6;
            this.btnStopRecord.UseVisualStyleBackColor = true;
            this.btnStopRecord.Click += new System.EventHandler(this.btnStopRecord_Click);
            // 
            // btnMouseEntry
            // 
            this.btnMouseEntry.BackgroundImage = global::MKEmulator.Properties.Resources.mouse;
            this.btnMouseEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMouseEntry.Location = new System.Drawing.Point(127, 20);
            this.btnMouseEntry.Name = "btnMouseEntry";
            this.btnMouseEntry.Size = new System.Drawing.Size(40, 39);
            this.btnMouseEntry.TabIndex = 2;
            this.btnMouseEntry.UseVisualStyleBackColor = true;
            this.btnMouseEntry.Click += new System.EventHandler(this.btnMouseEntry_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::MKEmulator.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(139, 89);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 39);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStopPlayback
            // 
            this.btnStopPlayback.Location = new System.Drawing.Point(26, 93);
            this.btnStopPlayback.Name = "btnStopPlayback";
            this.btnStopPlayback.Size = new System.Drawing.Size(75, 35);
            this.btnStopPlayback.TabIndex = 10;
            this.btnStopPlayback.Text = "Stop";
            this.btnStopPlayback.UseVisualStyleBackColor = true;
            this.btnStopPlayback.Click += new System.EventHandler(this.btnStopPlayback_Click);
            // 
            // MouseClickSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 137);
            this.Controls.Add(this.btnStopPlayback);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MouseClickSimulator";
            this.Text = "MK Emulator";
            this.Load += new System.EventHandler(this.MouseClickSimulator_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMouseEntry;
        private System.Windows.Forms.Button btnStartRecord;
        private System.Windows.Forms.Button btnStopRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStopPlayback;
    }
}

