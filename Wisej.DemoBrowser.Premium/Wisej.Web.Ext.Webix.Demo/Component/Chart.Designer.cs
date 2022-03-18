namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Chart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
			this.chart1 = new Wisej.Web.Ext.Webix.Chart();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.Anchor = Wisej.Web.AnchorStyles.None;
			this.chart1.Location = new System.Drawing.Point(515, 38);
			this.chart1.Name = "chart1";
			this.chart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("chart1.Options"))));
			this.chart1.Size = new System.Drawing.Size(500, 400);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// Chart
			// 
			this.Controls.Add(this.chart1);
			this.Name = "Chart";
			this.Controls.SetChildIndex(this.chart1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.Chart chart1;
	}
}
