namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class DataTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTable));
            this.dataTable1 = new Wisej.Web.Ext.Webix.DataTable();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dataTable1);
            // 
            // dataTable1
            // 
            this.dataTable1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataTable1.Location = new System.Drawing.Point(8, 8);
            this.dataTable1.Name = "dataTable1";
            this.dataTable1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dataTable1.Options"))));
            this.dataTable1.Size = new System.Drawing.Size(1073, 542);
            this.dataTable1.TabIndex = 0;
            this.dataTable1.Text = "dataTable1";
            // 
            // DataTable
            // 
            this.Name = "DataTable";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.DataTable dataTable1;
	}
}
