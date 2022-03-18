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
			this.buttonExport = new Wisej.Web.Button();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Chart/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/x" +
    "Chart/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonExport);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 457);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExport, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 373);
			this.buttonUpdate.TabIndex = 7;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxChart1);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Charts/Overview/jQuery/Light/" +
    "";
			// 
			// dxChart1
			// 
			this.dxChart1.Anchor = Wisej.Web.AnchorStyles.None;
			this.dxChart1.Location = new System.Drawing.Point(37, 28);
			this.dxChart1.Name = "dxChart1";
			this.dxChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxChart1.Options"))));
			this.dxChart1.Size = new System.Drawing.Size(1015, 503);
			this.dxChart1.TabIndex = 0;
			this.dxChart1.Text = "dxChart1";
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
			this.checkBox1.Location = new System.Drawing.Point(28, 35);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Adjust on Zoom";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.Location = new System.Drawing.Point(28, 87);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Auto Hide Point Markers";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 317);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 5;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonExport
			// 
			this.buttonExport.Display = Wisej.Web.Display.Icon;
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
			this.buttonExport.Location = new System.Drawing.Point(76, 317);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(42, 42);
			this.buttonExport.TabIndex = 6;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Checked = true;
			this.checkBox3.Location = new System.Drawing.Point(28, 139);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Allow Touch Gestures";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Location = new System.Drawing.Point(28, 191);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 38);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Drag to Zoom";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "alt",
            "ctrl",
            "meta",
            "shift"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Pan Key";
			this.comboBox1.Location = new System.Drawing.Point(28, 243);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Text = "shift";
			// 
			// dxChart
			// 
			this.Name = "dxChart";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxChart dxChart1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private Upload buttonLoad;
		private Button buttonExport;
		private CheckBox checkBox3;
		private CheckBox checkBox4;
		private ComboBox comboBox1;
	}
}
