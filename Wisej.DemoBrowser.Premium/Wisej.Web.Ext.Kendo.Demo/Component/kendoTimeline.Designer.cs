namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoTimeline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoTimeline));
            this.kendoTimeline1 = new Wisej.Web.Ext.Kendo.kendoTimeline();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoTimeline1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/timeline/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/timeline";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/timeline/overview";
            // 
            // kendoTimeline1
            // 
            this.kendoTimeline1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.kendoTimeline1.Location = new System.Drawing.Point(99, 64);
            this.kendoTimeline1.Name = "kendoTimeline1";
            this.kendoTimeline1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoTimeline1.Options"))));
            this.kendoTimeline1.Size = new System.Drawing.Size(890, 431);
            this.kendoTimeline1.TabIndex = 0;
            this.kendoTimeline1.Text = "kendoTimeline1";
            // 
            // kendoTimeline
            // 
            this.Name = "kendoTimeline";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoTimeline kendoTimeline1;
	}
}
