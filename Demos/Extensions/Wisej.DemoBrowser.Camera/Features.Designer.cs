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
			this.SuspendLayout();
			// 
			// camera1
			// 
			this.camera1.Anchor = Wisej.Web.AnchorStyles.None;
			this.camera1.Location = new System.Drawing.Point(389, 23);
			this.camera1.Name = "camera1";
			this.camera1.Size = new System.Drawing.Size(645, 428);
			this.camera1.TabIndex = 0;
			this.camera1.Text = "camera1";
			// 
			// checkBoxVideo
			// 
			this.checkBoxVideo.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxVideo.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxVideo.AutoSize = false;
			this.checkBoxVideo.Checked = true;
			this.checkBoxVideo.Location = new System.Drawing.Point(47, 155);
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
			this.checkBoxAudio.Location = new System.Drawing.Point(47, 75);
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
			this.comboBoxFacingMode.Location = new System.Drawing.Point(47, 235);
			this.comboBoxFacingMode.Name = "comboBoxFacingMode";
			this.comboBoxFacingMode.Size = new System.Drawing.Size(200, 60);
			this.comboBoxFacingMode.TabIndex = 3;
			this.comboBoxFacingMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacingMode_SelectedIndexChanged);
			// 
			// comboBoxObjectFit
			// 
			this.comboBoxObjectFit.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBoxObjectFit.AutoSize = false;
			this.comboBoxObjectFit.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxObjectFit.Items.AddRange(new object[] {
            "Fill",
            "Container",
            "Cover",
            "ScaleDown",
            "None"});
			this.comboBoxObjectFit.LabelText = "Object Fit";
			this.comboBoxObjectFit.Location = new System.Drawing.Point(47, 340);
			this.comboBoxObjectFit.Name = "comboBoxObjectFit";
			this.comboBoxObjectFit.Size = new System.Drawing.Size(200, 60);
			this.comboBoxObjectFit.TabIndex = 4;
			this.comboBoxObjectFit.SelectedIndexChanged += new System.EventHandler(this.comboBoxObjectFit_SelectedIndexChanged);
			// 
			// Features
			// 
			this.Controls.Add(this.comboBoxObjectFit);
			this.Controls.Add(this.comboBoxFacingMode);
			this.Controls.Add(this.checkBoxAudio);
			this.Controls.Add(this.checkBoxVideo);
			this.Controls.Add(this.camera1);
			this.Name = "Features";
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.Camera.Camera camera1;
		private Web.CheckBox checkBoxVideo;
		private Web.CheckBox checkBoxAudio;
		private Web.ComboBox comboBoxFacingMode;
		private Web.ComboBox comboBoxObjectFit;
	}
}
