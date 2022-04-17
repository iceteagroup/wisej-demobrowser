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
    }
}
