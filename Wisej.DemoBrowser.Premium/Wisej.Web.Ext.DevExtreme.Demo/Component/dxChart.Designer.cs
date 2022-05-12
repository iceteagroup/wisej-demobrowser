namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxChart));
            Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
            this.dxChart1 = new Wisej.Web.Ext.DevExtreme.dxChart();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.buttonLoad = new Wisej.Web.Upload();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.comboBoxChartType = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Chart/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Charts/Overview/jQuery/Light/" +
    "";
            // 
            // linkApi
            // 
            this.linkApi.Size = new System.Drawing.Size(827, 24);
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/d" +
    "xChart/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxChart1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxChartType);
            this.flowLayoutPanel1.Controls.Add(this.buttonLoad);
            // 
            // dxChart1
            // 
            this.dxChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxChart1.Location = new System.Drawing.Point(31, 37);
            this.dxChart1.Name = "dxChart1";
            this.dxChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxChart1.Options"))));
            this.dxChart1.Size = new System.Drawing.Size(826, 503);
            this.dxChart1.TabIndex = 0;
            widgetFunction1.Name = "getDataSourceItems";
            widgetFunction1.Source = "return this.Instance.getDataSource()._items;";
            this.dxChart1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[] {
        widgetFunction1};
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 38);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Adjust on Zoom";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 60);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 38);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Hide Point Markers";
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".json";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(3, 332);
            this.buttonLoad.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 42);
            this.buttonLoad.TabIndex = 5;
            this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 117);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 38);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Drag to Zoom";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "alt",
            "ctrl",
            "meta",
            "shift"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Pan Key";
            this.comboBox1.Location = new System.Drawing.Point(3, 174);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "shift";
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.AutoSize = false;
            this.comboBoxChartType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxChartType, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxChartType, true);
            this.comboBoxChartType.Items.AddRange(new object[] {
            "area  ",
            "bar  ",
            "bubble",
            "candlestick ",
            "fullstackedarea  ",
            "fullstackedbar ",
            "fullstackedline ",
            "fullstackedspline",
            "fullstackedsplinearea",
            "line",
            "rangearea",
            "rangebar  ",
            "scatter  ",
            "spline  ",
            "splinearea  ",
            "stackedarea ",
            "stackedbar ",
            "stackedline ",
            "stackedspline",
            "stackedsplinearea ",
            "steparea ",
            "stepline  ",
            "stock"});
            this.comboBoxChartType.Label.Size = 50;
            this.comboBoxChartType.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBoxChartType.LabelText = "Chart Type";
            this.comboBoxChartType.Location = new System.Drawing.Point(3, 253);
            this.comboBoxChartType.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(212, 60);
            this.comboBoxChartType.TabIndex = 7;
            this.comboBoxChartType.Text = "shift";
            // 
            // dxChart
            // 
            this.Name = "dxChart";
            this.Load += new System.EventHandler(this.dxChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxChart dxChart1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private Upload buttonLoad;
		private CheckBox checkBox4;
		private ComboBox comboBox1;
        private ComboBox comboBoxChartType;
    }
}
