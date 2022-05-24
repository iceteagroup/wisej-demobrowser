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
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igTree));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igTree2 = new Wisej.Web.Ext.Ignite.igTree();
			this.igTree1 = new Wisej.Web.Ext.Ignite.igTree();
			this.buttonClearSelection = new Wisej.Web.Button();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.TabIndex = 3;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 3;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igTree2);
			this.panel.Controls.Add(this.igTree1);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/tree/overview";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igtree";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igtree-igtree";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBox1);
			this.flowLayoutPanel1.Controls.Add(this.comboBox1);
			this.flowLayoutPanel1.Controls.Add(this.buttonClearSelection);
			// 
			// igTree2
			// 
			this.igTree2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
			this.igTree2.Location = new System.Drawing.Point(446, 28);
			this.igTree2.Name = "igTree2";
			this.igTree2.Size = new System.Drawing.Size(252, 521);
			this.igTree2.TabIndex = 1;
			this.igTree2.Text = "igTree2";
			widgetFunction1.Name = "customDropValidation";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			this.igTree2.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// igTree1
			// 
			this.igTree1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
			this.igTree1.Location = new System.Drawing.Point(190, 28);
			this.igTree1.Name = "igTree1";
			this.igTree1.Size = new System.Drawing.Size(250, 521);
			this.igTree1.TabIndex = 0;
			this.igTree1.Text = "igTree1";
			widgetFunction2.Name = "customDropValidation";
			widgetFunction2.Source = resources.GetString("widgetFunction2.Source");
			this.igTree1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction2};
			// 
			// buttonClearSelection
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonClearSelection, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.buttonClearSelection, true);
			this.buttonClearSelection.Location = new System.Drawing.Point(3, 148);
			this.buttonClearSelection.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonClearSelection.Name = "buttonClearSelection";
			this.buttonClearSelection.Size = new System.Drawing.Size(212, 40);
			this.buttonClearSelection.TabIndex = 2;
			this.buttonClearSelection.Text = "Clear Selection";
			this.buttonClearSelection.Click += new System.EventHandler(this.buttonClearSelection_Click);
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
			this.checkBox1.Size = new System.Drawing.Size(212, 50);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Single Branch Expand";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
			this.comboBox1.Items.AddRange(new object[] {
            "off",
            "biState",
            "triState"});
			this.comboBox1.LabelText = "Checkbox Mode";
			this.comboBox1.Location = new System.Drawing.Point(3, 72);
			this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(212, 57);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "triState";
			// 
			// igTree
			// 
			this.Name = "igTree";
			this.Load += new System.EventHandler(this.igTree_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igTree igTree1;
		private Ignite.igTree igTree2;
		private Button buttonClearSelection;
		private CheckBox checkBox1;
		private ComboBox comboBox1;
	}
}
