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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igVideoPlayer));
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.igVideoPlayer1 = new Wisej.Web.Ext.Ignite.igVideoPlayer();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Size = new System.Drawing.Size(250, 409);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			this.groupBox1.Controls.SetChildIndex(this.button2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 320);
			this.buttonUpdate.TabIndex = 6;
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igVideoPlayer1);
			this.panel.Size = new System.Drawing.Size(455, 409);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/video-player/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igvideoplayer";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igvideoplayer-overview";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 240);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 4;
			this.button1.Text = "Play";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(28, 280);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(195, 27);
			this.button2.TabIndex = 5;
			this.button2.Text = "Pause";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Auto Hide";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 87);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "AutoPlay";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Location = new System.Drawing.Point(28, 138);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Browser Controls";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox4.Location = new System.Drawing.Point(28, 189);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 38);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Show Seek Time";
			// 
			// igVideoPlayer1
			// 
			this.igVideoPlayer1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igVideoPlayer1.CssStyle = ".ui-igplayer-bookmark-list {\r\n    padding-bottom: 4px;\r\n}";
			this.igVideoPlayer1.Location = new System.Drawing.Point(27, 26);
			this.igVideoPlayer1.Name = "igVideoPlayer1";
			this.igVideoPlayer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igVideoPlayer1.Options"))));
			this.igVideoPlayer1.Size = new System.Drawing.Size(399, 354);
			this.igVideoPlayer1.TabIndex = 0;
			this.igVideoPlayer1.WidgetTemplates = new Wisej.Web.Ext.Ignite.igBase.WidgetTemplate[0];
			// 
			// igVideoPlayer
			// 
			this.Name = "igVideoPlayer";
			this.Size = new System.Drawing.Size(864, 599);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igVideoPlayer igVideoPlayer1;
		private Button button2;
		private Button button1;
		private CheckBox checkBox1;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
	}
}
