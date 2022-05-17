namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejPivotGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejPivotGrid));
            this.ejPivotGrid1 = new Wisej.Web.Ext.Syncfusion.ejPivotGrid();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBoxShow3 = new Wisej.Web.CheckBox();
            this.buttonSave = new Wisej.Web.Button();
            this.buttonLoad = new Wisej.Web.Upload();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/pivotgrid/overview";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(566, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/pivotgrid/relational/defaultfunc" +
    "tionalities";
            // 
            // linkAPI
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "https://help.syncfusion.com/api/js/ejpivotgrid";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejPivotGrid1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBoxShow3);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox4);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonLoad);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonSave);
            // 
            // ejPivotGrid1
            // 
            this.ejPivotGrid1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejPivotGrid1.Location = new System.Drawing.Point(8, 8);
            this.ejPivotGrid1.Name = "ejPivotGrid1";
            this.ejPivotGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejPivotGrid1.Options"))));
            this.ejPivotGrid1.Size = new System.Drawing.Size(1073, 542);
            this.ejPivotGrid1.TabIndex = 0;
            this.ejPivotGrid1.Text = "ejPivotGrid1";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 38);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable Cell Click";
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
            this.checkBox2.Size = new System.Drawing.Size(212, 44);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Show Header Row Items";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 197);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 38);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Column Grand Total";
            // 
            // checkBoxShow3
            // 
            this.checkBoxShow3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShow3.AutoSize = false;
            this.checkBoxShow3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShow3.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxShow3, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxShow3, true);
            this.checkBoxShow3.Location = new System.Drawing.Point(3, 123);
            this.checkBoxShow3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxShow3.Name = "checkBoxShow3";
            this.checkBoxShow3.Size = new System.Drawing.Size(212, 55);
            this.checkBoxShow3.TabIndex = 2;
            this.checkBoxShow3.Text = "Show Header Row Items";
            // 
            // buttonSave
            // 
            this.buttonSave.Display = Wisej.Web.Display.Icon;
            this.buttonSave.ImageSource = "icon-save";
            this.buttonSave.Location = new System.Drawing.Point(51, 254);
            this.buttonSave.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(42, 42);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".json";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(3, 254);
            this.buttonLoad.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 42);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
            // 
            // ejPivotGrid
            // 
            this.Name = "ejPivotGrid";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejPivotGrid ejPivotGrid1;
		private CheckBox checkBoxShow3;
		private CheckBox checkBox4;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private Button buttonSave;
		private Upload buttonLoad;
	}
}
