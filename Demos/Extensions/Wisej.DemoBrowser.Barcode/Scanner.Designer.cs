namespace Wisej.DemoBrowser.Barcode
{
	partial class Scanner
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
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.label1 = new Wisej.Web.Label();
			this.button1 = new Wisej.Web.Button();
			this.camera1 = new Wisej.Web.Ext.Camera.Camera();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.label1);
			this.flexLayoutPanel1.Controls.Add(this.button1);
			this.flexLayoutPanel1.Controls.Add(this.comboBox1);
			this.flexLayoutPanel1.Controls.Add(this.camera1);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(1422, 474);
			this.flexLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1416, 18);
			this.label1.TabIndex = 13;
			this.label1.Text = "Point the camera at a barcode to scan it.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 37);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(1416, 50);
			this.button1.TabIndex = 12;
			this.button1.Text = "Click here to manually trigger scan";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// camera1
			// 
			this.camera1.Anchor = Wisej.Web.AnchorStyles.None;
			this.flexLayoutPanel1.SetFillWeight(this.camera1, 1);
			this.camera1.Location = new System.Drawing.Point(3, 172);
			this.camera1.Name = "camera1";
			this.camera1.Size = new System.Drawing.Size(1416, 299);
			this.camera1.TabIndex = 14;
			this.camera1.Text = "camera1";
			// 
			// comboBox1
			// 
			this.comboBox1.LabelText = "Camera Position";
			this.comboBox1.Location = new System.Drawing.Point(3, 103);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(1416, 53);
			this.comboBox1.TabIndex = 15;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Scanner
			// 
			this.Controls.Add(this.flexLayoutPanel1);
			this.Name = "Scanner";
			this.Load += new System.EventHandler(this.Scanner_Load);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.flexLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.FlexLayoutPanel flexLayoutPanel1;
		private Web.Label label1;
		private Web.Button button1;
		private Web.Ext.Camera.Camera camera1;
		private Web.ComboBox comboBox1;
	}
}
