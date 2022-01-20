
namespace Wisej.DemoBrowser.ListView
{
    partial class Appearances
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
			Wisej.Web.ImageListEntry imageListEntry1 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.ListView/abiword_48.png", "abiword_48");
			Wisej.Web.ImageListEntry imageListEntry2 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.ListView/bmp.png", "bmp");
			Wisej.Web.ImageListEntry imageListEntry3 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.ListView/evolution.png", "evolution");
			Wisej.Web.ImageListEntry imageListEntry4 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.ListView/disks.png", "disks");
			Wisej.Web.ImageListEntry imageListEntry5 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.ListView/abiword_48.png", "abiword_48");
			Wisej.Web.ImageListEntry imageListEntry6 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.ListView/bmp.png", "bmp");
			Wisej.Web.ImageListEntry imageListEntry7 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.ListView/evolution.png", "evolution");
			Wisej.Web.ImageListEntry imageListEntry8 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.ListView/disks.png", "disks");
			this.listViewLargeIcons = new Wisej.Web.ListView();
			this.LargeImages = new Wisej.Web.ImageList(this.components);
			this.SmallImages = new Wisej.Web.ImageList(this.components);
			this.listViewSmallIcons = new Wisej.Web.ListView();
			this.listViewDetails = new Wisej.Web.ListView();
			this.listViewTiles = new Wisej.Web.ListView();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.label3 = new Wisej.Web.Label();
			this.label4 = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// listViewLargeIcons
			// 
			this.listViewLargeIcons.Anchor = Wisej.Web.AnchorStyles.None;
			this.listViewLargeIcons.ItemSize = new System.Drawing.Size(151, 75);
			this.listViewLargeIcons.LargeImageList = this.LargeImages;
			this.listViewLargeIcons.Location = new System.Drawing.Point(16, 64);
			this.listViewLargeIcons.Name = "listViewLargeIcons";
			this.listViewLargeIcons.Size = new System.Drawing.Size(322, 371);
			this.listViewLargeIcons.SmallImageList = this.SmallImages;
			this.listViewLargeIcons.TabIndex = 0;
			this.listViewLargeIcons.SelectedIndexChanged += new System.EventHandler(this.listViewLargeIcons_SelectedIndexChanged);
			this.listViewLargeIcons.RetrieveVirtualItem += new Wisej.Web.RetrieveVirtualItemEventHandler(this.listView_RetrieveVirtualItem);
			// 
			// LargeImages
			// 
			this.LargeImages.Images.AddRange(new Wisej.Web.ImageListEntry[] {
            imageListEntry1,
            imageListEntry2,
            imageListEntry3,
            imageListEntry4});
			this.LargeImages.ImageSize = new System.Drawing.Size(32, 32);
			// 
			// SmallImages
			// 
			this.SmallImages.Images.AddRange(new Wisej.Web.ImageListEntry[] {
            imageListEntry5,
            imageListEntry6,
            imageListEntry7,
            imageListEntry8});
			// 
			// listViewSmallIcons
			// 
			this.listViewSmallIcons.Anchor = Wisej.Web.AnchorStyles.None;
			this.listViewSmallIcons.ItemSize = new System.Drawing.Size(100, 75);
			this.listViewSmallIcons.LargeImageList = this.LargeImages;
			this.listViewSmallIcons.Location = new System.Drawing.Point(372, 64);
			this.listViewSmallIcons.Name = "listViewSmallIcons";
			this.listViewSmallIcons.Size = new System.Drawing.Size(322, 371);
			this.listViewSmallIcons.SmallImageList = this.SmallImages;
			this.listViewSmallIcons.TabIndex = 0;
			this.listViewSmallIcons.View = Wisej.Web.View.SmallIcon;
			this.listViewSmallIcons.RetrieveVirtualItem += new Wisej.Web.RetrieveVirtualItemEventHandler(this.listView_RetrieveVirtualItem);
			// 
			// listViewDetails
			// 
			this.listViewDetails.Anchor = Wisej.Web.AnchorStyles.None;
			this.listViewDetails.LargeImageList = this.LargeImages;
			this.listViewDetails.Location = new System.Drawing.Point(728, 64);
			this.listViewDetails.Name = "listViewDetails";
			this.listViewDetails.Size = new System.Drawing.Size(322, 371);
			this.listViewDetails.SmallImageList = this.SmallImages;
			this.listViewDetails.TabIndex = 0;
			this.listViewDetails.View = Wisej.Web.View.Details;
			this.listViewDetails.RetrieveVirtualItem += new Wisej.Web.RetrieveVirtualItemEventHandler(this.listView_RetrieveVirtualItem);
			// 
			// listViewTiles
			// 
			this.listViewTiles.Anchor = Wisej.Web.AnchorStyles.None;
			this.listViewTiles.ItemSize = new System.Drawing.Size(151, 100);
			this.listViewTiles.LargeImageList = this.LargeImages;
			this.listViewTiles.Location = new System.Drawing.Point(1084, 64);
			this.listViewTiles.Name = "listViewTiles";
			this.listViewTiles.Size = new System.Drawing.Size(322, 371);
			this.listViewTiles.SmallImageList = this.SmallImages;
			this.listViewTiles.TabIndex = 0;
			this.listViewTiles.View = Wisej.Web.View.Tile;
			this.listViewTiles.RetrieveVirtualItem += new Wisej.Web.RetrieveVirtualItemEventHandler(this.listView_RetrieveVirtualItem);
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 18);
			this.label1.TabIndex = 8;
			this.label1.Text = "Large Icons";
			// 
			// label2
			// 
			this.label2.Anchor = Wisej.Web.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(372, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 18);
			this.label2.TabIndex = 9;
			this.label2.Text = "Small Icons";
			// 
			// label3
			// 
			this.label3.Anchor = Wisej.Web.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(728, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 18);
			this.label3.TabIndex = 10;
			this.label3.Text = "Details";
			// 
			// label4
			// 
			this.label4.Anchor = Wisej.Web.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(1084, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 18);
			this.label4.TabIndex = 11;
			this.label4.Text = "Tiles";
			// 
			// Features
			// 
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listViewTiles);
			this.Controls.Add(this.listViewDetails);
			this.Controls.Add(this.listViewSmallIcons);
			this.Controls.Add(this.listViewLargeIcons);
			this.MinimumSize = new System.Drawing.Size(1422, 417);
			this.Name = "Features";
			this.Load += new System.EventHandler(this.VirtualScrolling_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Web.ListView listViewLargeIcons;
        private Web.ImageList LargeImages;
        private Web.ImageList SmallImages;
        private Web.ListView listViewSmallIcons;
        private Web.ListView listViewDetails;
        private Web.ListView listViewTiles;
		private Web.Label label1;
		private Web.Label label2;
		private Web.Label label3;
		private Web.Label label4;
	}
}
