namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoDropDownTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoDropDownTree));
            this.kendoDropDownTree1 = new Wisej.Web.Ext.Kendo.kendoDropDownTree();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoDropDownTree1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/dropdowntree/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/dropdowntree";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/dropdowntree/overview";
            // 
            // kendoDropDownTree1
            // 
            this.kendoDropDownTree1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoDropDownTree1.Location = new System.Drawing.Point(394, 259);
            this.kendoDropDownTree1.Name = "kendoDropDownTree1";
            this.kendoDropDownTree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoDropDownTree1.Options"))));
            this.kendoDropDownTree1.Size = new System.Drawing.Size(300, 40);
            this.kendoDropDownTree1.TabIndex = 0;
            this.kendoDropDownTree1.Text = "kendoDropDownTree1";
            // 
            // kendoDropDownTree
            // 
            this.Name = "kendoDropDownTree";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDropDownTree kendoDropDownTree1;
	}
}
