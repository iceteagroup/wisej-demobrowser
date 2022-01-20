namespace Wisej.DemoBrowser.ListView
{
	partial class SelectionModes
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
            this.groupBox5 = new Wisej.Web.GroupBox();
            this.listView5 = new Wisej.Web.ListView();
            this.columnHeader4 = new Wisej.Web.ColumnHeader();
            this.groupBox6 = new Wisej.Web.GroupBox();
            this.listView6 = new Wisej.Web.ListView();
            this.columnHeader3 = new Wisej.Web.ColumnHeader();
            this.groupBox7 = new Wisej.Web.GroupBox();
            this.listView7 = new Wisej.Web.ListView();
            this.columnHeader2 = new Wisej.Web.ColumnHeader();
            this.groupBox8 = new Wisej.Web.GroupBox();
            this.listView8 = new Wisej.Web.ListView();
            this.columnHeader1 = new Wisej.Web.ColumnHeader();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.listView5);
            this.groupBox5.Location = new System.Drawing.Point(1050, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(328, 210);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.Text = "No selection";
            // 
            // listView5
            // 
            this.listView5.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader4});
            this.listView5.Dock = Wisej.Web.DockStyle.Fill;
            this.listView5.Location = new System.Drawing.Point(3, 18);
            this.listView5.Name = "listView5";
            this.listView5.SelectionMode = Wisej.Web.SelectionMode.None;
            this.listView5.Size = new System.Drawing.Size(322, 189);
            this.listView5.TabIndex = 0;
            this.listView5.View = Wisej.Web.View.Details;
            this.listView5.VirtualListSize = 20;
            this.listView5.VirtualMode = true;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "Items";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.listView6);
            this.groupBox6.Location = new System.Drawing.Point(715, 132);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(328, 210);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.Text = "MultiExtended selection mode";
            // 
            // listView6
            // 
            this.listView6.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader3});
            this.listView6.Dock = Wisej.Web.DockStyle.Fill;
            this.listView6.Location = new System.Drawing.Point(3, 18);
            this.listView6.MultiSelect = true;
            this.listView6.Name = "listView6";
            this.listView6.SelectionMode = Wisej.Web.SelectionMode.MultiExtended;
            this.listView6.Size = new System.Drawing.Size(322, 189);
            this.listView6.TabIndex = 0;
            this.listView6.View = Wisej.Web.View.Details;
            this.listView6.VirtualListSize = 20;
            this.listView6.VirtualMode = true;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Items";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox7.BackColor = System.Drawing.Color.White;
            this.groupBox7.Controls.Add(this.listView7);
            this.groupBox7.Location = new System.Drawing.Point(380, 132);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(328, 210);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.Text = "MultiSimple selection mode";
            // 
            // listView7
            // 
            this.listView7.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader2});
            this.listView7.Dock = Wisej.Web.DockStyle.Fill;
            this.listView7.Location = new System.Drawing.Point(3, 18);
            this.listView7.MultiSelect = true;
            this.listView7.Name = "listView7";
            this.listView7.SelectionMode = Wisej.Web.SelectionMode.MultiSimple;
            this.listView7.Size = new System.Drawing.Size(322, 189);
            this.listView7.TabIndex = 0;
            this.listView7.View = Wisej.Web.View.Details;
            this.listView7.VirtualListSize = 20;
            this.listView7.VirtualMode = true;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Items";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.listView8);
            this.groupBox8.Location = new System.Drawing.Point(45, 132);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(328, 210);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.Text = "Default selection mode";
            // 
            // listView8
            // 
            this.listView8.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader1});
            this.listView8.Dock = Wisej.Web.DockStyle.Fill;
            this.listView8.Location = new System.Drawing.Point(3, 18);
            this.listView8.Name = "listView8";
            this.listView8.Size = new System.Drawing.Size(322, 189);
            this.listView8.TabIndex = 0;
            this.listView8.View = Wisej.Web.View.Details;
            this.listView8.VirtualListSize = 20;
            this.listView8.VirtualMode = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Items";
            // 
            // SelectionModes
            // 
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Name = "SelectionModes";
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Web.GroupBox groupBox5;
		private Web.ListView listView5;
		private Web.ColumnHeader columnHeader4;
		private Web.GroupBox groupBox6;
		private Web.ListView listView6;
		private Web.ColumnHeader columnHeader3;
		private Web.GroupBox groupBox7;
		private Web.ListView listView7;
		private Web.ColumnHeader columnHeader2;
		private Web.GroupBox groupBox8;
		private Web.ListView listView8;
		private Web.ColumnHeader columnHeader1;
	}
}
