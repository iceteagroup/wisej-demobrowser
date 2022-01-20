namespace Wisej.DemoBrowser.ListView
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
            this.listView1 = new Wisej.Web.ListView();
            this.columnHeader1 = new Wisej.Web.ColumnHeader();
            this.columnHeader2 = new Wisej.Web.ColumnHeader();
            this.columnHeader3 = new Wisej.Web.ColumnHeader();
            this.listView2 = new Wisej.Web.ListView();
            this.columnHeader4 = new Wisej.Web.ColumnHeader();
            this.columnHeader5 = new Wisej.Web.ColumnHeader();
            this.columnHeader6 = new Wisej.Web.ColumnHeader();
            this.listView3 = new Wisej.Web.ListView();
            this.columnHeader7 = new Wisej.Web.ColumnHeader();
            this.columnHeader8 = new Wisej.Web.ColumnHeader();
            this.columnHeader9 = new Wisej.Web.ColumnHeader();
            this.listView4 = new Wisej.Web.ListView();
            this.columnHeader10 = new Wisej.Web.ColumnHeader();
            this.columnHeader11 = new Wisej.Web.ColumnHeader();
            this.columnHeader12 = new Wisej.Web.ColumnHeader();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.groupBox3 = new Wisej.Web.GroupBox();
            this.groupBox4 = new Wisej.Web.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = Wisej.Web.DockStyle.Fill;
            this.listView1.ItemSize = new System.Drawing.Size(256, 256);
            this.listView1.Location = new System.Drawing.Point(3, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(335, 415);
            this.listView1.TabIndex = 0;
            this.listView1.VirtualListSize = 20;
            this.listView1.VirtualMode = true;
            this.listView1.RetrieveVirtualItem += new Wisej.Web.RetrieveVirtualItemEventHandler(this.listView1_RetrieveVirtualItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Full name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Address";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Phone Number";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.Dock = Wisej.Web.DockStyle.Fill;
            this.listView2.ItemSize = new System.Drawing.Size(256, 128);
            this.listView2.Location = new System.Drawing.Point(3, 18);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(335, 415);
            this.listView2.TabIndex = 1;
            this.listView2.View = Wisej.Web.View.SmallIcon;
            this.listView2.VirtualListSize = 20;
            this.listView2.VirtualMode = true;
            this.listView2.RetrieveVirtualItem += new Wisej.Web.RetrieveVirtualItemEventHandler(this.listView1_RetrieveVirtualItem);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "Full name";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            this.columnHeader5.Text = "Address";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            this.columnHeader6.Text = "Phone Number";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView3.Dock = Wisej.Web.DockStyle.Fill;
            this.listView3.Location = new System.Drawing.Point(3, 18);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(335, 415);
            this.listView3.TabIndex = 2;
            this.listView3.View = Wisej.Web.View.Details;
            this.listView3.VirtualListSize = 20;
            this.listView3.VirtualMode = true;
            this.listView3.RetrieveVirtualItem += new Wisej.Web.RetrieveVirtualItemEventHandler(this.listView1_RetrieveVirtualItem);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Name = "columnHeader7";
            this.columnHeader7.Text = "Full name";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Name = "columnHeader8";
            this.columnHeader8.Text = "Address";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Name = "columnHeader9";
            this.columnHeader9.Text = "Phone Number";
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView4.Dock = Wisej.Web.DockStyle.Fill;
            this.listView4.ItemSize = new System.Drawing.Size(256, 256);
            this.listView4.Location = new System.Drawing.Point(3, 18);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(335, 415);
            this.listView4.TabIndex = 3;
            this.listView4.View = Wisej.Web.View.Tile;
            this.listView4.VirtualListSize = 20;
            this.listView4.VirtualMode = true;
            this.listView4.RetrieveVirtualItem += new Wisej.Web.RetrieveVirtualItemEventHandler(this.listView1_RetrieveVirtualItem);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Name = "columnHeader10";
            this.columnHeader10.Text = "Full name";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Name = "columnHeader11";
            this.columnHeader11.Text = "Address";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Name = "columnHeader12";
            this.columnHeader12.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(19, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 436);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.Text = "LargeIcon view";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Location = new System.Drawing.Point(367, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 436);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.Text = "SmallIcon view";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.listView3);
            this.groupBox3.Location = new System.Drawing.Point(715, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 436);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.Text = "Details view";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.listView4);
            this.groupBox4.Location = new System.Drawing.Point(1063, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 436);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.Text = "Tile view";
            // 
            // Features
            // 
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private Web.ListView listView1;
        private Web.ColumnHeader columnHeader1;
        private Web.ColumnHeader columnHeader2;
        private Web.ColumnHeader columnHeader3;
        private Web.ListView listView2;
        private Web.ColumnHeader columnHeader4;
        private Web.ColumnHeader columnHeader5;
        private Web.ColumnHeader columnHeader6;
        private Web.ListView listView3;
        private Web.ColumnHeader columnHeader7;
        private Web.ColumnHeader columnHeader8;
        private Web.ColumnHeader columnHeader9;
        private Web.ListView listView4;
        private Web.ColumnHeader columnHeader10;
        private Web.ColumnHeader columnHeader11;
        private Web.ColumnHeader columnHeader12;
        private Web.GroupBox groupBox1;
        private Web.GroupBox groupBox2;
        private Web.GroupBox groupBox3;
        private Web.GroupBox groupBox4;
    }
}
