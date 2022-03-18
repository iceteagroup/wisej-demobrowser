namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igShapeChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igShapeChart));
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            this.igShapeChart1 = new Wisej.Web.Ext.Ignite.igShapeChart();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 421);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 338);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igShapeChart1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/shape-chart/overview";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igSparkline";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igsparkline-landing";
            // 
            // igShapeChart1
            // 
            this.igShapeChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.igShapeChart1.Location = new System.Drawing.Point(31, 20);
            this.igShapeChart1.Name = "igShapeChart1";
            this.igShapeChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igShapeChart1.Options"))));
            this.igShapeChart1.Size = new System.Drawing.Size(1027, 518);
            this.igShapeChart1.TabIndex = 0;
            this.igShapeChart1.Text = "igShapeChart1";
            widgetFunction1.Name = "SetDensityData";
            widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
            widgetFunction2.Name = "SetShapeData";
            widgetFunction2.Source = resources.GetString("widgetFunction2.Source");
            this.igShapeChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1,
        widgetFunction2};
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "auto",
            "point",
            "line",
            "spline",
            "bubble",
            "highDensity",
            "area",
            "contour",
            "polygon",
            "polyline"});
            this.comboBox1.LabelText = "Chart Type";
            this.comboBox1.Location = new System.Drawing.Point(28, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 57);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "point";
            // 
            // comboBox2
            // 
            this.comboBox2.Items.AddRange(new object[] {
            "default",
            "none",
            "horizontal",
            "vertical",
            "both"});
            this.comboBox2.LabelText = "Crosshairs Display Mode";
            this.comboBox2.Location = new System.Drawing.Point(28, 261);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 57);
            this.comboBox2.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Horizontal Zoom";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.checkBox2.Location = new System.Drawing.Point(28, 110);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 38);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Vertical Zoom";
            // 
            // igShapeChart
            // 
            this.Name = "igShapeChart";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Ignite.igShapeChart igShapeChart1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
