﻿namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igPieChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igPieChart));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igPieChart1 = new Wisej.Web.Ext.Ignite.igPieChart();
			this.groupBox2 = new Wisej.Web.GroupBox();
			this.button1 = new Wisej.Web.Button();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.textBox1 = new Wisej.Web.TextBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.TabIndex = 3;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igPieChart1);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/pie-chart/overview";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igPieChart";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igpiechart";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBox1);
			this.flowLayoutPanel1.Controls.Add(this.checkBox2);
			this.flowLayoutPanel1.Controls.Add(this.comboBox1);
			this.flowLayoutPanel1.Controls.Add(this.groupBox2);
			// 
			// igPieChart1
			// 
			this.igPieChart1.Dock = Wisej.Web.DockStyle.Fill;
			this.igPieChart1.Location = new System.Drawing.Point(8, 8);
			this.igPieChart1.Name = "igPieChart1";
			this.igPieChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igPieChart1.Options"))));
			this.igPieChart1.Size = new System.Drawing.Size(872, 560);
			this.igPieChart1.TabIndex = 0;
			this.igPieChart1.Text = "igPieChart1";
			widgetFunction1.Name = "AddItem";
			widgetFunction1.Source = "this.Instance.addItem({\r\n    Label: \"Test\",\r\n    Budget: 50\r\n});";
			this.igPieChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.numericUpDown1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.flowLayoutPanel1.SetFillWeight(this.groupBox2, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.groupBox2, true);
			this.groupBox2.Location = new System.Drawing.Point(3, 181);
			this.groupBox2.Margin = new Wisej.Web.Padding(3, 12, 3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(212, 200);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.Text = "Add Item";
			// 
			// button1
			// 
			this.button1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(6, 155);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 35);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.numericUpDown1.LabelText = "Budget";
			this.numericUpDown1.Location = new System.Drawing.Point(6, 88);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(200, 57);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBox1.LabelText = "Department";
			this.textBox1.Location = new System.Drawing.Point(6, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 57);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Human Resources";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.flowLayoutPanel1.SetFillWeight(this.checkBox2, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBox2, true);
			this.checkBox2.Location = new System.Drawing.Point(3, 56);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 12, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(212, 38);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Allow Slice Selection";
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
			this.checkBox1.Text = "Slice Explosion";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
			this.comboBox1.Items.AddRange(new object[] {
            "single",
            "multiple",
            "manual"});
			this.comboBox1.LabelText = "Selection Mode";
			this.comboBox1.Location = new System.Drawing.Point(3, 109);
			this.comboBox1.Margin = new Wisej.Web.Padding(3, 12, 3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(212, 57);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "single";
			// 
			// igPieChart
			// 
			this.Name = "igPieChart";
			this.Load += new System.EventHandler(this.igPieChart_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igPieChart igPieChart1;
		private GroupBox groupBox2;
		private Button button1;
		private NumericUpDown numericUpDown1;
		private TextBox textBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private ComboBox comboBox1;
	}
}
