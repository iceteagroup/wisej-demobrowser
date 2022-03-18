namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class RangeChart
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
			this.rangeChart1 = new Wisej.Web.Ext.Webix.RangeChart();
			this.SuspendLayout();
			// 
			// rangeChart1
			// 
			this.rangeChart1.Anchor = Wisej.Web.AnchorStyles.None;
			this.rangeChart1.Location = new System.Drawing.Point(515, 38);
			this.rangeChart1.Name = "rangeChart1";
			this.rangeChart1.Size = new System.Drawing.Size(500, 400);
			this.rangeChart1.TabIndex = 0;
			this.rangeChart1.Text = "rangeChart1";
			// 
			// RangeChart
			// 
			this.Controls.Add(this.rangeChart1);
			this.Name = "RangeChart";
			this.Controls.SetChildIndex(this.rangeChart1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.RangeChart rangeChart1;
	}
}
