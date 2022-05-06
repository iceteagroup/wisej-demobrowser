namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoMediaPlayer
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
            this.kendoMediaPlayer1 = new Wisej.Web.Ext.Kendo.kendoMediaPlayer();
            this.numericUpDownVolume = new Wisej.Web.NumericUpDown();
            this.checkBoxMute = new Wisej.Web.CheckBox();
            this.buttonPlay = new Wisej.Web.Button();
            this.buttonPause = new Wisej.Web.Button();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoMediaPlayer1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/mediaplayer/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/mediaplayer";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/media/mediaplayer/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxMute);
            this.flowLayoutPanelProperties.Controls.Add(this.numericUpDownVolume);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonPlay);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonPause);
            // 
            // kendoMediaPlayer1
            // 
            this.kendoMediaPlayer1.Dock = Wisej.Web.DockStyle.Fill;
            this.kendoMediaPlayer1.Location = new System.Drawing.Point(8, 8);
            this.kendoMediaPlayer1.Name = "kendoMediaPlayer1";
            this.kendoMediaPlayer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"autoPlay\":false,\"navigatable\":true,\"media\":{\"title\":\"Hello, World!\",\"source\":\"h" +
        "ttps://www.youtube.com/watch?v=BfA_wIqjF_8\"}}")));
            this.kendoMediaPlayer1.Size = new System.Drawing.Size(1073, 542);
            this.kendoMediaPlayer1.TabIndex = 0;
            this.kendoMediaPlayer1.Text = "kendoMediaPlayer1";
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.numericUpDownVolume.LabelText = "Volume";
            this.numericUpDownVolume.Location = new System.Drawing.Point(3, 42);
            this.numericUpDownVolume.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
            this.numericUpDownVolume.Name = "numericUpDownVolume";
            this.numericUpDownVolume.Size = new System.Drawing.Size(212, 57);
            this.numericUpDownVolume.TabIndex = 0;
            // 
            // checkBoxMute
            // 
            this.checkBoxMute.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxMute.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxMute.AutoSize = false;
            this.checkBoxMute.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMute.Location = new System.Drawing.Point(3, 3);
            this.checkBoxMute.Name = "checkBoxMute";
            this.checkBoxMute.Size = new System.Drawing.Size(212, 26);
            this.checkBoxMute.TabIndex = 1;
            this.checkBoxMute.Text = "Mute";
            // 
            // buttonPlay
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.buttonPlay, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.buttonPlay, true);
            this.buttonPlay.Location = new System.Drawing.Point(3, 118);
            this.buttonPlay.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(212, 37);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.buttonPause, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.buttonPause, true);
            this.buttonPause.Location = new System.Drawing.Point(3, 174);
            this.buttonPause.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(212, 37);
            this.buttonPause.TabIndex = 3;
            this.buttonPause.Text = "Pause";
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // kendoMediaPlayer
            // 
            this.MinimumSize = new System.Drawing.Size(885, 522);
            this.Name = "kendoMediaPlayer";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoMediaPlayer kendoMediaPlayer1;
        private NumericUpDown numericUpDownVolume;
        private CheckBox checkBoxMute;
        private Button buttonPlay;
        private Button buttonPause;
    }
}
