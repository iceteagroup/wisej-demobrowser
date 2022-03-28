namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejMediaPlayer));
            this.ejMediaPlayer1 = new Wisej.Web.Ext.Syncfusion.ejMediaPlayer();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.buttonPlay = new Wisej.Web.Button();
            this.buttonPause = new Wisej.Web.Button();
            this.buttonFullScreen = new Wisej.Web.Button();
            this.buttonNext = new Wisej.Web.Button();
            this.buttonReset = new Wisej.Web.Button();
            this.buttonMute = new Wisej.Web.Button();
            this.comboBoxRenderMode = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/mediaplayer/overview";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(619, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/mediaplayer/DefaultFunctionaliti" +
    "es";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejmediaplayer";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejMediaPlayer1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxRenderMode);
            // 
            // ejMediaPlayer1
            // 
            this.ejMediaPlayer1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejMediaPlayer1.Location = new System.Drawing.Point(8, 8);
            this.ejMediaPlayer1.Name = "ejMediaPlayer1";
            this.ejMediaPlayer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejMediaPlayer1.Options"))));
            this.ejMediaPlayer1.Size = new System.Drawing.Size(1073, 542);
            this.ejMediaPlayer1.TabIndex = 0;
            this.ejMediaPlayer1.Text = "ejMediaPlayer1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = Wisej.Web.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.buttonPlay);
            this.flowLayoutPanel1.Controls.Add(this.buttonPause);
            this.flowLayoutPanel1.Controls.Add(this.buttonFullScreen);
            this.flowLayoutPanel1.Controls.Add(this.buttonNext);
            this.flowLayoutPanel1.Controls.Add(this.buttonReset);
            this.flowLayoutPanel1.Controls.Add(this.buttonMute);
            this.flowLayoutPanelProperties.SetFillWeight(this.flowLayoutPanel1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.flowLayoutPanel1, true);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 96);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Display = Wisej.Web.Display.Icon;
            this.flowLayoutPanel1.SetFillWeight(this.buttonPlay, 1);
            this.buttonPlay.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-arrow.svg";
            this.buttonPlay.Location = new System.Drawing.Point(3, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(64, 42);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Display = Wisej.Web.Display.Icon;
            this.flowLayoutPanel1.SetFillWeight(this.buttonPause, 1);
            this.buttonPause.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/pause-button.svg";
            this.buttonPause.Location = new System.Drawing.Point(73, 3);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(65, 42);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonFullScreen
            // 
            this.buttonFullScreen.Display = Wisej.Web.Display.Icon;
            this.flowLayoutPanel1.SetFillWeight(this.buttonFullScreen, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.buttonFullScreen, true);
            this.buttonFullScreen.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/show-more-button.svg";
            this.buttonFullScreen.Location = new System.Drawing.Point(144, 3);
            this.buttonFullScreen.Name = "buttonFullScreen";
            this.buttonFullScreen.Size = new System.Drawing.Size(65, 42);
            this.buttonFullScreen.TabIndex = 4;
            this.buttonFullScreen.Click += new System.EventHandler(this.buttonFullScreen_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Display = Wisej.Web.Display.Icon;
            this.flowLayoutPanel1.SetFillWeight(this.buttonNext, 1);
            this.buttonNext.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-next-button.svg";
            this.buttonNext.Location = new System.Drawing.Point(3, 51);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(64, 42);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Display = Wisej.Web.Display.Icon;
            this.flowLayoutPanel1.SetFillWeight(this.buttonReset, 1);
            this.buttonReset.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/back-arrow.svg";
            this.buttonReset.Location = new System.Drawing.Point(73, 51);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(65, 42);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.Display = Wisej.Web.Display.Icon;
            this.flowLayoutPanel1.SetFillWeight(this.buttonMute, 1);
            this.buttonMute.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/volume-muted.svg";
            this.buttonMute.Location = new System.Drawing.Point(144, 51);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(65, 42);
            this.buttonMute.TabIndex = 5;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // comboBoxRenderMode
            // 
            this.comboBoxRenderMode.AutoSize = false;
            this.comboBoxRenderMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanelProperties.SetFillWeight(this.comboBoxRenderMode, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.comboBoxRenderMode, true);
            this.comboBoxRenderMode.Items.AddRange(new object[] {
            "Basic",
            "Advanced",
            "Mobile"});
            this.comboBoxRenderMode.Label.Size = 50;
            this.comboBoxRenderMode.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBoxRenderMode.LabelText = "Render Mode";
            this.comboBoxRenderMode.Location = new System.Drawing.Point(3, 118);
            this.comboBoxRenderMode.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxRenderMode.Name = "comboBoxRenderMode";
            this.comboBoxRenderMode.Size = new System.Drawing.Size(212, 60);
            this.comboBoxRenderMode.TabIndex = 1;
            this.comboBoxRenderMode.Text = "Basic";
            // 
            // ejMediaPlayer
            // 
            this.Name = "ejMediaPlayer";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejMediaPlayer ejMediaPlayer1;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button buttonPlay;
		private Button buttonPause;
		private Button buttonFullScreen;
		private Button buttonNext;
		private Button buttonReset;
		private Button buttonMute;
		private ComboBox comboBoxRenderMode;
	}
}
