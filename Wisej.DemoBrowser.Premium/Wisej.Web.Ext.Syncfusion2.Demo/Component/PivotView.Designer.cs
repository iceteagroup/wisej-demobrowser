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
            this.checkBoxRemoveIcon = new Wisej.Web.CheckBox();
            this.checkBoxValueTypeIcon = new Wisej.Web.CheckBox();
            this.checkBoxSortIcon = new Wisej.Web.CheckBox();
            this.checkBoxFilterIcon = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pivotView1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxFilterIcon);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxSortIcon);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxValueTypeIcon);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxRemoveIcon);
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
            // checkBoxRemoveIcon
            // 
            this.checkBoxRemoveIcon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxRemoveIcon.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxRemoveIcon, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxRemoveIcon, true);
            this.checkBoxRemoveIcon.Location = new System.Drawing.Point(3, 132);
            this.checkBoxRemoveIcon.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxRemoveIcon.Name = "checkBoxRemoveIcon";
            this.checkBoxRemoveIcon.Size = new System.Drawing.Size(212, 24);
            this.checkBoxRemoveIcon.TabIndex = 3;
            this.checkBoxRemoveIcon.Text = "Show Remove Icon";
            // 
            // checkBoxValueTypeIcon
            // 
            this.checkBoxValueTypeIcon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxValueTypeIcon.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxValueTypeIcon, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxValueTypeIcon, true);
            this.checkBoxValueTypeIcon.Location = new System.Drawing.Point(3, 89);
            this.checkBoxValueTypeIcon.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxValueTypeIcon.Name = "checkBoxValueTypeIcon";
            this.checkBoxValueTypeIcon.Size = new System.Drawing.Size(212, 24);
            this.checkBoxValueTypeIcon.TabIndex = 2;
            this.checkBoxValueTypeIcon.Text = "Show Value Type Icon";
            // 
            // checkBoxSortIcon
            // 
            this.checkBoxSortIcon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxSortIcon.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxSortIcon, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxSortIcon, true);
            this.checkBoxSortIcon.Location = new System.Drawing.Point(3, 46);
            this.checkBoxSortIcon.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxSortIcon.Name = "checkBoxSortIcon";
            this.checkBoxSortIcon.Size = new System.Drawing.Size(212, 24);
            this.checkBoxSortIcon.TabIndex = 1;
            this.checkBoxSortIcon.Text = "Show Sort Icon";
            // 
            // checkBoxFilterIcon
            // 
            this.checkBoxFilterIcon.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFilterIcon.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxFilterIcon, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxFilterIcon, true);
            this.checkBoxFilterIcon.Location = new System.Drawing.Point(3, 3);
            this.checkBoxFilterIcon.Name = "checkBoxFilterIcon";
            this.checkBoxFilterIcon.Size = new System.Drawing.Size(212, 24);
            this.checkBoxFilterIcon.TabIndex = 0;
            this.checkBoxFilterIcon.Text = "Show Filter Icon";
            // 
            // PivotView
            // 
            this.Name = "PivotView";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.PivotView pivotView1;
        private CheckBox checkBoxRemoveIcon;
        private CheckBox checkBoxValueTypeIcon;
        private CheckBox checkBoxSortIcon;
        private CheckBox checkBoxFilterIcon;
    }
}
