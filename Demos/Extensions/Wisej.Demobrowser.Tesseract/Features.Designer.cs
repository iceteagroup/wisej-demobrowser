namespace Wisej.DemoBrowser.Camera
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
			this.camera1 = new Wisej.Web.Ext.Camera.Camera();
			this.checkBoxVideo = new Wisej.Web.CheckBox();
			this.checkBoxAudio = new Wisej.Web.CheckBox();
			this.comboBoxFacingMode = new Wisej.Web.ComboBox();
			this.comboBoxObjectFit = new Wisej.Web.ComboBox();
			this.panel1 = new Wisej.Web.Panel();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.label1 = new Wisej.Web.Label();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// camera1
			// 
			this.camera1.Anchor = Wisej.Web.AnchorStyles.Top;
			this.flowLayoutPanel1.SetFillWeight(this.camera1, 2);
			this.camera1.Location = new System.Drawing.Point(438, 3);
			this.camera1.MaximumSize = new System.Drawing.Size(700, 0);
			this.camera1.MinimumSize = new System.Drawing.Size(200, 0);
			this.camera1.Name = "camera1";
			this.camera1.Size = new System.Drawing.Size(700, 367);
			this.camera1.TabIndex = 0;
			this.camera1.Text = "camera1";
			// 
			// checkBoxVideo
			// 
			this.checkBoxVideo.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxVideo.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxVideo.AutoSize = false;
			this.checkBoxVideo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxVideo.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxVideo.Location = new System.Drawing.Point(114, 92);
			this.checkBoxVideo.Name = "checkBoxVideo";
			this.checkBoxVideo.Size = new System.Drawing.Size(200, 35);
			this.checkBoxVideo.TabIndex = 1;
			this.checkBoxVideo.Text = "Video";
			this.checkBoxVideo.CheckedChanged += new System.EventHandler(this.checkBoxVideo_CheckedChanged);
			// 
			// checkBoxAudio
			// 
			this.checkBoxAudio.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxAudio.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAudio.AutoSize = false;
			this.checkBoxAudio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAudio.Location = new System.Drawing.Point(114, 12);
			this.checkBoxAudio.Name = "checkBoxAudio";
			this.checkBoxAudio.Size = new System.Drawing.Size(200, 35);
			this.checkBoxAudio.TabIndex = 2;
			this.checkBoxAudio.Text = "Audio";
			this.checkBoxAudio.CheckedChanged += new System.EventHandler(this.checkBoxAudio_CheckedChanged);
			// 
			// comboBoxFacingMode
			// 
			this.comboBoxFacingMode.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBoxFacingMode.AutoSize = false;
			this.comboBoxFacingMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxFacingMode.Items.AddRange(new object[] {
            "User",
            "Environment",
            "Left",
            "Right"});
			this.comboBoxFacingMode.LabelText = "Facing Mode";
			this.comboBoxFacingMode.Location = new System.Drawing.Point(112, 172);
			this.comboBoxFacingMode.Name = "comboBoxFacingMode";
			this.comboBoxFacingMode.Size = new System.Drawing.Size(200, 60);
			this.comboBoxFacingMode.TabIndex = 3;
			this.comboBoxFacingMode.Text = "User";
			this.comboBoxFacingMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacingMode_SelectedIndexChanged);
			// 
			// comboBoxObjectFit
			// 
			this.comboBoxObjectFit.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBoxObjectFit.AutoSize = false;
			this.comboBoxObjectFit.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxObjectFit.Items.AddRange(new object[] {
            "Fill",
            "Contain",
            "Cover",
            "ScaleDown",
            "None"});
			this.comboBoxObjectFit.LabelText = "Object Fit";
			this.comboBoxObjectFit.Location = new System.Drawing.Point(112, 277);
			this.comboBoxObjectFit.Name = "comboBoxObjectFit";
			this.comboBoxObjectFit.Size = new System.Drawing.Size(200, 60);
			this.comboBoxObjectFit.TabIndex = 4;
			this.comboBoxObjectFit.Text = "Contain";
			this.comboBoxObjectFit.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjectFit_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBoxObjectFit);
			this.panel1.Controls.Add(this.comboBoxFacingMode);
			this.panel1.Controls.Add(this.checkBoxAudio);
			this.panel1.Controls.Add(this.checkBoxVideo);
			this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.MaximumSize = new System.Drawing.Size(700, 0);
			this.panel1.MinimumSize = new System.Drawing.Size(300, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(429, 367);
			this.panel1.TabIndex = 5;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.camera1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(141, 49);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1141, 376);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(512, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 18);
			this.label1.TabIndex = 7;
			this.label1.Text = "Tesseract demo coming soon!";
			// 
			// Features
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Features";
			this.panel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Ext.Camera.Camera camera1;
		private Web.CheckBox checkBoxVideo;
		private Web.CheckBox checkBoxAudio;
		private Web.ComboBox comboBoxFacingMode;
		private Web.ComboBox comboBoxObjectFit;
        private Web.Panel panel1;
        private Web.FlowLayoutPanel flowLayoutPanel1;
		private Web.Label label1;
	}
}
