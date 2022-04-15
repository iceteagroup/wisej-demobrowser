namespace Wisej.DemoBrowser.ContextMenu
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
            this.contextMenuButton = new Wisej.Web.ContextMenu();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.menuItem2 = new Wisej.Web.MenuItem();
            this.menuItem4 = new Wisej.Web.MenuItem();
            this.menuItem3 = new Wisej.Web.MenuItem();
            this.buttonDefault = new Wisej.Web.Button();
            this.buttonCheckedContextMenu = new Wisej.Web.Button();
            this.contextMenuChecked = new Wisej.Web.ContextMenu();
            this.checkedMenuItem1 = new Wisej.Web.CheckedMenuItem();
            this.checkedMenuItem2 = new Wisej.Web.CheckedMenuItem();
            this.checkedMenuItem3 = new Wisej.Web.CheckedMenuItem();
            this.checkedMenuItem4 = new Wisej.Web.CheckedMenuItem();
            this.checkedMenuItem5 = new Wisej.Web.CheckedMenuItem();
            this.button1 = new Wisej.Web.Button();
            this.contextMenuNested = new Wisej.Web.ContextMenu();
            this.menuItem5 = new Wisej.Web.MenuItem();
            this.menuItem10 = new Wisej.Web.MenuItem();
            this.menuItem11 = new Wisej.Web.MenuItem();
            this.menuItem12 = new Wisej.Web.MenuItem();
            this.button2 = new Wisej.Web.Button();
            this.contextMenuLinks = new Wisej.Web.ContextMenu();
            this.linkMenuItem1 = new Wisej.Web.LinkMenuItem();
            this.linkMenuItem2 = new Wisej.Web.LinkMenuItem();
            this.linkMenuItem3 = new Wisej.Web.LinkMenuItem();
            this.contextMenuHTML = new Wisej.Web.ContextMenu();
            this.menuItem6 = new Wisej.Web.MenuItem();
            this.menuItem7 = new Wisej.Web.MenuItem();
            this.menuItem8 = new Wisej.Web.MenuItem();
            this.button3 = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // contextMenuButton
            // 
            this.contextMenuButton.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem4,
            this.menuItem3});
            this.contextMenuButton.Name = "contextMenuButton";
            this.contextMenuButton.RightToLeft = Wisej.Web.RightToLeft.No;
            this.contextMenuButton.Collapse += new System.EventHandler(this.contextMenuButton_Collapse);
            this.contextMenuButton.Popup += new System.EventHandler(this.contextMenuButton_Popup);
            this.contextMenuButton.MenuItemClicked += new Wisej.Web.MenuItemEventHandler(this.contextMenuButton_MenuItemClicked);
            // 
            // menuItem1
            // 
            this.menuItem1.IconSource = "icon-new";
            this.menuItem1.Index = 0;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Text = "New";
            // 
            // menuItem2
            // 
            this.menuItem2.IconSource = "table-row-editing";
            this.menuItem2.Index = 1;
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Text = "Edit";
            // 
            // menuItem4
            // 
            this.menuItem4.IconSource = "icon-copy";
            this.menuItem4.Index = 2;
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Text = "Copy";
            // 
            // menuItem3
            // 
            this.menuItem3.IconSource = "icon-cut";
            this.menuItem3.Index = 3;
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Text = "Cut";
            // 
            // buttonDefault
            // 
            this.buttonDefault.Anchor = Wisej.Web.AnchorStyles.None;
            this.buttonDefault.ContextMenu = this.contextMenuButton;
            this.buttonDefault.Location = new System.Drawing.Point(153, 220);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(200, 35);
            this.buttonDefault.TabIndex = 0;
            this.buttonDefault.Text = "Right-Click (Default)";
            // 
            // buttonCheckedContextMenu
            // 
            this.buttonCheckedContextMenu.Anchor = Wisej.Web.AnchorStyles.None;
            this.buttonCheckedContextMenu.ContextMenu = this.contextMenuChecked;
            this.buttonCheckedContextMenu.Location = new System.Drawing.Point(382, 220);
            this.buttonCheckedContextMenu.Name = "buttonCheckedContextMenu";
            this.buttonCheckedContextMenu.Size = new System.Drawing.Size(200, 35);
            this.buttonCheckedContextMenu.TabIndex = 1;
            this.buttonCheckedContextMenu.Text = "Checked Items";
            // 
            // contextMenuChecked
            // 
            this.contextMenuChecked.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.checkedMenuItem1,
            this.checkedMenuItem2,
            this.checkedMenuItem3,
            this.checkedMenuItem4,
            this.checkedMenuItem5});
            this.contextMenuChecked.Name = "contextMenuChecked";
            this.contextMenuChecked.RightToLeft = Wisej.Web.RightToLeft.No;
            this.contextMenuChecked.MenuItemClicked += new Wisej.Web.MenuItemEventHandler(this.contextMenuChecked_MenuItemClicked);
            // 
            // checkedMenuItem1
            // 
            this.checkedMenuItem1.Checked = true;
            this.checkedMenuItem1.Index = 0;
            this.checkedMenuItem1.Name = "checkedMenuItem1";
            this.checkedMenuItem1.Text = "New York City";
            // 
            // checkedMenuItem2
            // 
            this.checkedMenuItem2.Index = 1;
            this.checkedMenuItem2.Name = "checkedMenuItem2";
            this.checkedMenuItem2.Text = "Chicago";
            // 
            // checkedMenuItem3
            // 
            this.checkedMenuItem3.Index = 2;
            this.checkedMenuItem3.Name = "checkedMenuItem3";
            this.checkedMenuItem3.Text = "Berlin";
            // 
            // checkedMenuItem4
            // 
            this.checkedMenuItem4.Index = 3;
            this.checkedMenuItem4.Name = "checkedMenuItem4";
            this.checkedMenuItem4.Text = "Rome";
            // 
            // checkedMenuItem5
            // 
            this.checkedMenuItem5.Index = 4;
            this.checkedMenuItem5.Name = "checkedMenuItem5";
            this.checkedMenuItem5.Text = "London";
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.None;
            this.button1.ContextMenu = this.contextMenuNested;
            this.button1.Location = new System.Drawing.Point(611, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nested";
            // 
            // contextMenuNested
            // 
            this.contextMenuNested.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem5});
            this.contextMenuNested.Name = "contextMenuNested";
            this.contextMenuNested.RightToLeft = Wisej.Web.RightToLeft.No;
            this.contextMenuNested.MenuItemClicked += new Wisej.Web.MenuItemEventHandler(this.contextMenuNested_MenuItemClicked);
            // 
            // menuItem5
            // 
            this.menuItem5.IconSource = "icon-new";
            this.menuItem5.Index = 0;
            this.menuItem5.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem10,
            this.menuItem11,
            this.menuItem12});
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Text = "New";
            // 
            // menuItem10
            // 
            this.menuItem10.IconSource = "icon-file";
            this.menuItem10.Index = 0;
            this.menuItem10.Name = "menuItem10";
            this.menuItem10.Text = "Project";
            // 
            // menuItem11
            // 
            this.menuItem11.IconSource = "icon-file";
            this.menuItem11.Index = 1;
            this.menuItem11.Name = "menuItem11";
            this.menuItem11.Text = "File";
            // 
            // menuItem12
            // 
            this.menuItem12.IconSource = "icon-file";
            this.menuItem12.Index = 2;
            this.menuItem12.Name = "menuItem12";
            this.menuItem12.Text = "Image Resource";
            // 
            // button2
            // 
            this.button2.Anchor = Wisej.Web.AnchorStyles.None;
            this.button2.ContextMenu = this.contextMenuLinks;
            this.button2.Location = new System.Drawing.Point(840, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Links";
            // 
            // contextMenuLinks
            // 
            this.contextMenuLinks.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.linkMenuItem1,
            this.linkMenuItem2,
            this.linkMenuItem3});
            this.contextMenuLinks.Name = "contextMenuLinks";
            this.contextMenuLinks.RightToLeft = Wisej.Web.RightToLeft.No;
            // 
            // linkMenuItem1
            // 
            this.linkMenuItem1.HRef = "https://www.wisej.com";
            this.linkMenuItem1.Index = 0;
            this.linkMenuItem1.Name = "linkMenuItem1";
            this.linkMenuItem1.Text = "Wisej.com";
            // 
            // linkMenuItem2
            // 
            this.linkMenuItem2.HRef = "https://www.madewithwisej.com";
            this.linkMenuItem2.Index = 1;
            this.linkMenuItem2.Name = "linkMenuItem2";
            this.linkMenuItem2.Text = "MadeWithWisej.com";
            // 
            // linkMenuItem3
            // 
            this.linkMenuItem3.HRef = "https://docs.wisej.com";
            this.linkMenuItem3.Index = 2;
            this.linkMenuItem3.Name = "linkMenuItem3";
            this.linkMenuItem3.Text = "Docs.Wisej.com";
            // 
            // contextMenuHTML
            // 
            this.contextMenuHTML.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem6,
            this.menuItem7,
            this.menuItem8});
            this.contextMenuHTML.Name = "contextMenuHTML";
            this.contextMenuHTML.RightToLeft = Wisej.Web.RightToLeft.No;
            // 
            // menuItem6
            // 
            this.menuItem6.AllowHtml = true;
            this.menuItem6.Index = 0;
            this.menuItem6.Name = "menuItem6";
            this.menuItem6.Text = "<b>File</b>";
            // 
            // menuItem7
            // 
            this.menuItem7.AllowHtml = true;
            this.menuItem7.Index = 1;
            this.menuItem7.Name = "menuItem7";
            this.menuItem7.Text = "<i>Edit</i>";
            // 
            // menuItem8
            // 
            this.menuItem8.AllowHtml = true;
            this.menuItem8.Index = 2;
            this.menuItem8.Name = "menuItem8";
            this.menuItem8.Text = "Big<br>Item";
            // 
            // button3
            // 
            this.button3.Anchor = Wisej.Web.AnchorStyles.None;
            this.button3.ContextMenu = this.contextMenuHTML;
            this.button3.Location = new System.Drawing.Point(1069, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "HTML";
            // 
            // Features
            // 
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCheckedContextMenu);
            this.Controls.Add(this.buttonDefault);
            this.Name = "Features";
            this.ResumeLayout(false);

		}

		#endregion

		private Web.ContextMenu contextMenuButton;
		private Web.Button buttonDefault;
		private Web.MenuItem menuItem1;
		private Web.MenuItem menuItem2;
		private Web.MenuItem menuItem4;
		private Web.MenuItem menuItem3;
		private Web.Button buttonCheckedContextMenu;
		private Web.ContextMenu contextMenuChecked;
		private Web.CheckedMenuItem checkedMenuItem1;
		private Web.CheckedMenuItem checkedMenuItem2;
		private Web.CheckedMenuItem checkedMenuItem3;
		private Web.CheckedMenuItem checkedMenuItem4;
		private Web.CheckedMenuItem checkedMenuItem5;
		private Web.Button button1;
		private Web.ContextMenu contextMenuNested;
		private Web.MenuItem menuItem5;
		private Web.MenuItem menuItem10;
		private Web.MenuItem menuItem11;
		private Web.MenuItem menuItem12;
		private Web.Button button2;
		private Web.ContextMenu contextMenuLinks;
		private Web.LinkMenuItem linkMenuItem1;
		private Web.LinkMenuItem linkMenuItem2;
		private Web.LinkMenuItem linkMenuItem3;
		private Web.ContextMenu contextMenuHTML;
		private Web.MenuItem menuItem6;
		private Web.MenuItem menuItem7;
		private Web.MenuItem menuItem8;
		private Web.Button button3;
	}
}
