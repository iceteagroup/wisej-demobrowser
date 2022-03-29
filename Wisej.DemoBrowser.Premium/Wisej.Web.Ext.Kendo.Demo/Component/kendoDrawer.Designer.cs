namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoDrawer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoDrawer));
            this.buttonShow = new Wisej.Web.Button();
            this.buttonHide = new Wisej.Web.Button();
            this.kendoDrawer1 = new Wisej.Web.Ext.Kendo.kendoDrawer();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoDrawer1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHide);
            this.groupBox1.Controls.Add(this.buttonShow);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonShow, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonHide, 0);
            this.groupBox1.Controls.SetChildIndex(this.flowLayoutPanelProperties, 0);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/drawer/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/drawer";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/drawer/overview";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(28, 49);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(195, 35);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(28, 90);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(195, 35);
            this.buttonHide.TabIndex = 2;
            this.buttonHide.Text = "Hide";
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // kendoDrawer1
            // 
            this.kendoDrawer1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoDrawer1.Location = new System.Drawing.Point(434, 112);
            this.kendoDrawer1.Name = "kendoDrawer1";
            this.kendoDrawer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoDrawer1.Options"))));
            this.kendoDrawer1.Size = new System.Drawing.Size(232, 334);
            this.kendoDrawer1.TabIndex = 0;
            this.kendoDrawer1.Text = "kendoDrawer1";
            // 
            // kendoDrawer
            // 
            this.Name = "kendoDrawer";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDrawer kendoDrawer1;
		private Button buttonHide;
		private Button buttonShow;
	}
}
