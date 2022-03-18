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
			this.SuspendLayout();
			// 
			// excelViewer1
			// 
			this.excelViewer1.Anchor = Wisej.Web.AnchorStyles.None;
			this.excelViewer1.Location = new System.Drawing.Point(515, 38);
			this.excelViewer1.Name = "excelViewer1";
			this.excelViewer1.Size = new System.Drawing.Size(500, 400);
			this.excelViewer1.TabIndex = 0;
			this.excelViewer1.Text = "excelViewer1";
			// 
			// ExcelViewer
			// 
			this.Controls.Add(this.excelViewer1);
			this.Name = "ExcelViewer";
			this.Controls.SetChildIndex(this.excelViewer1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.ExcelViewer excelViewer1;
	}
}
