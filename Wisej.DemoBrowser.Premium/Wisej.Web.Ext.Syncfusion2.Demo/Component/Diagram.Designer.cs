namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Diagram
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
            this.diagram1 = new Wisej.Web.Ext.Syncfusion2.Diagram();
            this.buttonExportToPNG = new Wisej.Web.Button();
            this.colorDialog1 = new Wisej.Web.ColorDialog(this.components);
            this.buttonChangeLineColor = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/diagram/es5-getting-started/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/diagram/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.diagram1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonExportToPNG);
            this.flowLayoutPanel1.Controls.Add(this.buttonChangeLineColor);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 46);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 469);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/diagram/default-functionalities.htm" +
    "l";
            // 
            // diagram1
            // 
            this.diagram1.Dock = Wisej.Web.DockStyle.Fill;
            this.diagram1.Location = new System.Drawing.Point(8, 8);
            this.diagram1.Name = "diagram1";
            this.diagram1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"nodes\":[{\"name\":\"Start\",\"offsetX\":300,\"offsetY\":50,\"width\":140,\"height\":50,\"ann" +
        "otations\":[{\"id\":\"label1\",\"content\":\"Start\"}],\"shape\":{\"type\":\"Flow\",\"shape\":\"Te" +
        "rminator\"}}]}")));
            this.diagram1.Size = new System.Drawing.Size(872, 560);
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // buttonExportToPNG
            // 
            this.buttonExportToPNG.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonExportToPNG.Location = new System.Drawing.Point(3, 3);
            this.buttonExportToPNG.Name = "buttonExportToPNG";
            this.buttonExportToPNG.Size = new System.Drawing.Size(212, 27);
            this.buttonExportToPNG.TabIndex = 18;
            this.buttonExportToPNG.Text = "Export to PNG";
            this.buttonExportToPNG.Click += new System.EventHandler(this.buttonExportToPNG_Click);
            // 
            // buttonChangeLineColor
            // 
            this.buttonChangeLineColor.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonChangeLineColor.Location = new System.Drawing.Point(3, 36);
            this.buttonChangeLineColor.Name = "buttonChangeLineColor";
            this.buttonChangeLineColor.Size = new System.Drawing.Size(212, 27);
            this.buttonChangeLineColor.TabIndex = 18;
            this.buttonChangeLineColor.Text = "Change line color";
            this.buttonChangeLineColor.Click += new System.EventHandler(this.buttonChangeLineColor_Click);
            // 
            // Diagram
            // 
            this.Name = "Diagram";
            this.Load += new System.EventHandler(this.Diagram_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.Diagram diagram1;
        private Button buttonExportToPNG;
        private Button buttonChangeLineColor;
        private ColorDialog colorDialog1;
    }
}
