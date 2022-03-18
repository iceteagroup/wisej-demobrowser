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
            this.diagram1 = new Wisej.Web.Ext.Syncfusion2.Diagram();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/diagram/es5-getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/diagram/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.diagram1);
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
            this.diagram1.Size = new System.Drawing.Size(1073, 542);
            this.diagram1.TabIndex = 0;
            this.diagram1.Text = "diagram1";
            // 
            // Diagram
            // 
            this.Name = "Diagram";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Diagram diagram1;
	}
}
