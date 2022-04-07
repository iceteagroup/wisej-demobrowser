namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class DataTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTable));
            this.dataTable1 = new Wisej.Web.Ext.Webix.DataTable();
            this.checkBoxEnableDrag = new Wisej.Web.CheckBox();
            this.checkBoxEditable = new Wisej.Web.CheckBox();
            this.checkBoxEnableHeader = new Wisej.Web.CheckBox();
            this.checkBoxEnableSort = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/datatable__index.html";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#datatable";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.datatable.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dataTable1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableDrag);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEditable);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableHeader);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableSort);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 434);
            // 
            // dataTable1
            // 
            this.dataTable1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataTable1.Location = new System.Drawing.Point(8, 8);
            this.dataTable1.Name = "dataTable1";
            this.dataTable1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dataTable1.Options"))));
            this.dataTable1.Size = new System.Drawing.Size(1073, 542);
            this.dataTable1.TabIndex = 0;
            this.dataTable1.Text = "dataTable1";
            // 
            // checkBoxEnableDrag
            // 
            this.checkBoxEnableDrag.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableDrag.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableDrag.AutoSize = false;
            this.checkBoxEnableDrag.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEnableDrag, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEnableDrag, true);
            this.checkBoxEnableDrag.Location = new System.Drawing.Point(3, 3);
            this.checkBoxEnableDrag.Name = "checkBoxEnableDrag";
            this.checkBoxEnableDrag.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableDrag.TabIndex = 1;
            this.checkBoxEnableDrag.Text = "Drag-and-Drop";
            // 
            // checkBoxEditable
            // 
            this.checkBoxEditable.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEditable.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEditable.AutoSize = false;
            this.checkBoxEditable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEditable, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEditable, true);
            this.checkBoxEditable.Location = new System.Drawing.Point(3, 48);
            this.checkBoxEditable.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEditable.Name = "checkBoxEditable";
            this.checkBoxEditable.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEditable.TabIndex = 2;
            this.checkBoxEditable.Text = "Editable";
            // 
            // checkBoxEnableHeader
            // 
            this.checkBoxEnableHeader.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableHeader.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableHeader.AutoSize = false;
            this.checkBoxEnableHeader.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEnableHeader, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEnableHeader, true);
            this.checkBoxEnableHeader.Location = new System.Drawing.Point(3, 93);
            this.checkBoxEnableHeader.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEnableHeader.Name = "checkBoxEnableHeader";
            this.checkBoxEnableHeader.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableHeader.TabIndex = 3;
            this.checkBoxEnableHeader.Text = "Header";
            // 
            // checkBoxEnableSort
            // 
            this.checkBoxEnableSort.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableSort.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableSort.AutoSize = false;
            this.checkBoxEnableSort.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEnableSort, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEnableSort, true);
            this.checkBoxEnableSort.Location = new System.Drawing.Point(3, 138);
            this.checkBoxEnableSort.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEnableSort.Name = "checkBoxEnableSort";
            this.checkBoxEnableSort.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableSort.TabIndex = 4;
            this.checkBoxEnableSort.Text = "Sort";
            // 
            // DataTable
            // 
            this.Name = "DataTable";
            this.Load += new System.EventHandler(this.DataTable_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.DataTable dataTable1;
        private CheckBox checkBoxEnableDrag;
        private CheckBox checkBoxEditable;
        private CheckBox checkBoxEnableHeader;
        private CheckBox checkBoxEnableSort;
    }
}
