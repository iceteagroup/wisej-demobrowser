namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class ExcelViewer
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
            this.excelViewer1 = new Wisej.Web.Ext.Webix.ExcelViewer();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.excelViewer1);
            // 
            // excelViewer1
            // 
            this.excelViewer1.Dock = Wisej.Web.DockStyle.Fill;
            this.excelViewer1.Location = new System.Drawing.Point(8, 8);
            this.excelViewer1.Name = "excelViewer1";
            this.excelViewer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"url\":\"binary->https://docs.webix.com/samples/60_pro/10_viewers/files/data.xlsx\"" +
        "}")));
            this.excelViewer1.Size = new System.Drawing.Size(1073, 542);
            this.excelViewer1.TabIndex = 0;
            this.excelViewer1.Text = "excelViewer1";
            // 
            // ExcelViewer
            // 
            this.Name = "ExcelViewer";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.ExcelViewer excelViewer1;
	}
}
