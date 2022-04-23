namespace Wisej.DemoBrowser.NavigationBar
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
            this.navigationBar1 = new Wisej.Web.Ext.NavigationBar.NavigationBar();
            this.navigationBarItem1 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem2 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem3 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem5 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem6 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.navigationBarItem4 = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            this.checkBoxCompact = new Wisej.Web.CheckBox();
            this.SuspendLayout();
            // 
            // navigationBar1
            // 
            this.navigationBar1.Dock = Wisej.Web.DockStyle.Left;
            this.navigationBar1.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.navigationBarItem1,
            this.navigationBarItem2,
            this.navigationBarItem3,
            this.navigationBarItem4});
            this.navigationBar1.Logo = "window-icon";
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(282, 474);
            this.navigationBar1.TabIndex = 0;
            this.navigationBar1.Text = "ACME Corporation";
            this.navigationBar1.UserAvatar = "resource.wx/Wisej.DemoBrowser.NavigationBar/Images/person.jpg";
            this.navigationBar1.UserName = "Jane Doe";
            this.navigationBar1.UserStatus = "Online";
            this.navigationBar1.SelectedItemChanged += new System.EventHandler(this.navigationBar1_SelectedItemChanged);
            // 
            // navigationBarItem1
            // 
            this.navigationBarItem1.BackColor = System.Drawing.Color.Transparent;
            this.navigationBarItem1.Icon = "icon-preview?color=#D37A8B";
            this.navigationBarItem1.Name = "NavigationBarItem";
            this.navigationBarItem1.Text = "Home";
            // 
            // navigationBarItem2
            // 
            this.navigationBarItem2.BackColor = System.Drawing.Color.Transparent;
            this.navigationBarItem2.Icon = "icon-check?color=#3FBEBF";
            this.navigationBarItem2.Name = "NavigationBarItem";
            this.navigationBarItem2.Text = "Orders";
            // 
            // navigationBarItem3
            // 
            this.navigationBarItem3.BackColor = System.Drawing.Color.Transparent;
            this.navigationBarItem3.Icon = "icon-undo?color=#7FBF3F";
            this.navigationBarItem3.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
            this.navigationBarItem5,
            this.navigationBarItem6});
            this.navigationBarItem3.Name = "NavigationBarItem";
            this.navigationBarItem3.Text = "Leads";
            // 
            // navigationBarItem5
            // 
            this.navigationBarItem5.BackColor = System.Drawing.Color.Transparent;
            this.navigationBarItem5.Icon = "icon-save";
            this.navigationBarItem5.Name = "NavigationBarItem";
            this.navigationBarItem5.Text = "New";
            // 
            // navigationBarItem6
            // 
            this.navigationBarItem6.BackColor = System.Drawing.Color.Transparent;
            this.navigationBarItem6.Icon = "icon-saveas";
            this.navigationBarItem6.Name = "NavigationBarItem";
            this.navigationBarItem6.Text = "Previous";
            // 
            // navigationBarItem4
            // 
            this.navigationBarItem4.BackColor = System.Drawing.Color.Transparent;
            this.navigationBarItem4.Icon = "icon-settings?color=#D384D6";
            this.navigationBarItem4.Name = "NavigationBarItem";
            this.navigationBarItem4.Text = "Settings";
            // 
            // checkBoxCompact
            // 
            this.checkBoxCompact.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxCompact.AutoSize = false;
            this.checkBoxCompact.Location = new System.Drawing.Point(354, 79);
            this.checkBoxCompact.Name = "checkBoxCompact";
            this.checkBoxCompact.Size = new System.Drawing.Size(200, 35);
            this.checkBoxCompact.TabIndex = 1;
            this.checkBoxCompact.Text = "Compact View";
            this.checkBoxCompact.CheckedChanged += new System.EventHandler(this.checkBoxCompact_CheckedChanged);
            // 
            // Features
            // 
            this.Controls.Add(this.checkBoxCompact);
            this.Controls.Add(this.navigationBar1);
            this.MinimumSize = new System.Drawing.Size(940, 400);
            this.Name = "Features";
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.NavigationBar.NavigationBar navigationBar1;
		private Web.Ext.NavigationBar.NavigationBarItem navigationBarItem1;
		private Web.Ext.NavigationBar.NavigationBarItem navigationBarItem2;
		private Web.Ext.NavigationBar.NavigationBarItem navigationBarItem3;
		private Web.Ext.NavigationBar.NavigationBarItem navigationBarItem5;
		private Web.Ext.NavigationBar.NavigationBarItem navigationBarItem6;
		private Web.Ext.NavigationBar.NavigationBarItem navigationBarItem4;
		private Web.CheckBox checkBoxCompact;
	}
}
