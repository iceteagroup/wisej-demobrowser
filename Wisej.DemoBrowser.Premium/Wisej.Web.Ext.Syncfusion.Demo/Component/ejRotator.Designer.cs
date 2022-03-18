﻿namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejRotator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejRotator));
            this.ejRotator1 = new Wisej.Web.Ext.Syncfusion.ejRotator();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.buttonPlay = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/rotator/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonPlay);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 363);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonPlay, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 282);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(508, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/rotator/DefaultFunctionalities";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejrotator";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejRotator1);
            this.panel.TabIndex = 7;
            // 
            // ejRotator1
            // 
            this.ejRotator1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejRotator1.Location = new System.Drawing.Point(8, 8);
            this.ejRotator1.Name = "ejRotator1";
            this.ejRotator1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejRotator1.Options"))));
            this.ejRotator1.Size = new System.Drawing.Size(1073, 542);
            this.ejRotator1.TabIndex = 0;
            this.ejRotator1.Text = "ejRotator1";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 38);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Caption";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.checkBox2.Location = new System.Drawing.Point(28, 91);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(183, 38);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Show Play Button";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Slide",
            "FastSlide",
            "SlowSlide"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Animation Type";
            this.comboBox1.Location = new System.Drawing.Point(28, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 60);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Slide";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Display = Wisej.Web.Display.Icon;
            this.buttonPlay.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/play-arrow.svg";
            this.buttonPlay.Location = new System.Drawing.Point(28, 223);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(42, 42);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // button1
            // 
            this.button1.Display = Wisej.Web.Display.Icon;
            this.button1.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/pause-button.svg";
            this.button1.Location = new System.Drawing.Point(76, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 42);
            this.button1.TabIndex = 5;
            this.button1.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // ejRotator
            // 
            this.Name = "ejRotator";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejRotator ejRotator1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private ComboBox comboBox1;
		private Button buttonPlay;
		private Button button1;
	}
}