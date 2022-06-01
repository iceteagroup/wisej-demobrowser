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
            this.comboBoxSelectionMode = new Wisej.Web.ComboBox();
            this.panel1 = new Wisej.Web.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDemo
            // 
            this.listViewDemo.AppearanceKey = "circlelistview";
            this.listViewDemo.BorderStyle = Wisej.Web.BorderStyle.None;
            this.listViewDemo.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewDemo.CssClass = "shadow";
            this.listViewDemo.CssStyle = "border-radius: 4px;";
            this.listViewDemo.Dock = Wisej.Web.DockStyle.Fill;
            this.listViewDemo.ItemPadding = new Wisej.Web.Padding(8, 3, 3, 3);
            this.listViewDemo.Location = new System.Drawing.Point(299, 16);
            this.listViewDemo.MinimumSize = new System.Drawing.Size(300, 0);
            this.listViewDemo.Name = "listViewDemo";
            this.listViewDemo.Size = new System.Drawing.Size(1107, 442);
            this.listViewDemo.TabIndex = 2;
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
            this.comboBoxView.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxView.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxView.Items.AddRange(new object[] {
            "Details",
            "LargeIcon",
            "SmallIcon",
            "Tile"});
            this.comboBoxView.LabelText = "View";
            this.comboBoxView.Location = new System.Drawing.Point(41, 151);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(200, 53);
            this.comboBoxView.TabIndex = 3;
            this.comboBoxView.Text = "LargeIcon";
            this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
            // 
            // comboBoxSelectionMode
            // 
            this.comboBoxSelectionMode.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxSelectionMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxSelectionMode.Items.AddRange(new object[] {
            "None",
            "One",
            "MultiSimple",
            "MultiExtended"});
            this.comboBoxSelectionMode.LabelText = "Selection Mode";
            this.comboBoxSelectionMode.Location = new System.Drawing.Point(41, 239);
            this.comboBoxSelectionMode.Name = "comboBoxSelectionMode";
            this.comboBoxSelectionMode.Size = new System.Drawing.Size(200, 53);
            this.comboBoxSelectionMode.TabIndex = 4;
            this.comboBoxSelectionMode.Text = "One";
            this.comboBoxSelectionMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectionMode_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxSelectionMode);
            this.panel1.Controls.Add(this.comboBoxView);
            this.panel1.Dock = Wisej.Web.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 442);
            this.panel1.TabIndex = 5;
            // 
            // Features
            // 
            this.Controls.Add(this.listViewDemo);
            this.Controls.Add(this.panel1);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(16);
            this.Load += new System.EventHandler(this.Features_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion
        private Web.ListView listViewDemo;
        private Web.ColumnHeader columnHeader7;
        private Web.ColumnHeader columnHeader8;
        private Web.ColumnHeader columnHeader9;
        private Web.ComboBox comboBoxView;
        private Web.ComboBox comboBoxSelectionMode;
        private Web.Panel panel1;
    }
}
