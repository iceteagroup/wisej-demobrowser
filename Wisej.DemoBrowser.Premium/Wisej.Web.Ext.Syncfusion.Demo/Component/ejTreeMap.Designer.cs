namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejTreeMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejTreeMap));
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate1 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate2 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate widgetTemplate3 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate();
			this.ejTreeMap1 = new Wisej.Web.Ext.Syncfusion.ejTreeMap();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://help.syncfusion.com/js/treemap/overview";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 4;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/treemap/FlatCollection";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "https://help.syncfusion.com/api/js/ejtreemap#members";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejTreeMap1);
			this.panel.TabIndex = 7;
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox3);
			this.flowLayoutPanelProperties.Controls.Add(this.comboBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.comboBox2);
			// 
			// ejTreeMap1
			// 
			this.ejTreeMap1.CssStyle = "\r\n.e-treemap-leaflabel {\r\n    color: black;\r\n}";
			this.ejTreeMap1.Dock = Wisej.Web.DockStyle.Fill;
			this.ejTreeMap1.Location = new System.Drawing.Point(8, 8);
			this.ejTreeMap1.Name = "ejTreeMap1";
			this.ejTreeMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejTreeMap1.Options"))));
			this.ejTreeMap1.Size = new System.Drawing.Size(872, 560);
			this.ejTreeMap1.TabIndex = 0;
			this.ejTreeMap1.Text = "ejTreeMap1";
			widgetTemplate1.Id = "headertemplate";
			widgetTemplate1.Template = "<div style=\"margin-top:3px;\">\r\n    <label style=\"color:gray;font-size:16px;font-w" +
    "eight:normal;margin-left:5px;\" id=\"Label1\">{{:header}}</label><br />\r\n</div>";
			widgetTemplate1.Type = "application/jsrender";
			widgetTemplate2.Id = "labeltemplate";
			widgetTemplate2.Template = "<div style=\"background-color: transparent;\">\r\n    <label style=\"color:black;font-" +
    "size:large;font-weight:normal;\" >{{:Country}}</label><br />\r\n</div> ";
			widgetTemplate2.Type = "application/jsrender";
			widgetTemplate3.Id = "template";
			widgetTemplate3.Template = resources.GetString("widgetTemplate3.Template");
			widgetTemplate3.Type = "application/jsrender";
			this.ejTreeMap1.WidgetTemplates = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetTemplate[] {
        widgetTemplate1,
        widgetTemplate2,
        widgetTemplate3};
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
			this.checkBox2.Location = new System.Drawing.Point(3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(212, 30);
			this.checkBox2.TabIndex = 0;
			this.checkBox2.Text = "Enable Gradient";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox3, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox3, true);
			this.checkBox3.Location = new System.Drawing.Point(3, 52);
			this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(212, 30);
			this.checkBox3.TabIndex = 1;
			this.checkBox3.Text = "Highlight on Selection";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanelProperties.SetFillWeight(this.comboBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.comboBox1, true);
			this.comboBox1.Items.AddRange(new object[] {
            "squarified",
            "sliceanddicehorizontal",
            "sliceanddicevertical",
            "sliceanddiceauto"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Items Layout Mode";
			this.comboBox1.Location = new System.Drawing.Point(3, 101);
			this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(212, 60);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Text = "Squarified";
			// 
			// comboBox2
			// 
			this.comboBox2.AutoSize = false;
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanelProperties.SetFillWeight(this.comboBox2, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.comboBox2, true);
			this.comboBox2.Items.AddRange(new object[] {
            "default",
            "multiple"});
			this.comboBox2.Label.Size = 50;
			this.comboBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox2.LabelText = "Group Selection Mode";
			this.comboBox2.Location = new System.Drawing.Point(3, 180);
			this.comboBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(212, 60);
			this.comboBox2.TabIndex = 3;
			this.comboBox2.Text = "default";
			// 
			// ejTreeMap
			// 
			this.Name = "ejTreeMap";
			this.Load += new System.EventHandler(this.ejTreeMap_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.ejTreeMap ejTreeMap1;
		private CheckBox checkBox2;
		private CheckBox checkBox3;
		private ComboBox comboBox2;
		private ComboBox comboBox1;
	}
}
