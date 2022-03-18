﻿namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class LinearGauge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinearGauge));
            this.linearGauge1 = new Wisej.Web.Ext.Syncfusion2.LinearGauge();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.numericUpDownMajorTick = new Wisej.Web.NumericUpDown();
            this.numericUpDownMinorType = new Wisej.Web.NumericUpDown();
            this.comboBoxOrientation = new Wisej.Web.ComboBox();
            this.comboBoxContainerType = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMajorTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinorType)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/linear-gauge/es5-getting-star" +
    "ted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/linear-gauge/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxContainerType);
            this.groupBox1.Controls.Add(this.comboBoxOrientation);
            this.groupBox1.Controls.Add(this.numericUpDownMinorType);
            this.groupBox1.Controls.Add(this.numericUpDownMajorTick);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Size = new System.Drawing.Size(250, 353);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownMajorTick, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownMinorType, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxOrientation, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxContainerType, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 272);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.linearGauge1);
            this.panel.Size = new System.Drawing.Size(517, 353);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/linear-gauge/default.html";
            // 
            // linearGauge1
            // 
            this.linearGauge1.Dock = Wisej.Web.DockStyle.Fill;
            this.linearGauge1.Location = new System.Drawing.Point(8, 8);
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("linearGauge1.Options"))));
            this.linearGauge1.Size = new System.Drawing.Size(499, 335);
            this.linearGauge1.TabIndex = 0;
            this.linearGauge1.Text = "linearGauge1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = false;
            this.numericUpDown1.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.numericUpDown1.Label.Size = 50;
            this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown1.LabelText = "Value";
            this.numericUpDown1.Location = new System.Drawing.Point(9, 83);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(230, 60);
            this.numericUpDown1.TabIndex = 1;
            // 
            // numericUpDownMajorTick
            // 
            this.numericUpDownMajorTick.AutoSize = false;
            this.numericUpDownMajorTick.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.numericUpDownMajorTick.Label.Size = 50;
            this.numericUpDownMajorTick.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDownMajorTick.LabelText = "Major tick";
            this.numericUpDownMajorTick.Location = new System.Drawing.Point(9, 18);
            this.numericUpDownMajorTick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMajorTick.Name = "numericUpDownMajorTick";
            this.numericUpDownMajorTick.Size = new System.Drawing.Size(108, 60);
            this.numericUpDownMajorTick.TabIndex = 3;
            this.numericUpDownMajorTick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMinorType
            // 
            this.numericUpDownMinorType.AutoSize = false;
            this.numericUpDownMinorType.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.numericUpDownMinorType.Label.Size = 50;
            this.numericUpDownMinorType.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDownMinorType.LabelText = "Minor tick";
            this.numericUpDownMinorType.Location = new System.Drawing.Point(129, 18);
            this.numericUpDownMinorType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMinorType.Name = "numericUpDownMinorType";
            this.numericUpDownMinorType.Size = new System.Drawing.Size(110, 60);
            this.numericUpDownMinorType.TabIndex = 4;
            this.numericUpDownMinorType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxOrientation
            // 
            this.comboBoxOrientation.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxOrientation.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.comboBoxOrientation.LabelText = "Orientation";
            this.comboBoxOrientation.Location = new System.Drawing.Point(9, 155);
            this.comboBoxOrientation.Name = "comboBoxOrientation";
            this.comboBoxOrientation.Size = new System.Drawing.Size(112, 53);
            this.comboBoxOrientation.TabIndex = 5;
            // 
            // comboBoxContainerType
            // 
            this.comboBoxContainerType.Items.AddRange(new object[] {
            "Thermometer",
            "Normal",
            "RoundedRectangle"});
            this.comboBoxContainerType.LabelText = "Container type";
            this.comboBoxContainerType.Location = new System.Drawing.Point(127, 155);
            this.comboBoxContainerType.Name = "comboBoxContainerType";
            this.comboBoxContainerType.Size = new System.Drawing.Size(112, 53);
            this.comboBoxContainerType.TabIndex = 6;
            // 
            // LinearGauge
            // 
            this.Name = "LinearGauge";
            this.Size = new System.Drawing.Size(926, 543);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMajorTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinorType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.LinearGauge linearGauge1;
		private NumericUpDown numericUpDown1;
        private ComboBox comboBoxContainerType;
        private ComboBox comboBoxOrientation;
        private NumericUpDown numericUpDownMinorType;
        private NumericUpDown numericUpDownMajorTick;
    }
}