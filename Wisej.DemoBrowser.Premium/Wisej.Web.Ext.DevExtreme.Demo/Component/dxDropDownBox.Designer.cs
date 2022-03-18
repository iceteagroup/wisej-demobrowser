namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxDropDownBox
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
			Wisej.Web.JavaScript.ClientEvent clientEvent1 = new Wisej.Web.JavaScript.ClientEvent();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxDropDownBox));
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			this.dxDropDownBox1 = new Wisej.Web.Ext.DevExtreme.dxDropDownBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/DropDownBox/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDropDownBox/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Size = new System.Drawing.Size(250, 464);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 380);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxDropDownBox1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/DropDownBox/SingleSelection/j" +
    "Query/Light/";
			// 
			// dxDropDownBox1
			// 
			this.dxDropDownBox1.Anchor = Wisej.Web.AnchorStyles.None;
			clientEvent1.Event = "appear";
			clientEvent1.JavaScript = resources.GetString("clientEvent1.JavaScript");
			this.dxDropDownBox1.ClientEvents.Add(clientEvent1);
			this.dxDropDownBox1.Location = new System.Drawing.Point(369, 262);
			this.dxDropDownBox1.Name = "dxDropDownBox1";
			this.dxDropDownBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"valueExpr\":\"ID\",\"deferRendering\":false,\"placeholder\":\"Select a value...\",\"displ" +
        "ayExpr\":\"displayExpr\",\"contentTemplate\":\"contentTemp\"}")));
			this.dxDropDownBox1.Size = new System.Drawing.Size(350, 35);
			this.dxDropDownBox1.TabIndex = 0;
			widgetFunction1.Name = "displayExpr";
			widgetFunction1.Source = "var item = arguments[0];\r\nreturn item && item.CompanyName + \" <\" + item.Phone + \"" +
    ">\";\r\n";
			widgetFunction2.Name = "contentTemp";
			widgetFunction2.Source = resources.GetString("widgetFunction2.Source");
			this.dxDropDownBox1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[] {
        widgetFunction1,
        widgetFunction2};
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 86);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 8;
			this.checkBox2.Text = "Show Drop Down Button";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 9;
			this.checkBox1.Text = "Show Clear Button";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Location = new System.Drawing.Point(28, 136);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 10;
			this.checkBox3.Text = "Accept Custom Value";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "valid",
            "invalid",
            "pending"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Validation Status";
			this.comboBox1.Location = new System.Drawing.Point(28, 236);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 12;
			this.comboBox1.Text = "valid";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Checked = true;
			this.checkBox4.Location = new System.Drawing.Point(28, 186);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 38);
			this.checkBox4.TabIndex = 13;
			this.checkBox4.Text = "Open on Field Click";
			// 
			// comboBox2
			// 
			this.comboBox2.AutoSize = false;
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
            "always",
            "auto"});
			this.comboBox2.Label.Size = 50;
			this.comboBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox2.LabelText = "Validation Message Mode";
			this.comboBox2.Location = new System.Drawing.Point(28, 308);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 60);
			this.comboBox2.TabIndex = 14;
			this.comboBox2.Text = "auto";
			// 
			// dxDropDownBox
			// 
			this.Name = "dxDropDownBox";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxDropDownBox dxDropDownBox1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox3;
		private ComboBox comboBox2;
		private CheckBox checkBox4;
		private ComboBox comboBox1;
	}
}
