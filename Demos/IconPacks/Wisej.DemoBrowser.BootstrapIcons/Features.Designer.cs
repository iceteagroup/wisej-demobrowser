namespace Wisej.DemoBrowser.BootstrapIcons

{
	partial class Features
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
            this.listViewIcons = new Wisej.Web.ListView();
            this.imageListIcons = new Wisej.Web.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listViewIcons
            // 
            this.listViewIcons.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.listViewIcons.BorderStyle = Wisej.Web.BorderStyle.None;
            this.listViewIcons.CssClass = "shadow";
            this.listViewIcons.LabelWrap = true;
            this.listViewIcons.LargeImageList = this.imageListIcons;
            this.listViewIcons.Location = new System.Drawing.Point(58, 26);
            this.listViewIcons.Name = "listViewIcons";
            this.listViewIcons.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("listViewIcons.ResponsiveProfiles"))));
            this.listViewIcons.Scrollable = false;
            this.listViewIcons.SelectionMode = Wisej.Web.SelectionMode.None;
            this.listViewIcons.Size = new System.Drawing.Size(1307, 423);
            this.listViewIcons.TabIndex = 0;
            this.listViewIcons.VirtualMode = true;
            this.listViewIcons.SelectedIndexChanged += new System.EventHandler(this.listViewIcons_SelectedIndexChanged);
            this.listViewIcons.RetrieveVirtualItem += new Wisej.Web.RetrieveVirtualItemEventHandler(this.listViewIcons_RetrieveVirtualItem);
            this.listViewIcons.Appear += new System.EventHandler(this.listViewIcons_Appear);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageSize = new System.Drawing.Size(30, 30);
            // 
            // Features
            // 
            this.Controls.Add(this.listViewIcons);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private Web.ListView listViewIcons;
		private Web.ImageList imageListIcons;
	}
}
