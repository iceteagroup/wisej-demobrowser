﻿namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoAutoComplete
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoAutoComplete));
			this.kendoAutoComplete1 = new Wisej.Web.Ext.Kendo.kendoAutoComplete();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.checkBox5 = new Wisej.Web.CheckBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoAutoComplete1);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/autocomplete/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/autocomplete";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/autocomplete/binding";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox5);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox4);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox3);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown1);
			// 
			// kendoAutoComplete1
			// 
			this.kendoAutoComplete1.Anchor = Wisej.Web.AnchorStyles.None;
			this.kendoAutoComplete1.Location = new System.Drawing.Point(294, 268);
			this.kendoAutoComplete1.Name = "kendoAutoComplete1";
			this.kendoAutoComplete1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoAutoComplete1.Options"))));
			this.kendoAutoComplete1.Size = new System.Drawing.Size(300, 40);
			this.kendoAutoComplete1.TabIndex = 0;
			this.kendoAutoComplete1.Text = "kendoAutoComplete1";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
			this.checkBox1.Location = new System.Drawing.Point(3, 231);
			this.checkBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(212, 38);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Animation";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
			this.checkBox2.Location = new System.Drawing.Point(3, 174);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(212, 38);
			this.checkBox2.TabIndex = 3;
			this.checkBox2.Text = "Clear Button";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown1, true);
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.LabelText = "Delay";
			this.numericUpDown1.Location = new System.Drawing.Point(3, 288);
			this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown1.TabIndex = 4;
			this.numericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox3, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox3, true);
			this.checkBox3.Location = new System.Drawing.Point(3, 117);
			this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(212, 38);
			this.checkBox3.TabIndex = 5;
			this.checkBox3.Text = "Highlight First";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox4, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox4, true);
			this.checkBox4.Location = new System.Drawing.Point(3, 60);
			this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(212, 38);
			this.checkBox4.TabIndex = 6;
			this.checkBox4.Text = "Ignore Case";
			// 
			// checkBox5
			// 
			this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox5.AutoSize = false;
			this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox5, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox5, true);
			this.checkBox5.Location = new System.Drawing.Point(3, 3);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(212, 38);
			this.checkBox5.TabIndex = 7;
			this.checkBox5.Text = "Suggest";
			// 
			// kendoAutoComplete
			// 
			this.Name = "kendoAutoComplete";
			this.Load += new System.EventHandler(this.kendoAutoComplete_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoAutoComplete kendoAutoComplete1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private NumericUpDown numericUpDown1;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox5;
    }
}
