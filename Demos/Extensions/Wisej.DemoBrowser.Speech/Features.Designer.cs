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
            this.comboBoxLanguage = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox1.LabelText = "Text to Speech";
            this.textBox1.Location = new System.Drawing.Point(493, 104);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 207);
            this.textBox1.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlay.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-rounded-button.svg";
            this.btnPlay.Location = new System.Drawing.Point(604, 332);
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
            this.btnStop.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/rounded-pause-button.svg";
            this.btnStop.Location = new System.Drawing.Point(715, 332);
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
            this.btnRecord.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/record-voice-microphone-button.svg";
            this.btnRecord.Location = new System.Drawing.Point(826, 332);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(102, 40);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Record";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxLanguage.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "en-US",
            "de-DE",
            "it-IT",
            "es-ES"});
            this.comboBoxLanguage.LabelText = "Language";
            this.comboBoxLanguage.Location = new System.Drawing.Point(493, 317);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(102, 53);
            this.comboBoxLanguage.TabIndex = 4;
            this.comboBoxLanguage.Text = "en-US";
            // 
            // Features
            // 
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.textBox1);
            this.MinimumSize = new System.Drawing.Size(449, 281);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
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
        private Web.ComboBox comboBoxLanguage;
    }
}
