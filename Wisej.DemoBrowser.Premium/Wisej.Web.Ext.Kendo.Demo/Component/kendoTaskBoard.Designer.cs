
namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoTaskBoard
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
			this.kendoTaskBoard1 = new Wisej.Web.Ext.Kendo.kendoTaskBoard();
			this.checkBoxEditable = new Wisej.Web.CheckBox();
			this.checkBoxSelectable = new Wisej.Web.CheckBox();
			this.checkBoxReorderable = new Wisej.Web.CheckBox();
			this.checkBoxToolbar = new Wisej.Web.CheckBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoTaskBoard1);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/taskboard/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/taskboard";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/data-management/taskboard/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBoxEditable);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBoxReorderable);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBoxSelectable);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBoxToolbar);
			// 
			// kendoTaskBoard1
			// 
			this.kendoTaskBoard1.Dock = Wisej.Web.DockStyle.Fill;
			this.kendoTaskBoard1.Location = new System.Drawing.Point(8, 8);
			this.kendoTaskBoard1.Name = "kendoTaskBoard1";
			this.kendoTaskBoard1.Size = new System.Drawing.Size(872, 560);
			this.kendoTaskBoard1.TabIndex = 0;
			this.kendoTaskBoard1.Text = "kendoTaskBoard1";
			this.kendoTaskBoard1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.kendoTaskBoard1_WidgetEvent);
			// 
			// checkBoxEditable
			// 
			this.checkBoxEditable.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.checkBoxEditable.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxEditable.AutoSize = false;
			this.checkBoxEditable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxEditable.Checked = true;
			this.checkBoxEditable.Location = new System.Drawing.Point(3, 3);
			this.checkBoxEditable.Name = "checkBoxEditable";
			this.checkBoxEditable.Size = new System.Drawing.Size(212, 44);
			this.checkBoxEditable.TabIndex = 0;
			this.checkBoxEditable.Text = "Editable";
			// 
			// checkBoxSelectable
			// 
			this.checkBoxSelectable.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.checkBoxSelectable.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxSelectable.AutoSize = false;
			this.checkBoxSelectable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxSelectable.Checked = true;
			this.checkBoxSelectable.Location = new System.Drawing.Point(3, 103);
			this.checkBoxSelectable.Name = "checkBoxSelectable";
			this.checkBoxSelectable.Size = new System.Drawing.Size(212, 44);
			this.checkBoxSelectable.TabIndex = 1;
			this.checkBoxSelectable.Text = "Selectable";
			// 
			// checkBoxReorderable
			// 
			this.checkBoxReorderable.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.checkBoxReorderable.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxReorderable.AutoSize = false;
			this.checkBoxReorderable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxReorderable.Checked = true;
			this.checkBoxReorderable.Location = new System.Drawing.Point(3, 53);
			this.checkBoxReorderable.Name = "checkBoxReorderable";
			this.checkBoxReorderable.Size = new System.Drawing.Size(212, 44);
			this.checkBoxReorderable.TabIndex = 2;
			this.checkBoxReorderable.Text = "Reorderable";
			// 
			// checkBoxToolbar
			// 
			this.checkBoxToolbar.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.checkBoxToolbar.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxToolbar.AutoSize = false;
			this.checkBoxToolbar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxToolbar.Checked = true;
			this.checkBoxToolbar.Location = new System.Drawing.Point(3, 153);
			this.checkBoxToolbar.Name = "checkBoxToolbar";
			this.checkBoxToolbar.Size = new System.Drawing.Size(212, 44);
			this.checkBoxToolbar.TabIndex = 3;
			this.checkBoxToolbar.Text = "Toolbar";
			// 
			// kendoTaskBoard
			// 
			this.Name = "kendoTaskBoard";
			this.Load += new System.EventHandler(this.kendoTaskBoard_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoTaskBoard kendoTaskBoard1;
        private CheckBox checkBoxEditable;
        private CheckBox checkBoxSelectable;
        private CheckBox checkBoxReorderable;
        private CheckBox checkBoxToolbar;
    }
}
