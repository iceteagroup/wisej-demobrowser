﻿namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejListBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejListBox));
			this.ejListBox1 = new Wisej.Web.Ext.Syncfusion.ejListBox();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonSave = new Wisej.Web.Button();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.checkBox5 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://help.syncfusion.com/js/listbox/overview";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 8;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(543, 24);
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/listbox/DefaultFunctionalities";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "https://help.syncfusion.com/api/js/ejlistbox";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejListBox1);
			this.panel.TabIndex = 7;
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox3);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox4);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox5);
			this.flowLayoutPanelProperties.Controls.Add(this.comboBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.buttonLoad);
			this.flowLayoutPanelProperties.Controls.Add(this.buttonSave);
			// 
			// ejListBox1
			// 
			this.ejListBox1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ejListBox1.Location = new System.Drawing.Point(320, 99);
			this.ejListBox1.Name = "ejListBox1";
			this.ejListBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejListBox1.Options"))));
			this.ejListBox1.Size = new System.Drawing.Size(248, 379);
			this.ejListBox1.TabIndex = 0;
			this.ejListBox1.Text = "ejListBox1";
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(3, 327);
			this.buttonLoad.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 6;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonSave
			// 
			this.buttonSave.Display = Wisej.Web.Display.Icon;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(51, 327);
			this.buttonSave.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(42, 42);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanelProperties.SetFillWeight(this.comboBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.comboBox1, true);
			this.comboBox1.Items.AddRange(new object[] {
            "Continuous",
            "Normal"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Virtual Scroll Mode";
			this.comboBox1.Location = new System.Drawing.Point(3, 248);
			this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(212, 60);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.Text = "Normal";
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
			this.checkBox1.Size = new System.Drawing.Size(212, 30);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Allow Drag";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
			this.checkBox2.Location = new System.Drawing.Point(3, 52);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(212, 30);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Allow Drop";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox3, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox3, true);
			this.checkBox3.Location = new System.Drawing.Point(3, 101);
			this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(212, 30);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Allow MultiSelection";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox4, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox4, true);
			this.checkBox4.Location = new System.Drawing.Point(3, 150);
			this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(212, 30);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Show Checkbox";
			// 
			// checkBox5
			// 
			this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox5.AutoSize = false;
			this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox5, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox5, true);
			this.checkBox5.Location = new System.Drawing.Point(3, 199);
			this.checkBox5.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(212, 30);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "Incremental Search";
			// 
			// ejListBox
			// 
			this.Name = "ejListBox";
			this.Load += new System.EventHandler(this.ejListBox_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.ejListBox ejListBox1;
		private Upload buttonLoad;
		private Button buttonSave;
		private ComboBox comboBox1;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
