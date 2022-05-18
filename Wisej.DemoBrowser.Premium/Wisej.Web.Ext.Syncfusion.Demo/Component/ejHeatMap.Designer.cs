namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejHeatMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejHeatMap));
            this.ejHeatMap1 = new Wisej.Web.Ext.Syncfusion.ejHeatMap();
            this.ejHeatMapLegend1 = new Wisej.Web.Ext.Syncfusion.ejHeatMapLegend();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/heatmap/overview";
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(538, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/heatmap/celldatabinding";
            // 
            // linkAPI
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "https://help.syncfusion.com/api/js/ejheatmap";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejHeatMap1);
            this.panel.Controls.Add(this.ejHeatMapLegend1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Location = new System.Drawing.Point(16, 35);
            this.flowLayoutPanelProperties.Size = new System.Drawing.Size(218, 437);
            // 
            // ejHeatMap1
            // 
            this.ejHeatMap1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejHeatMap1.Location = new System.Drawing.Point(8, 8);
            this.ejHeatMap1.Name = "ejHeatMap1";
            this.ejHeatMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejHeatMap1.Options"))));
            this.ejHeatMap1.Size = new System.Drawing.Size(1073, 505);
            this.ejHeatMap1.TabIndex = 0;
            this.ejHeatMap1.Text = "ejHeatMap1";
            this.ejHeatMap1.Appear += new System.EventHandler(this.ejHeatMap1_Appear);
            // 
            // ejHeatMapLegend1
            // 
            this.ejHeatMapLegend1.Dock = Wisej.Web.DockStyle.Bottom;
            this.ejHeatMapLegend1.Location = new System.Drawing.Point(8, 513);
            this.ejHeatMapLegend1.Name = "ejHeatMapLegend1";
            this.ejHeatMapLegend1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"colorMappingCollection\":[{\"value\":0,\"color\":\"#8ec8f8\",\"label\":{\"text\":\"0\"}},{\"v" +
        "alue\":100,\"color\":\"#0d47a1\",\"label\":{\"text\":\"100\"}}],\"isResponsive\":true}")));
            this.ejHeatMapLegend1.Size = new System.Drawing.Size(1073, 37);
            this.ejHeatMapLegend1.TabIndex = 1;
            this.ejHeatMapLegend1.Text = "ejHeatMapLegend1";
            // 
            // ejHeatMap
            // 
            this.Name = "ejHeatMap";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejHeatMap ejHeatMap1;
		private ejHeatMapLegend ejHeatMapLegend1;
	}
}
