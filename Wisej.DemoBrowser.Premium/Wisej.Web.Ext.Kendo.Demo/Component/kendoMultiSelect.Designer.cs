namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoMultiSelect
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
            this.kendoMultiSelect1 = new Wisej.Web.Ext.Kendo.kendoMultiSelect();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoMultiSelect1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/multiselect/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/multiselect";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/multiselect/overview";
            // 
            // kendoMultiSelect1
            // 
            this.kendoMultiSelect1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoMultiSelect1.Location = new System.Drawing.Point(394, 259);
            this.kendoMultiSelect1.Name = "kendoMultiSelect1";
            this.kendoMultiSelect1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"dataTextField\":\"text\",\"dataValueField\":\"value\",\"dataSource\":[{\"text\":\"Item1\",\"v" +
        "alue\":\"1\"},{\"text\":\"Item2\",\"value\":\"2\"}]}")));
            this.kendoMultiSelect1.Size = new System.Drawing.Size(300, 40);
            this.kendoMultiSelect1.TabIndex = 0;
            this.kendoMultiSelect1.Text = "kendoMultiSelect1";
            // 
            // kendoMultiSelect
            // 
            this.Name = "kendoMultiSelect";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoMultiSelect kendoMultiSelect1;
	}
}
