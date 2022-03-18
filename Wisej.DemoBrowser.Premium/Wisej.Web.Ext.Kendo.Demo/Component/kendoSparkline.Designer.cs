namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoSparkline
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
            this.kendoSparkline1 = new Wisej.Web.Ext.Kendo.kendoSparkline();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoSparkline1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/sparklines/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/sparkline";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/charts/sparkline/overview";
            // 
            // kendoSparkline1
            // 
            this.kendoSparkline1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoSparkline1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.kendoSparkline1.Location = new System.Drawing.Point(137, 65);
            this.kendoSparkline1.Name = "kendoSparkline1";
            this.kendoSparkline1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"data\":[936,968,1025,999,998,1014,1017,1010,1010,1007,1004,988,990,988,987,995,9" +
        "46,954,991,984,974,956,986,936,955,1021,1013,1005,958,953,952,940,937,980,966,96" +
        "5,928,916,910,980]}")));
            this.kendoSparkline1.Size = new System.Drawing.Size(814, 429);
            this.kendoSparkline1.TabIndex = 0;
            this.kendoSparkline1.Text = "kendoSparkline1";
            // 
            // kendoSparkline
            // 
            this.Name = "kendoSparkline";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoSparkline kendoSparkline1;
	}
}
