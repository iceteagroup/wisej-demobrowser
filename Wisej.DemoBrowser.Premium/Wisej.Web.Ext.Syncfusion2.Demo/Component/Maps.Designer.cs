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
			this.buttonAddMarker = new Wisej.Web.Button();
			this.buttonPrint = new Wisej.Web.Button();
			this.numericUpDownLat = new Wisej.Web.NumericUpDown();
			this.numericUpDownLon = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLon)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/maps/es5-getting-started/";
			// 
			// linkApi
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
			this.flowLayoutPanel1.Controls.Add(this.numericUpDownLat);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDownLon);
			this.flowLayoutPanel1.Controls.Add(this.buttonAddMarker);
			this.flowLayoutPanel1.Controls.Add(this.buttonPrint);
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
			this.maps1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"useGroupingSeparator\":true,\"format\":\"n\",\"allowPrint\":true}")));
			this.maps1.Size = new System.Drawing.Size(872, 560);
			this.maps1.TabIndex = 0;
			this.maps1.Text = "maps1";
			widgetTemplate1.Id = "mapTemplate";
			widgetTemplate1.Template = resources.GetString("widgetTemplate1.Template");
			widgetTemplate1.Type = "div";
			this.maps1.WidgetTemplates = new Wisej.Web.Ext.Syncfusion2.ej2Base.WidgetTemplate[] {
        widgetTemplate1};
			// 
			// buttonAddMarker
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonAddMarker, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.buttonAddMarker, true);
			this.buttonAddMarker.Location = new System.Drawing.Point(3, 117);
			this.buttonAddMarker.Name = "buttonAddMarker";
			this.buttonAddMarker.Size = new System.Drawing.Size(212, 35);
			this.buttonAddMarker.TabIndex = 1;
			this.buttonAddMarker.Text = "Add Marker";
			this.buttonAddMarker.Click += new System.EventHandler(this.buttonAddMarker_Click);
			// 
			// buttonPrint
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonPrint, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.buttonPrint, true);
			this.buttonPrint.Location = new System.Drawing.Point(3, 171);
			this.buttonPrint.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(212, 35);
			this.buttonPrint.TabIndex = 2;
			this.buttonPrint.Text = "Print";
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// numericUpDownLat
			// 
			this.numericUpDownLat.DecimalPlaces = 6;
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDownLat, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownLat, true);
			this.numericUpDownLat.LabelText = "Lat";
			this.numericUpDownLat.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownLat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numericUpDownLat.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
			this.numericUpDownLat.Name = "numericUpDownLat";
			this.numericUpDownLat.Size = new System.Drawing.Size(212, 51);
			this.numericUpDownLat.TabIndex = 3;
			this.numericUpDownLat.Value = new decimal(new int[] {
            41881832,
            0,
            0,
            393216});
			// 
			// numericUpDownLon
			// 
			this.numericUpDownLon.DecimalPlaces = 6;
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDownLon, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownLon, true);
			this.numericUpDownLon.LabelText = "Lon";
			this.numericUpDownLon.Location = new System.Drawing.Point(3, 60);
			this.numericUpDownLon.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numericUpDownLon.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
			this.numericUpDownLon.Name = "numericUpDownLon";
			this.numericUpDownLon.Size = new System.Drawing.Size(212, 51);
			this.numericUpDownLon.TabIndex = 4;
			this.numericUpDownLon.Value = new decimal(new int[] {
            87623177,
            0,
            0,
            -2147090432});
			// 
			// Maps
			// 
			this.Name = "Maps";
			this.Load += new System.EventHandler(this.Maps_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.Maps maps1;
		private Button buttonAddMarker;
        private Button buttonPrint;
        private NumericUpDown numericUpDownLat;
        private NumericUpDown numericUpDownLon;
    }
}
