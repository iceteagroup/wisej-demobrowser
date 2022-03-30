namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Kanban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kanban));
            this.kanban1 = new Wisej.Web.Ext.Syncfusion2.Kanban();
            this.checkBoxDragAndDrop = new Wisej.Web.CheckBox();
            this.checkBoxKeyboard = new Wisej.Web.CheckBox();
            this.checkBoxColumnToggle = new Wisej.Web.CheckBox();
            this.checkBoxEmptyColumn = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/kanban/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/kanban/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kanban1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxDragAndDrop);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxKeyboard);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxColumnToggle);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEmptyColumn);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/kanban/overview.html";
            // 
            // kanban1
            // 
            this.kanban1.Dock = Wisej.Web.DockStyle.Fill;
            this.kanban1.Location = new System.Drawing.Point(8, 8);
            this.kanban1.Name = "kanban1";
            this.kanban1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kanban1.Options"))));
            this.kanban1.Size = new System.Drawing.Size(1073, 542);
            this.kanban1.TabIndex = 0;
            this.kanban1.Text = "kanban1";
            // 
            // checkBoxDragAndDrop
            // 
            this.checkBoxDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDragAndDrop.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxDragAndDrop, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxDragAndDrop, true);
            this.checkBoxDragAndDrop.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDragAndDrop.Name = "checkBoxDragAndDrop";
            this.checkBoxDragAndDrop.Size = new System.Drawing.Size(212, 24);
            this.checkBoxDragAndDrop.TabIndex = 8;
            this.checkBoxDragAndDrop.Text = "Allow Drag-and-Drop";
            // 
            // checkBoxKeyboard
            // 
            this.checkBoxKeyboard.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxKeyboard, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxKeyboard, true);
            this.checkBoxKeyboard.Location = new System.Drawing.Point(3, 46);
            this.checkBoxKeyboard.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxKeyboard.Name = "checkBoxKeyboard";
            this.checkBoxKeyboard.Size = new System.Drawing.Size(212, 24);
            this.checkBoxKeyboard.TabIndex = 9;
            this.checkBoxKeyboard.Text = "Allow Keyboard";
            // 
            // checkBoxColumnToggle
            // 
            this.checkBoxColumnToggle.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxColumnToggle, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxColumnToggle, true);
            this.checkBoxColumnToggle.Location = new System.Drawing.Point(3, 89);
            this.checkBoxColumnToggle.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxColumnToggle.Name = "checkBoxColumnToggle";
            this.checkBoxColumnToggle.Size = new System.Drawing.Size(212, 24);
            this.checkBoxColumnToggle.TabIndex = 10;
            this.checkBoxColumnToggle.Text = "Allow Columns Toggle";
            // 
            // checkBoxEmptyColumn
            // 
            this.checkBoxEmptyColumn.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxEmptyColumn, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxEmptyColumn, true);
            this.checkBoxEmptyColumn.Location = new System.Drawing.Point(3, 132);
            this.checkBoxEmptyColumn.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxEmptyColumn.Name = "checkBoxEmptyColumn";
            this.checkBoxEmptyColumn.Size = new System.Drawing.Size(212, 24);
            this.checkBoxEmptyColumn.TabIndex = 11;
            this.checkBoxEmptyColumn.Text = "Show Empty Column";
            // 
            // Kanban
            // 
            this.Name = "Kanban";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Kanban kanban1;
        private CheckBox checkBoxColumnToggle;
        private CheckBox checkBoxKeyboard;
        private CheckBox checkBoxDragAndDrop;
        private CheckBox checkBoxEmptyColumn;
    }
}
