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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scanner));
			this.barcode1 = new Wisej.Web.Ext.Barcode.Barcode();
			this.panel1 = new Wisej.Web.Panel();
			this.flowLayoutPanelMain = new Wisej.Web.FlowLayoutPanel();
			this.camera1 = new Wisej.Web.Ext.Camera.Camera();
			this.button1 = new Wisej.Web.Button();
			this.label1 = new Wisej.Web.Label();
			this.panel1.SuspendLayout();
			this.flowLayoutPanelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// barcode1
			// 
			this.barcode1.Anchor = Wisej.Web.AnchorStyles.None;
			this.barcode1.BarcodeType = Wisej.Web.Ext.Barcode.BarcodeType.Code_128;
			this.flowLayoutPanelMain.SetFillWeight(this.barcode1, 1);
			this.barcode1.Location = new System.Drawing.Point(503, 3);
			this.barcode1.MinimumSize = new System.Drawing.Size(300, 0);
			this.barcode1.Name = "barcode1";
			this.barcode1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("barcode1.ResponsiveProfiles"))));
			this.barcode1.Size = new System.Drawing.Size(494, 318);
			this.barcode1.TabIndex = 4;
			this.barcode1.Text = "1234567890";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.camera1);
			this.flowLayoutPanelMain.SetFillWeight(this.panel1, 1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.MinimumSize = new System.Drawing.Size(200, 0);
			this.panel1.Name = "panel1";
			this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles"))));
			this.panel1.Size = new System.Drawing.Size(494, 318);
			this.panel1.TabIndex = 7;
			// 
			// flowLayoutPanelMain
			// 
			this.flowLayoutPanelMain.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelMain.AutoScroll = true;
			this.flowLayoutPanelMain.AutoSize = true;
			this.flowLayoutPanelMain.Controls.Add(this.panel1);
			this.flowLayoutPanelMain.Controls.Add(this.barcode1);
			this.flowLayoutPanelMain.Location = new System.Drawing.Point(211, 75);
			this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
			this.flowLayoutPanelMain.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flowLayoutPanelMain.ResponsiveProfiles"))));
			this.flowLayoutPanelMain.Size = new System.Drawing.Size(1000, 324);
			this.flowLayoutPanelMain.TabIndex = 8;
			// 
			// camera1
			// 
			this.camera1.Anchor = Wisej.Web.AnchorStyles.None;
			this.camera1.Location = new System.Drawing.Point(3, 3);
			this.camera1.Name = "camera1";
			this.camera1.Size = new System.Drawing.Size(491, 315);
			this.camera1.TabIndex = 0;
			this.camera1.Text = "camera1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(364, 411);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(245, 21);
			this.button1.TabIndex = 9;
			this.button1.Text = "Click here to manually trigger scan";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(347, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "Point the camera at a barcode to scan it.";
			// 
			// Scanner
			// 
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.flowLayoutPanelMain);
			this.Name = "Scanner";
			this.panel1.ResumeLayout(false);
			this.flowLayoutPanelMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Ext.Barcode.Barcode barcode1;
        private Web.FlowLayoutPanel flowLayoutPanelMain;
        private Web.Panel panel1;
		private Web.Ext.Camera.Camera camera1;
		private Web.Button button1;
		private Web.Label label1;
	}
}
