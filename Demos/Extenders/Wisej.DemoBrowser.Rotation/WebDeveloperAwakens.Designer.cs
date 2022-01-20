namespace Wisej.DemoBrowser.Rotation
{
	partial class WebDeveloperAwakens
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebDeveloperAwakens));
			this.rotation1 = new Wisej.Web.Rotation(this.components);
			this.htmlPanel1 = new Wisej.Web.HtmlPanel();
			this.panel1 = new Wisej.Web.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// htmlPanel1
			// 
			this.htmlPanel1.Anchor = Wisej.Web.AnchorStyles.None;
			this.htmlPanel1.Html = resources.GetString("htmlPanel1.Html");
			this.htmlPanel1.Location = new System.Drawing.Point(416, 53);
			this.htmlPanel1.Name = "htmlPanel1";
			this.rotation1.GetRotation(this.htmlPanel1).Perspective = 5;
			this.rotation1.GetRotation(this.htmlPanel1).RotateX = 1;
			this.htmlPanel1.Size = new System.Drawing.Size(591, 369);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.htmlPanel1);
			this.panel1.Dock = Wisej.Web.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1422, 474);
			this.panel1.TabIndex = 4;
			this.panel1.TabStop = true;
			// 
			// WebDeveloperAwakens
			// 
			this.Controls.Add(this.panel1);
			this.Name = "WebDeveloperAwakens";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Web.Rotation rotation1;
		private Web.Panel panel1;
		private Web.HtmlPanel htmlPanel1;
	}
}
