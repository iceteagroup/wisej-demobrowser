namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoDatePicker
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
            this.kendoDatePicker1 = new Wisej.Web.Ext.Kendo.kendoDatePicker();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoDatePicker1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/datepicker/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/datepicker";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/datepicker/overview";
            // 
            // kendoDatePicker1
            // 
            this.kendoDatePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoDatePicker1.Location = new System.Drawing.Point(394, 259);
            this.kendoDatePicker1.Name = "kendoDatePicker1";
            this.kendoDatePicker1.Size = new System.Drawing.Size(300, 40);
            this.kendoDatePicker1.TabIndex = 0;
            this.kendoDatePicker1.Text = "kendoDatePicker1";
            // 
            // kendoDatePicker
            // 
            this.Name = "kendoDatePicker";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDatePicker kendoDatePicker1;
	}
}
