namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class DateRange
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
            this.dateRange1 = new Wisej.Web.Ext.Webix.DateRange();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__daterange.html";
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(250, 451);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(16, 383);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#daterange";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://docs.webix.com/api__refs__ui.daterange.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dateRange1);
            this.panel.Size = new System.Drawing.Size(907, 451);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 325);
            // 
            // dateRange1
            // 
            this.dateRange1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dateRange1.Location = new System.Drawing.Point(52, 24);
            this.dateRange1.Name = "dateRange1";
            this.dateRange1.Size = new System.Drawing.Size(800, 400);
            this.dateRange1.TabIndex = 0;
            this.dateRange1.Text = "dateRange1";
            // 
            // DateRange
            // 
            this.MinimumSize = new System.Drawing.Size(1316, 641);
            this.Name = "DateRange";
            this.Size = new System.Drawing.Size(1316, 641);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.DateRange dateRange1;
	}
}
