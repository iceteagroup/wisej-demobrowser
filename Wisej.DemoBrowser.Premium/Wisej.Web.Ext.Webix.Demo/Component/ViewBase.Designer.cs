namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class ViewBase
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
			this.components = new System.ComponentModel.Container();
			this.imageList1 = new Wisej.Web.ImageList(this.components);
			this.flowLayoutPanelExamples = new Wisej.Web.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(32, 16);
			// 
			// flowLayoutPanelExamples
			// 
			this.flowLayoutPanelExamples.AutoShow = Wisej.Web.PanelAutoShowMode.OnPointerOver;
			this.flowLayoutPanelExamples.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.flowLayoutPanelExamples.Collapsed = true;
			this.flowLayoutPanelExamples.CollapseSide = Wisej.Web.HeaderPosition.Left;
			this.flowLayoutPanelExamples.CssStyle = "border-right: 1px solid #E5E8E9 !important;";
			this.flowLayoutPanelExamples.Dock = Wisej.Web.DockStyle.Left;
			this.flowLayoutPanelExamples.HeaderBackColor = System.Drawing.Color.FromName("@gray-300");
			this.flowLayoutPanelExamples.HeaderForeColor = System.Drawing.Color.FromName("@windowText");
			this.flowLayoutPanelExamples.HeaderPosition = Wisej.Web.HeaderPosition.Left;
			this.flowLayoutPanelExamples.HeaderSize = 40;
			this.flowLayoutPanelExamples.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanelExamples.Name = "flowLayoutPanelExamples";
			this.flowLayoutPanelExamples.Padding = new Wisej.Web.Padding(16, 0, 0, 0);
			this.flowLayoutPanelExamples.RestoreBounds = new System.Drawing.Rectangle(0, 0, 232, 477);
			this.flowLayoutPanelExamples.ShowCloseButton = false;
			this.flowLayoutPanelExamples.ShowHeader = true;
			this.flowLayoutPanelExamples.Size = new System.Drawing.Size(42, 477);
			this.flowLayoutPanelExamples.TabIndex = 10;
			this.flowLayoutPanelExamples.Text = "Configuration";
			// 
			// ViewBase
			// 
			this.Controls.Add(this.flowLayoutPanelExamples);
			this.Name = "ViewBase";
			this.Size = new System.Drawing.Size(1530, 477);
			this.ResumeLayout(false);

		}

		#endregion
		private ImageList imageList1;
		public FlowLayoutPanel flowLayoutPanelExamples;
	}
}
