namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class RangeNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangeNavigator));
            this.rangeNavigator1 = new Wisej.Web.Ext.Syncfusion2.RangeNavigator();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/range-navigator/es5-getting-s" +
    "tarted/";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/range-navigator";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.rangeNavigator1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/range-navigator/default.html";
            // 
            // rangeNavigator1
            // 
            this.rangeNavigator1.Dock = Wisej.Web.DockStyle.Fill;
            this.rangeNavigator1.Location = new System.Drawing.Point(8, 8);
            this.rangeNavigator1.Name = "rangeNavigator1";
            this.rangeNavigator1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("rangeNavigator1.Options"))));
            this.rangeNavigator1.Size = new System.Drawing.Size(1073, 542);
            this.rangeNavigator1.TabIndex = 0;
            this.rangeNavigator1.Text = "rangeNavigator1";
            // 
            // RangeNavigator
            // 
            this.Name = "RangeNavigator";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.RangeNavigator rangeNavigator1;
	}
}
