namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoBreadcrumb
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
            this.kendoBreadcrumb1 = new Wisej.Web.Ext.Kendo.kendoBreadcrumb();
            this.textBoxName = new Wisej.Web.TextBox();
            this.buttonAdd = new Wisej.Web.Button();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoBreadcrumb1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/breadcrumb/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/breadcrumb";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/breadcrumb/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.textBoxName);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonAdd);
            // 
            // kendoBreadcrumb1
            // 
            this.kendoBreadcrumb1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoBreadcrumb1.Location = new System.Drawing.Point(156, 137);
            this.kendoBreadcrumb1.Name = "kendoBreadcrumb1";
            this.kendoBreadcrumb1.Size = new System.Drawing.Size(776, 284);
            this.kendoBreadcrumb1.TabIndex = 0;
            this.kendoBreadcrumb1.Text = "kendoBreadcrumb1";
            // 
            // textBoxName
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.textBoxName, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.textBoxName, true);
            this.textBoxName.LabelText = "Item Name";
            this.textBoxName.Location = new System.Drawing.Point(3, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(212, 57);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Default";
            // 
            // buttonAdd
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.buttonAdd, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.buttonAdd, true);
            this.buttonAdd.Location = new System.Drawing.Point(3, 79);
            this.buttonAdd.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(212, 40);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // kendoBreadcrumb
            // 
            this.MinimumSize = new System.Drawing.Size(840, 503);
            this.Name = "kendoBreadcrumb";
            this.Load += new System.EventHandler(this.kendoBreadcrumb_Load);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoBreadcrumb kendoBreadcrumb1;
        private TextBox textBoxName;
        private Button buttonAdd;
    }
}
