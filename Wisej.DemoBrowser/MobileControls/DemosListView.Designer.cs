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
            this.labelTitle = new Wisej.Web.Label();
            this.flowLayoutPanelDemos = new Wisej.Web.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.CssStyle = "transition: font-size 0.25s;";
            this.labelTitle.Dock = Wisej.Web.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("@condensedWindowTitle", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.Location = new System.Drawing.Point(16, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1390, 128);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Wisej.NET Demos";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelDemos
            // 
            this.flowLayoutPanelDemos.AutoScroll = true;
            this.flowLayoutPanelDemos.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.flowLayoutPanelDemos.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanelDemos.Location = new System.Drawing.Point(16, 128);
            this.flowLayoutPanelDemos.Name = "flowLayoutPanelDemos";
            this.flowLayoutPanelDemos.ScrollBars = Wisej.Web.ScrollBars.Hidden;
            this.flowLayoutPanelDemos.Size = new System.Drawing.Size(1390, 346);
            this.flowLayoutPanelDemos.TabIndex = 20;
            this.flowLayoutPanelDemos.Scroll += new Wisej.Web.ScrollEventHandler(this.flowLayoutPanelApps_Scroll);
            // 
            // DemosListView
            // 
            this.Controls.Add(this.flowLayoutPanelDemos);
            this.Controls.Add(this.labelTitle);
            this.Name = "DemosListView";
            this.Padding = new Wisej.Web.Padding(16, 0, 16, 0);
            this.Load += new System.EventHandler(this.DemosListView_Load);
            this.ResumeLayout(false);

		}

		#endregion
		private Web.FlowLayoutPanel flowLayoutPanelApps;
		private Web.Label labelTitle;
		private Web.FlowLayoutPanel flowLayoutPanelDemos;
    }
}
