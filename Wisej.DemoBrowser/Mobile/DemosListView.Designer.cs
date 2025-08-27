namespace Wisej.DemoBrowser
{
	public partial class DemosListView
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
            this.flowLayoutPanelDemos = new Wisej.Web.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelDemos
            // 
            this.flowLayoutPanelDemos.AutoScroll = true;
            this.flowLayoutPanelDemos.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanelDemos.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanelDemos.Location = new System.Drawing.Point(16, 180);
            this.flowLayoutPanelDemos.Name = "flowLayoutPanelDemos";
            this.flowLayoutPanelDemos.ScrollBars = Wisej.Web.ScrollBars.Hidden;
            this.flowLayoutPanelDemos.Size = new System.Drawing.Size(1390, 294);
            this.flowLayoutPanelDemos.TabIndex = 20;
            this.flowLayoutPanelDemos.Scroll += new Wisej.Web.ScrollEventHandler(this.flowLayoutPanelApps_Scroll);
            // 
            // DemosListView
            // 
            this.Controls.Add(this.flowLayoutPanelDemos);
            this.Name = "DemosListView";
            this.Load += new System.EventHandler(this.DemosListView_Load);
            this.Controls.SetChildIndex(this.labelDescription, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanelDemos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private Web.FlowLayoutPanel flowLayoutPanelApps;
		private Web.FlowLayoutPanel flowLayoutPanelDemos;
    }
}
