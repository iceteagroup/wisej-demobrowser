namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class GroupList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupList));
            this.groupList1 = new Wisej.Web.Ext.Webix.GroupList();
            this.checkBoxEnableSelect = new Wisej.Web.CheckBox();
            this.checkBoxEnableDragAndDrop = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#grouplist";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.grouplist.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.groupList1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableSelect);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEnableDragAndDrop);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 434);
            // 
            // groupList1
            // 
            this.groupList1.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupList1.Location = new System.Drawing.Point(294, 79);
            this.groupList1.Name = "groupList1";
            this.groupList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("groupList1.Options"))));
            this.groupList1.Size = new System.Drawing.Size(500, 400);
            this.groupList1.TabIndex = 0;
            this.groupList1.Text = "groupList1";
            // 
            // checkBoxEnableSelect
            // 
            this.checkBoxEnableSelect.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableSelect.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableSelect.AutoSize = false;
            this.checkBoxEnableSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEnableSelect, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEnableSelect, true);
            this.checkBoxEnableSelect.Location = new System.Drawing.Point(3, 3);
            this.checkBoxEnableSelect.Name = "checkBoxEnableSelect";
            this.checkBoxEnableSelect.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableSelect.TabIndex = 5;
            this.checkBoxEnableSelect.Text = "Enable Select";
            // 
            // checkBoxEnableDragAndDrop
            // 
            this.checkBoxEnableDragAndDrop.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableDragAndDrop.AutoSize = false;
            this.checkBoxEnableDragAndDrop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEnableDragAndDrop, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEnableDragAndDrop, true);
            this.checkBoxEnableDragAndDrop.Location = new System.Drawing.Point(3, 48);
            this.checkBoxEnableDragAndDrop.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEnableDragAndDrop.Name = "checkBoxEnableDragAndDrop";
            this.checkBoxEnableDragAndDrop.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableDragAndDrop.TabIndex = 6;
            this.checkBoxEnableDragAndDrop.Text = "Drag-and-Drop";
            // 
            // GroupList
            // 
            this.Name = "GroupList";
            this.Load += new System.EventHandler(this.GroupList_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.GroupList groupList1;
        private CheckBox checkBoxEnableSelect;
        private CheckBox checkBoxEnableDragAndDrop;
    }
}
