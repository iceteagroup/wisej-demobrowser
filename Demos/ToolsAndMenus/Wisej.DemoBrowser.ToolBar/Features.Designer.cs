namespace Wisej.DemoBrowser.ToolBar
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
            this.contextMenuDropDown = new Wisej.Web.ContextMenu();
            this.menuItem1 = new Wisej.Web.MenuItem();
            this.menuItem2 = new Wisej.Web.MenuItem();
            this.menuItem3 = new Wisej.Web.MenuItem();
            this.panel1 = new Wisej.Web.Panel();
            this.toolBarDefault = new Wisej.Web.ToolBar();
            this.toolBarButton1 = new Wisej.Web.ToolBarButton();
            this.toolBarButton2 = new Wisej.Web.ToolBarButton();
            this.toolBarButton3 = new Wisej.Web.ToolBarButton();
            this.toolBarButton4 = new Wisej.Web.ToolBarButton();
            this.toolBarButton7 = new Wisej.Web.ToolBarButton();
            this.toolBarButton10 = new Wisej.Web.ToolBarButton();
            this.toolBarButton6 = new Wisej.Web.ToolBarButton();
            this.panel2 = new Wisej.Web.Panel();
            this.toolBar1 = new Wisej.Web.ToolBar();
            this.toolBarButton5 = new Wisej.Web.ToolBarButton();
            this.toolBarButton11 = new Wisej.Web.ToolBarButton();
            this.toolBarButton12 = new Wisej.Web.ToolBarButton();
            this.toolBarButton13 = new Wisej.Web.ToolBarButton();
            this.toolBarButton14 = new Wisej.Web.ToolBarButton();
            this.toolBarButton15 = new Wisej.Web.ToolBarButton();
            this.toolBarButton16 = new Wisej.Web.ToolBarButton();
            this.toolBarButton17 = new Wisej.Web.ToolBarButton();
            this.toolBarButton18 = new Wisej.Web.ToolBarButton();
            this.panel3 = new Wisej.Web.Panel();
            this.toolBar2 = new Wisej.Web.ToolBar();
            this.toolBarButton27 = new Wisej.Web.ToolBarButton();
            this.panel4 = new Wisej.Web.Panel();
            this.toolBar3 = new Wisej.Web.ToolBar();
            this.toolBarButton8 = new Wisej.Web.ToolBarButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuDropDown
            // 
            this.contextMenuDropDown.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            this.contextMenuDropDown.Name = "contextMenuDropDown";
            this.contextMenuDropDown.MenuItemClicked += new Wisej.Web.MenuItemEventHandler(this.contextMenuDropDown_MenuItemClicked);
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
            // menuItem3
            // 
            this.menuItem3.IconSource = "icon-undo";
            this.menuItem3.Index = 2;
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Text = "Close";
            // 
            // panel1
            // 
            this.panel1.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel1.Controls.Add(this.toolBarDefault);
            this.panel1.Location = new System.Drawing.Point(279, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 40);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // toolBarDefault
            // 
            this.toolBarDefault.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton4,
            this.toolBarButton7,
            this.toolBarButton10,
            this.toolBarButton6});
            this.toolBarDefault.Location = new System.Drawing.Point(0, 0);
            this.toolBarDefault.Name = "toolBarDefault";
            this.toolBarDefault.Size = new System.Drawing.Size(864, 32);
            this.toolBarDefault.TabIndex = 1;
            this.toolBarDefault.TabStop = false;
            this.toolBarDefault.ButtonClick += new Wisej.Web.ToolBarButtonClickEventHandler(this.toolBarDefault_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Text = "Default";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
            this.toolBarButton2.Text = "Toggle Button";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            this.toolBarButton3.Text = "Separator";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.DropDownMenu = this.contextMenuDropDown;
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Style = Wisej.Web.ToolBarButtonStyle.DropDownButton;
            this.toolBarButton4.Text = "Drop Down Button";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.AllowHtml = true;
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.Text = "<b>Button</b> with <i>HTML</i>";
            // 
            // toolBarButton10
            // 
            this.toolBarButton10.Name = "toolBarButton10";
            this.toolBarButton10.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            this.toolBarButton10.Text = "toolBarButton10";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.SizeMode = Wisej.Web.ToolBarButtonSizeMode.Fill;
            this.toolBarButton6.Text = "Button SizeMode Fill";
            // 
            // panel2
            // 
            this.panel2.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel2.Controls.Add(this.toolBar1);
            this.panel2.Location = new System.Drawing.Point(279, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 40);
            this.panel2.TabIndex = 2;
            this.panel2.TabStop = true;
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.toolBarButton5,
            this.toolBarButton11,
            this.toolBarButton12,
            this.toolBarButton13,
            this.toolBarButton14,
            this.toolBarButton15,
            this.toolBarButton16,
            this.toolBarButton17,
            this.toolBarButton18});
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(257, 32);
            this.toolBar1.TabIndex = 1;
            this.toolBar1.TabStop = false;
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Text = "ToolBar with AutoOverflow";
            // 
            // toolBarButton11
            // 
            this.toolBarButton11.Name = "toolBarButton11";
            this.toolBarButton11.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
            this.toolBarButton11.Text = "Toggle Button";
            // 
            // toolBarButton12
            // 
            this.toolBarButton12.Name = "toolBarButton12";
            this.toolBarButton12.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            this.toolBarButton12.Text = "Separator";
            // 
            // toolBarButton13
            // 
            this.toolBarButton13.Name = "toolBarButton13";
            this.toolBarButton13.Style = Wisej.Web.ToolBarButtonStyle.DropDownButton;
            this.toolBarButton13.Text = "Drop Down Button";
            // 
            // toolBarButton14
            // 
            this.toolBarButton14.AllowHtml = true;
            this.toolBarButton14.Name = "toolBarButton14";
            this.toolBarButton14.Text = "<b>Button</b> with <i>HTML</i>";
            // 
            // toolBarButton15
            // 
            this.toolBarButton15.Name = "toolBarButton15";
            this.toolBarButton15.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            this.toolBarButton15.Text = "toolBarButton10";
            // 
            // toolBarButton16
            // 
            this.toolBarButton16.Name = "toolBarButton16";
            this.toolBarButton16.SizeMode = Wisej.Web.ToolBarButtonSizeMode.Fill;
            this.toolBarButton16.Text = "Button SizeMode Fill";
            // 
            // toolBarButton17
            // 
            this.toolBarButton17.Name = "toolBarButton17";
            this.toolBarButton17.Style = Wisej.Web.ToolBarButtonStyle.Separator;
            this.toolBarButton17.Text = "toolBarButton9";
            // 
            // toolBarButton18
            // 
            this.toolBarButton18.ImageSource = "icon-exit";
            this.toolBarButton18.Name = "toolBarButton18";
            this.toolBarButton18.Text = "Icon";
            // 
            // panel3
            // 
            this.panel3.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel3.Controls.Add(this.toolBar2);
            this.panel3.Location = new System.Drawing.Point(665, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 40);
            this.panel3.TabIndex = 3;
            this.panel3.TabStop = true;
            // 
            // toolBar2
            // 
            this.toolBar2.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.toolBarButton27});
            this.toolBar2.Location = new System.Drawing.Point(0, 0);
            this.toolBar2.Name = "toolBar2";
            this.toolBar2.Size = new System.Drawing.Size(160, 32);
            this.toolBar2.TabIndex = 1;
            this.toolBar2.TabStop = false;
            this.toolBar2.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
            // 
            // toolBarButton27
            // 
            this.toolBarButton27.ImageSource = "icon-exit";
            this.toolBarButton27.Name = "toolBarButton27";
            this.toolBarButton27.Text = "Text Align Right";
            // 
            // panel4
            // 
            this.panel4.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel4.Controls.Add(this.toolBar3);
            this.panel4.Location = new System.Drawing.Point(954, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 60);
            this.panel4.TabIndex = 4;
            this.panel4.TabStop = true;
            // 
            // toolBar3
            // 
            this.toolBar3.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
            this.toolBarButton8});
            this.toolBar3.Location = new System.Drawing.Point(0, 0);
            this.toolBar3.Name = "toolBar3";
            this.toolBar3.Size = new System.Drawing.Size(188, 51);
            this.toolBar3.TabIndex = 1;
            this.toolBar3.TabStop = false;
            // 
            // toolBarButton8
            // 
            this.toolBarButton8.ImageSource = "icon-exit";
            this.toolBarButton8.Name = "toolBarButton8";
            this.toolBarButton8.Text = "Text Align Underneath";
            // 
            // Features
            // 
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(899, 169);
            this.Name = "Features";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private Web.ContextMenu contextMenuDropDown;
		private Web.MenuItem menuItem1;
		private Web.MenuItem menuItem2;
		private Web.MenuItem menuItem3;
		private Web.Panel panel1;
		private Web.ToolBar toolBarDefault;
		private Web.ToolBarButton toolBarButton1;
		private Web.ToolBarButton toolBarButton2;
		private Web.ToolBarButton toolBarButton3;
		private Web.ToolBarButton toolBarButton4;
		private Web.ToolBarButton toolBarButton7;
		private Web.ToolBarButton toolBarButton10;
		private Web.ToolBarButton toolBarButton6;
		private Web.Panel panel2;
		private Web.ToolBar toolBar1;
		private Web.ToolBarButton toolBarButton5;
		private Web.ToolBarButton toolBarButton11;
		private Web.ToolBarButton toolBarButton12;
		private Web.ToolBarButton toolBarButton13;
		private Web.ToolBarButton toolBarButton14;
		private Web.ToolBarButton toolBarButton15;
		private Web.ToolBarButton toolBarButton16;
		private Web.ToolBarButton toolBarButton17;
		private Web.ToolBarButton toolBarButton18;
		private Web.Panel panel3;
		private Web.ToolBar toolBar2;
		private Web.ToolBarButton toolBarButton27;
		private Web.Panel panel4;
		private Web.ToolBar toolBar3;
		private Web.ToolBarButton toolBarButton8;
	}
}
