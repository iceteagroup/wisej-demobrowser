namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class PivotView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PivotView));
            this.pivotView1 = new Wisej.Web.Ext.Syncfusion2.PivotView();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.checkBoxRemoveIcon = new Wisej.Web.CheckBox();
            this.checkBoxValueTypeIcon = new Wisej.Web.CheckBox();
            this.checkBoxSortIcon = new Wisej.Web.CheckBox();
            this.checkBoxFilterIcon = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/pivotview/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/pivotview/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Size = new System.Drawing.Size(250, 504);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 423);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pivotView1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/pivot-table/default.html";
            // 
            // pivotView1
            // 
            this.pivotView1.Dock = Wisej.Web.DockStyle.Fill;
            this.pivotView1.Location = new System.Drawing.Point(8, 8);
            this.pivotView1.Name = "pivotView1";
            this.pivotView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("pivotView1.Options"))));
            this.pivotView1.Size = new System.Drawing.Size(1073, 542);
            this.pivotView1.TabIndex = 0;
            this.pivotView1.Text = "pivotView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxRemoveIcon);
            this.groupBox2.Controls.Add(this.checkBoxValueTypeIcon);
            this.groupBox2.Controls.Add(this.checkBoxSortIcon);
            this.groupBox2.Controls.Add(this.checkBoxFilterIcon);
            this.groupBox2.Location = new System.Drawing.Point(7, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "Grouping bar";
            // 
            // checkBoxRemoveIcon
            // 
            this.checkBoxRemoveIcon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxRemoveIcon.Checked = true;
            this.checkBoxRemoveIcon.Location = new System.Drawing.Point(6, 112);
            this.checkBoxRemoveIcon.Name = "checkBoxRemoveIcon";
            this.checkBoxRemoveIcon.Size = new System.Drawing.Size(159, 24);
            this.checkBoxRemoveIcon.TabIndex = 3;
            this.checkBoxRemoveIcon.Text = "Show remove icon";
            // 
            // checkBoxValueTypeIcon
            // 
            this.checkBoxValueTypeIcon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxValueTypeIcon.Checked = true;
            this.checkBoxValueTypeIcon.Location = new System.Drawing.Point(7, 83);
            this.checkBoxValueTypeIcon.Name = "checkBoxValueTypeIcon";
            this.checkBoxValueTypeIcon.Size = new System.Drawing.Size(175, 24);
            this.checkBoxValueTypeIcon.TabIndex = 2;
            this.checkBoxValueTypeIcon.Text = "Show value type icon";
            // 
            // checkBoxSortIcon
            // 
            this.checkBoxSortIcon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxSortIcon.Checked = true;
            this.checkBoxSortIcon.Location = new System.Drawing.Point(7, 54);
            this.checkBoxSortIcon.Name = "checkBoxSortIcon";
            this.checkBoxSortIcon.Size = new System.Drawing.Size(138, 24);
            this.checkBoxSortIcon.TabIndex = 1;
            this.checkBoxSortIcon.Text = "Show sort icon";
            // 
            // checkBoxFilterIcon
            // 
            this.checkBoxFilterIcon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFilterIcon.Checked = true;
            this.checkBoxFilterIcon.Location = new System.Drawing.Point(7, 25);
            this.checkBoxFilterIcon.Name = "checkBoxFilterIcon";
            this.checkBoxFilterIcon.Size = new System.Drawing.Size(141, 24);
            this.checkBoxFilterIcon.TabIndex = 0;
            this.checkBoxFilterIcon.Text = "Show filter icon";
            // 
            // PivotView
            // 
            this.Name = "PivotView";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.PivotView pivotView1;
        private GroupBox groupBox2;
        private CheckBox checkBoxRemoveIcon;
        private CheckBox checkBoxValueTypeIcon;
        private CheckBox checkBoxSortIcon;
        private CheckBox checkBoxFilterIcon;
    }
}
