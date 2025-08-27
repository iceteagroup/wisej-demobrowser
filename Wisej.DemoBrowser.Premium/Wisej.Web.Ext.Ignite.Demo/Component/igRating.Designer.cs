﻿namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igRating
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igRating));
			this.igRating1 = new Wisej.Web.Ext.Ignite.igRating();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.label4 = new Wisej.Web.Label();
			this.label5 = new Wisej.Web.Label();
			this.comboBoxPrecision = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.TabIndex = 3;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 1;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igRating1);
			this.panel.Controls.Add(this.label5);
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.pictureBox1);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/rating/overview";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igrating";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igrating-igrating";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
			this.flowLayoutPanel1.Controls.Add(this.comboBoxPrecision);
			// 
			// igRating1
			// 
			this.igRating1.Anchor = Wisej.Web.AnchorStyles.None;
			this.igRating1.Location = new System.Drawing.Point(368, 203);
			this.igRating1.Name = "igRating1";
			this.igRating1.Size = new System.Drawing.Size(204, 40);
			this.igRating1.TabIndex = 1;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 2;
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDown1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown1, true);
			this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown1.LabelText = "Set Value";
			this.numericUpDown1.Location = new System.Drawing.Point(3, 3);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(212, 51);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = Wisej.Web.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(136, 167);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(226, 242);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// label4
			// 
			this.label4.Anchor = Wisej.Web.AnchorStyles.None;
			this.label4.Font = new System.Drawing.Font("default", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label4.Location = new System.Drawing.Point(368, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(171, 39);
			this.label4.TabIndex = 0;
			this.label4.Text = "The Avengers";
			// 
			// label5
			// 
			this.label5.Anchor = Wisej.Web.AnchorStyles.None;
			this.label5.Location = new System.Drawing.Point(368, 249);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(385, 160);
			this.label5.TabIndex = 2;
			this.label5.Text = "Earth\'s mightiest heroes must come together and learn to fight as a team if they " +
    "are going to stop the mischievous Loki and his alien army from enslaving humanit" +
    "y.";
			// 
			// comboBoxPrecision
			// 
			this.comboBoxPrecision.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxPrecision.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxPrecision.Items.AddRange(new object[] {
            "exact",
            "half",
            "whole"});
			this.comboBoxPrecision.LabelText = "Precision";
			this.comboBoxPrecision.Location = new System.Drawing.Point(3, 60);
			this.comboBoxPrecision.Name = "comboBoxPrecision";
			this.comboBoxPrecision.Size = new System.Drawing.Size(212, 51);
			this.comboBoxPrecision.TabIndex = 5;
			// 
			// igRating
			// 
			this.Name = "igRating";
			this.Load += new System.EventHandler(this.igRating_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igRating igRating1;
		private NumericUpDown numericUpDown1;
		private Label label5;
		private Label label4;
		private PictureBox pictureBox1;
        private ComboBox comboBoxPrecision;
    }
}
