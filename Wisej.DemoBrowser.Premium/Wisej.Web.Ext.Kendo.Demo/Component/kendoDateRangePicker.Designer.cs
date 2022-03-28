namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoDateRangePicker
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
            this.kendoDateRangePicker1 = new Wisej.Web.Ext.Kendo.kendoDateRangePicker();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoDateRangePicker1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/daterangepicker/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/daterangepicker";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/daterangepicker/overview";
            // 
            // kendoDateRangePicker1
            // 
            this.kendoDateRangePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoDateRangePicker1.Location = new System.Drawing.Point(342, 209);
            this.kendoDateRangePicker1.Name = "kendoDateRangePicker1";
            this.kendoDateRangePicker1.Size = new System.Drawing.Size(404, 140);
            this.kendoDateRangePicker1.TabIndex = 0;
            this.kendoDateRangePicker1.Text = "kendoDateRangePicker1";
            // 
            // kendoDateRangePicker
            // 
            this.Name = "kendoDateRangePicker";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDateRangePicker kendoDateRangePicker1;
	}
}
