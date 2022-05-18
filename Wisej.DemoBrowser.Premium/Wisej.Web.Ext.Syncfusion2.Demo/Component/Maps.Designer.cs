namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Maps
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
            Wisej.Web.Ext.Syncfusion2.ej2Base.WidgetTemplate widgetTemplate1 = new Wisej.Web.Ext.Syncfusion2.ej2Base.WidgetTemplate();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maps));
            this.maps1 = new Wisej.Web.Ext.Syncfusion2.Maps();
            this.button1 = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/maps/es5-getting-started/";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/maps/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.maps1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/maps/default.html";
            // 
            // maps1
            // 
            this.maps1.Dock = Wisej.Web.DockStyle.Fill;
            this.maps1.Location = new System.Drawing.Point(8, 8);
            this.maps1.Name = "maps1";
            this.maps1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"useGroupingSeparator\":true,\"format\":\"n\"}")));
            this.maps1.Size = new System.Drawing.Size(1073, 542);
            this.maps1.TabIndex = 0;
            this.maps1.Text = "maps1";
            widgetTemplate1.Id = "mapTemplate";
            widgetTemplate1.Template = resources.GetString("widgetTemplate1.Template");
            widgetTemplate1.Type = "div";
            this.maps1.WidgetTemplates = new Wisej.Web.Ext.Syncfusion2.ej2Base.WidgetTemplate[] {
        widgetTemplate1};
            // 
            // button1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.button1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.button1, true);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Marker (Chicago)";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Maps
            // 
            this.Name = "Maps";
            this.Load += new System.EventHandler(this.Maps_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Maps maps1;
		private Button button1;
	}
}
