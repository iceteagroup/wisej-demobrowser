namespace Wisej.DemoBrowser.Speech
{
    partial class Features
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

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new Wisej.Web.TextBox();
            this.btnPlay = new Wisej.Web.Button();
            this.btnStop = new Wisej.Web.Button();
            this.speechSynthesis = new Wisej.Web.Ext.Speech.SpeechSynthesis();
            this.speechRecognition = new Wisej.Web.Ext.Speech.SpeechRecognition();
            this.btnRecord = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox1.LabelText = "Text to speech";
            this.textBox1.Location = new System.Drawing.Point(424, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 207);
            this.textBox1.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.ImageSource = "resource.wx/Wisej.DemoBrowser.Speech/play.png";
            this.btnPlay.Location = new System.Drawing.Point(896, 300);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(102, 40);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnStop.Enabled = false;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.ImageSource = "resource.wx/Wisej.DemoBrowser.Speech/stop.png";
            this.btnStop.Location = new System.Drawing.Point(896, 228);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(102, 40);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // speechRecognition
            // 
            this.speechRecognition.Language = "en";
            this.speechRecognition.Result += new Wisej.Web.Ext.Speech.SpeechRecognitionEventHandler(this.speechRecognition_Result);
            this.speechRecognition.SpeechStart += new System.EventHandler(this.speechRecognition_SpeechStart);
            this.speechRecognition.SpeechEnd += new System.EventHandler(this.speechRecognition_SpeechEnd);
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecord.ImageSource = "resource.wx/Wisej.DemoBrowser.Speech/record.png";
            this.btnRecord.Location = new System.Drawing.Point(896, 156);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(102, 40);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Record";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(914, 474);
            this.Name = "Features";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.TextBox textBox1;
        private Web.Button btnPlay;
        private Web.Button btnStop;
        private Web.Ext.Speech.SpeechSynthesis speechSynthesis;
        private Web.Ext.Speech.SpeechRecognition speechRecognition;
        private Web.Button btnRecord;
    }
}
