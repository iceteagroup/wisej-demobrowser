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
            Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
            this.dxChart1 = new Wisej.Web.Ext.DevExtreme.dxChart();
            this.checkBoxAdjustOnZoom = new Wisej.Web.CheckBox();
            this.checkBoxAutoHidePointMarkers = new Wisej.Web.CheckBox();
            this.buttonLoad = new Wisej.Web.Upload();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.checkBoxRotated = new Wisej.Web.CheckBox();
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
            this.flowLayoutPanel1.Controls.Add(this.checkBoxRotated);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAdjustOnZoom);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAutoHidePointMarkers);
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.buttonLoad);
            // 
            // dxChart1
            // 
            this.dxChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxChart1.Location = new System.Drawing.Point(31, 37);
            this.dxChart1.Name = "dxChart1";
            this.dxChart1.Size = new System.Drawing.Size(826, 503);
            this.dxChart1.TabIndex = 0;
            widgetFunction1.Name = "getDataSourceItems";
            widgetFunction1.Source = "return this.Instance.getDataSource()._items;";
            this.dxChart1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[] {
        widgetFunction1};
            // 
            // checkBoxAdjustOnZoom
            // 
            this.checkBoxAdjustOnZoom.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAdjustOnZoom.AutoSize = false;
            this.checkBoxAdjustOnZoom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAdjustOnZoom.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxAdjustOnZoom, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxAdjustOnZoom, true);
            this.checkBoxAdjustOnZoom.Location = new System.Drawing.Point(3, 56);
            this.checkBoxAdjustOnZoom.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxAdjustOnZoom.Name = "checkBoxAdjustOnZoom";
            this.checkBoxAdjustOnZoom.Size = new System.Drawing.Size(212, 34);
            this.checkBoxAdjustOnZoom.TabIndex = 0;
            this.checkBoxAdjustOnZoom.Text = "Adjust on Zoom";
            // 
            // checkBoxAutoHidePointMarkers
            // 
            this.checkBoxAutoHidePointMarkers.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAutoHidePointMarkers.AutoSize = false;
            this.checkBoxAutoHidePointMarkers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAutoHidePointMarkers.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxAutoHidePointMarkers, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxAutoHidePointMarkers, true);
            this.checkBoxAutoHidePointMarkers.Location = new System.Drawing.Point(3, 109);
            this.checkBoxAutoHidePointMarkers.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxAutoHidePointMarkers.Name = "checkBoxAutoHidePointMarkers";
            this.checkBoxAutoHidePointMarkers.Size = new System.Drawing.Size(212, 31);
            this.checkBoxAutoHidePointMarkers.TabIndex = 1;
            this.checkBoxAutoHidePointMarkers.Text = "Hide Point Markers";
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".json";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(3, 285);
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
            this.checkBox4.Location = new System.Drawing.Point(3, 159);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 31);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Drag to Zoom";
            // 
            // comboBox1
            // 
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
            this.comboBox1.Location = new System.Drawing.Point(3, 209);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 57);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "shift";
            // 
            // checkBoxRotated
            // 
            this.checkBoxRotated.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxRotated.AutoSize = false;
            this.checkBoxRotated.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxRotated, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxRotated, true);
            this.checkBoxRotated.Location = new System.Drawing.Point(3, 3);
            this.checkBoxRotated.Name = "checkBoxRotated";
            this.checkBoxRotated.Size = new System.Drawing.Size(212, 34);
            this.checkBoxRotated.TabIndex = 8;
            this.checkBoxRotated.Text = "Rotated";
            // 
            // dxChart
            // 
            this.Name = "dxChart";
            this.Load += new System.EventHandler(this.dxChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxChart dxChart1;
		private CheckBox checkBoxAutoHidePointMarkers;
		private CheckBox checkBoxAdjustOnZoom;
		private Upload buttonLoad;
		private CheckBox checkBox4;
		private ComboBox comboBox1;
        private CheckBox checkBoxRotated;
    }
}
