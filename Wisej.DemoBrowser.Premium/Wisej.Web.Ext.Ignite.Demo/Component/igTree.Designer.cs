namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igTree
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igTree));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igTree2 = new Wisej.Web.Ext.Ignite.igTree();
			this.igTree1 = new Wisej.Web.Ext.Ignite.igTree();
			this.button1 = new Wisej.Web.Button();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Size = new System.Drawing.Size(250, 388);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 305);
			this.buttonUpdate.TabIndex = 3;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igTree2);
			this.panel.Controls.Add(this.igTree1);
			this.panel.Size = new System.Drawing.Size(563, 388);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/tree/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igtree";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igtree-igtree";
			// 
			// igTree2
			// 
			this.igTree2.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igTree2.Location = new System.Drawing.Point(283, 19);
			this.igTree2.Name = "igTree2";
			this.igTree2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igTree2.Options"))));
			this.igTree2.Size = new System.Drawing.Size(250, 349);
			this.igTree2.TabIndex = 1;
			this.igTree2.Text = "igTree2";
			widgetFunction1.Name = "customDropValidation";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			this.igTree2.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// igTree1
			// 
			this.igTree1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igTree1.Location = new System.Drawing.Point(27, 19);
			this.igTree1.Name = "igTree1";
			this.igTree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igTree1.Options"))));
			this.igTree1.Size = new System.Drawing.Size(250, 349);
			this.igTree1.TabIndex = 0;
			this.igTree1.Text = "igTree1";
			widgetFunction2.Name = "customDropValidation";
			widgetFunction2.Source = resources.GetString("widgetFunction2.Source");
			this.igTree1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction2};
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 2;
			this.button1.Text = "Clear Selection";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 37);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Single Branch Expand";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "off",
            "biState",
            "triState"});
			this.comboBox1.Label.Text = "Checkbox Mode";
			this.comboBox1.Location = new System.Drawing.Point(28, 129);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 41);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "triState";
			// 
			// igTree
			// 
			this.Name = "igTree";
			this.Size = new System.Drawing.Size(972, 578);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igTree igTree1;
		private Ignite.igTree igTree2;
		private Button button1;
		private CheckBox checkBox1;
		private ComboBox comboBox1;
	}
}
