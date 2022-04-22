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
            this.listViewDemo = new Wisej.Web.ListView();
            this.columnHeader7 = new Wisej.Web.ColumnHeader();
            this.columnHeader8 = new Wisej.Web.ColumnHeader();
            this.columnHeader9 = new Wisej.Web.ColumnHeader();
            this.comboBoxView = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // listViewDemo
            // 
            this.listViewDemo.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.listViewDemo.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewDemo.ItemPadding = new Wisej.Web.Padding(8, 3, 3, 3);
            this.listViewDemo.Location = new System.Drawing.Point(263, 15);
            this.listViewDemo.Name = "listViewDemo";
            this.listViewDemo.Size = new System.Drawing.Size(1138, 444);
            this.listViewDemo.TabIndex = 2;
            this.listViewDemo.View = Wisej.Web.View.Details;
            this.listViewDemo.VirtualListSize = 100;
            this.listViewDemo.VirtualMode = true;
            this.listViewDemo.RetrieveVirtualItem += new Wisej.Web.RetrieveVirtualItemEventHandler(this.listViewDemo_RetrieveVirtualItem);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Name = "columnHeader7";
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 400;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Name = "columnHeader8";
            this.columnHeader8.Text = "Address";
            this.columnHeader8.Width = 400;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Name = "columnHeader9";
            this.columnHeader9.Text = "Phone Number";
            this.columnHeader9.Width = 325;
            // 
            // comboBoxView
            // 
            this.comboBoxView.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxView.Items.AddRange(new object[] {
            "Details",
            "LargeIcon",
            "SmallIcon",
            "Tile"});
            this.comboBoxView.LabelText = "View";
            this.comboBoxView.Location = new System.Drawing.Point(16, 15);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(227, 57);
            this.comboBoxView.TabIndex = 3;
            this.comboBoxView.Text = "Details";
            this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
            // 
            // Features
            // 
            this.Controls.Add(this.comboBoxView);
            this.Controls.Add(this.listViewDemo);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private Web.ListView listViewDemo;
        private Web.ColumnHeader columnHeader7;
        private Web.ColumnHeader columnHeader8;
        private Web.ColumnHeader columnHeader9;
        private Web.ComboBox comboBoxView;
    }
}
