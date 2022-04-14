namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxScheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxScheduler));
            this.dxScheduler1 = new Wisej.Web.Ext.DevExtreme.dxScheduler();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Scheduler/Overview/";
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Scheduler/Overview/jQuery/Lig" +
    "ht/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxScheduler/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxScheduler1);
            // 
            // dxScheduler1
            // 
            this.dxScheduler1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxScheduler1.Location = new System.Drawing.Point(27, 17);
            this.dxScheduler1.Name = "dxScheduler1";
            this.dxScheduler1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxScheduler1.Options"))));
            this.dxScheduler1.Size = new System.Drawing.Size(1034, 524);
            this.dxScheduler1.TabIndex = 0;
            // 
            // dxScheduler
            // 
            this.MinimumSize = new System.Drawing.Size(1003, 615);
            this.Name = "dxScheduler";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxScheduler dxScheduler1;
	}
}
