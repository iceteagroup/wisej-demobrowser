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
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__grouplist.html";
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
            this.checkBoxEnableSelect.Location = new System.Drawing.Point(3, 3);
            this.checkBoxEnableSelect.Name = "checkBoxEnableSelect";
            this.checkBoxEnableSelect.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableSelect.TabIndex = 5;
            this.checkBoxEnableSelect.Text = "Enable select";
            // 
            // checkBoxEnableDragAndDrop
            // 
            this.checkBoxEnableDragAndDrop.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxEnableDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxEnableDragAndDrop.AutoSize = false;
            this.checkBoxEnableDragAndDrop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEnableDragAndDrop.Location = new System.Drawing.Point(3, 35);
            this.checkBoxEnableDragAndDrop.Name = "checkBoxEnableDragAndDrop";
            this.checkBoxEnableDragAndDrop.Size = new System.Drawing.Size(212, 26);
            this.checkBoxEnableDragAndDrop.TabIndex = 6;
            this.checkBoxEnableDragAndDrop.Text = "Enable drag and drop";
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
