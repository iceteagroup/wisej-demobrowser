namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoMultiColumnComboBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoMultiColumnComboBox));
			this.kendoMultiColumnComboBox1 = new Wisej.Web.Ext.Kendo.kendoMultiColumnComboBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.textBox1 = new Wisej.Web.TextBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoMultiColumnComboBox1);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/multicolumncombobox/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/multicolumncombobox";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/multicolumncombobox/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox3);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox4);
			this.flowLayoutPanelProperties.Controls.Add(this.textBox1);
			// 
			// kendoMultiColumnComboBox1
			// 
			this.kendoMultiColumnComboBox1.Anchor = Wisej.Web.AnchorStyles.None;
			this.kendoMultiColumnComboBox1.Location = new System.Drawing.Point(294, 268);
			this.kendoMultiColumnComboBox1.Name = "kendoMultiColumnComboBox1";
			this.kendoMultiColumnComboBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoMultiColumnComboBox1.Options"))));
			this.kendoMultiColumnComboBox1.Size = new System.Drawing.Size(300, 40);
			this.kendoMultiColumnComboBox1.TabIndex = 0;
			this.kendoMultiColumnComboBox1.Text = "kendoMultiColumnComboBox1";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
			this.checkBox1.Location = new System.Drawing.Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(212, 38);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Clear Button";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
			this.checkBox2.Location = new System.Drawing.Point(3, 60);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(212, 38);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "Ignore Case";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox3, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox3, true);
			this.checkBox3.Location = new System.Drawing.Point(3, 117);
			this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(212, 38);
			this.checkBox3.TabIndex = 7;
			this.checkBox3.Text = "Suggest";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox4, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox4, true);
			this.checkBox4.Location = new System.Drawing.Point(3, 174);
			this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(212, 38);
			this.checkBox4.TabIndex = 8;
			this.checkBox4.Text = "Sync Value and Text";
			// 
			// textBox1
			// 
			this.textBox1.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.textBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.textBox1, true);
			this.textBox1.Label.Size = 50;
			this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBox1.LabelText = "Value";
			this.textBox1.Location = new System.Drawing.Point(3, 231);
			this.textBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(212, 60);
			this.textBox1.TabIndex = 9;
			// 
			// kendoMultiColumnComboBox
			// 
			this.Name = "kendoMultiColumnComboBox";
			this.Load += new System.EventHandler(this.kendoMultiColumnComboBox_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoMultiColumnComboBox kendoMultiColumnComboBox1;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private TextBox textBox1;
	}
}
