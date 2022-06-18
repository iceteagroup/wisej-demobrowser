namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igVideoPlayer
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
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.checkBoxAutoHide = new Wisej.Web.CheckBox();
			this.checkBoxAutoPlay = new Wisej.Web.CheckBox();
			this.checkBoxBrowserControls = new Wisej.Web.CheckBox();
			this.checkBoxShowSeekTime = new Wisej.Web.CheckBox();
			this.igVideoPlayer1 = new Wisej.Web.Ext.Ignite.igVideoPlayer();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.TabIndex = 3;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igVideoPlayer1);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/video-player/overview";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igvideoplayer";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igvideoplayer-overview";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBoxAutoHide);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxAutoPlay);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxBrowserControls);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxShowSeekTime);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			// 
			// button1
			// 
			this.flowLayoutPanel1.SetFillWeight(this.button1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.button1, true);
			this.button1.Location = new System.Drawing.Point(3, 231);
			this.button1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(212, 40);
			this.button1.TabIndex = 4;
			this.button1.Text = "Play";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.flowLayoutPanel1.SetFillWeight(this.button2, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.button2, true);
			this.button2.Location = new System.Drawing.Point(3, 290);
			this.button2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(212, 40);
			this.button2.TabIndex = 5;
			this.button2.Text = "Pause";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkBoxAutoHide
			// 
			this.checkBoxAutoHide.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAutoHide.AutoSize = false;
			this.checkBoxAutoHide.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxAutoHide, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxAutoHide, true);
			this.checkBoxAutoHide.Location = new System.Drawing.Point(3, 3);
			this.checkBoxAutoHide.Name = "checkBoxAutoHide";
			this.checkBoxAutoHide.Size = new System.Drawing.Size(212, 38);
			this.checkBoxAutoHide.TabIndex = 0;
			this.checkBoxAutoHide.Text = "Auto Hide";
			// 
			// checkBoxAutoPlay
			// 
			this.checkBoxAutoPlay.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAutoPlay.AutoSize = false;
			this.checkBoxAutoPlay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxAutoPlay, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxAutoPlay, true);
			this.checkBoxAutoPlay.Location = new System.Drawing.Point(3, 60);
			this.checkBoxAutoPlay.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxAutoPlay.Name = "checkBoxAutoPlay";
			this.checkBoxAutoPlay.Size = new System.Drawing.Size(212, 38);
			this.checkBoxAutoPlay.TabIndex = 1;
			this.checkBoxAutoPlay.Text = "Auto Play";
			// 
			// checkBoxBrowserControls
			// 
			this.checkBoxBrowserControls.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxBrowserControls.AutoSize = false;
			this.checkBoxBrowserControls.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxBrowserControls, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxBrowserControls, true);
			this.checkBoxBrowserControls.Location = new System.Drawing.Point(3, 117);
			this.checkBoxBrowserControls.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxBrowserControls.Name = "checkBoxBrowserControls";
			this.checkBoxBrowserControls.Size = new System.Drawing.Size(212, 38);
			this.checkBoxBrowserControls.TabIndex = 2;
			this.checkBoxBrowserControls.Text = "Browser Controls";
			// 
			// checkBoxShowSeekTime
			// 
			this.checkBoxShowSeekTime.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowSeekTime.AutoSize = false;
			this.checkBoxShowSeekTime.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowSeekTime.Checked = true;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxShowSeekTime, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxShowSeekTime, true);
			this.checkBoxShowSeekTime.Location = new System.Drawing.Point(3, 174);
			this.checkBoxShowSeekTime.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxShowSeekTime.Name = "checkBoxShowSeekTime";
			this.checkBoxShowSeekTime.Size = new System.Drawing.Size(212, 38);
			this.checkBoxShowSeekTime.TabIndex = 3;
			this.checkBoxShowSeekTime.Text = "Show Seek Time";
			// 
			// igVideoPlayer1
			// 
			this.igVideoPlayer1.CssStyle = ".ui-igplayer-bookmark-list {\r\n    padding-bottom: 4px;\r\n}";
			this.igVideoPlayer1.Dock = Wisej.Web.DockStyle.Fill;
			this.igVideoPlayer1.Location = new System.Drawing.Point(8, 8);
			this.igVideoPlayer1.Name = "igVideoPlayer1";
			this.igVideoPlayer1.Size = new System.Drawing.Size(872, 560);
			this.igVideoPlayer1.TabIndex = 0;
			this.igVideoPlayer1.WidgetTemplates = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate[0];
			// 
			// igVideoPlayer
			// 
			this.Name = "igVideoPlayer";
			this.Load += new System.EventHandler(this.igVideoPlayer_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igVideoPlayer igVideoPlayer1;
		private Button button2;
		private Button button1;
		private CheckBox checkBoxAutoHide;
		private CheckBox checkBoxShowSeekTime;
		private CheckBox checkBoxBrowserControls;
		private CheckBox checkBoxAutoPlay;
	}
}
