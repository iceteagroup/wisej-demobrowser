
namespace Wisej.DemoBrowser
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            Wisej.Web.TreeNode treeNode1 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode2 = new Wisej.Web.TreeNode();
            this.panelMenu = new Wisej.Web.FlexLayoutPanel();
            this.pictureBoxLogo = new Wisej.Web.PictureBox();
            this.menuSlideBar = new Wisej.Web.SlideBar();
            this.buttonDocs = new Wisej.Web.Button();
            this.buttonAPI = new Wisej.Web.Button();
            this.buttonSupport = new Wisej.Web.Button();
            this.buttonMWW = new Wisej.Web.Button();
            this.rightPanel = new Wisej.Web.Panel();
            this.comboBoxLanguage = new Wisej.Web.ComboBox();
            this.buttonBuy = new Wisej.Web.Button();
            this.comboBoxTheme = new Wisej.Web.ComboBox();
            this.lineMenuDivider3 = new Wisej.Web.Line();
            this.lineMenuDivider1 = new Wisej.Web.Line();
            this.buttonFreeTrial = new Wisej.Web.Button();
            this.buttonContact = new Wisej.Web.Button();
            this.lineMenuDivider2 = new Wisej.Web.Line();
            this.imageList1 = new Wisej.Web.ImageList(this.components);
            this.panelComponents = new Wisej.Web.Panel();
            this.panelSearch = new Wisej.Web.Panel();
            this.textBoxSearch = new Wisej.Web.TextBox();
            this.buttonSearch = new Wisej.Web.Button();
            this.buttonCollapse = new Wisej.Web.Button();
            this.treeViewComponents = new Wisej.Web.TreeView();
            this.panelContainer = new Wisej.Web.Panel();
            this.panelDemo = new Wisej.Web.Panel();
            this.line6 = new Wisej.Web.Line();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.labelNavigationWisejDemos = new Wisej.Web.Label();
            this.labelNavigationSeparator1 = new Wisej.Web.Label();
            this.labelNaivgationCategory = new Wisej.Web.Label();
            this.labelNavigationSeparator2 = new Wisej.Web.Label();
            this.labelNavigationControl = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.labelNavigationDemo = new Wisej.Web.Label();
            this.panelLinks = new Wisej.Web.Panel();
            this.buttonDocumentation = new Wisej.Web.Button();
            this.line5 = new Wisej.Web.Line();
            this.buttonSourceCode = new Wisej.Web.Button();
            this.line4 = new Wisej.Web.Line();
            this.labelDescription = new Wisej.Web.Label();
            this.labelTitle = new Wisej.Web.Label();
            this.pictureBoxControl = new Wisej.Web.PictureBox();
            this.panel1 = new Wisej.Web.Panel();
            this.buttonPrevious = new Wisej.Web.Button();
            this.buttonNext = new Wisej.Web.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.menuSlideBar.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panelComponents.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Controls.Add(this.menuSlideBar);
            this.panelMenu.Controls.Add(this.rightPanel);
            this.panelMenu.CssStyle = "z-index: 11;\r\nborder-width: 1px;\r\nborder-color: #DFDFDF;\r\nborder-bottom-style: so" +
    "lid;\r\nbox-shadow: 1px 0px 16px 0px #dedede;";
            this.panelMenu.Dock = Wisej.Web.DockStyle.Top;
            this.panelMenu.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.ShowCloseButton = false;
            this.panelMenu.Size = new System.Drawing.Size(1727, 77);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.TabStop = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.ImageSource = "Images\\Wisej logo 160px copy.png";
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(203, 71);
            this.pictureBoxLogo.SizeMode = Wisej.Web.PictureBoxSizeMode.CenterImage;
            // 
            // menuSlideBar
            // 
            this.menuSlideBar.Controls.Add(this.buttonDocs);
            this.menuSlideBar.Controls.Add(this.buttonAPI);
            this.menuSlideBar.Controls.Add(this.buttonSupport);
            this.menuSlideBar.Controls.Add(this.buttonMWW);
            this.panelMenu.SetFillWeight(this.menuSlideBar, 1);
            this.menuSlideBar.Location = new System.Drawing.Point(222, 3);
            this.menuSlideBar.MinimumSize = new System.Drawing.Size(220, 0);
            this.menuSlideBar.Name = "menuSlideBar";
            this.menuSlideBar.ScrollStep = 50;
            this.menuSlideBar.Size = new System.Drawing.Size(669, 71);
            this.menuSlideBar.Spacing = 20;
            this.menuSlideBar.TabIndex = 0;
            // 
            // buttonDocs
            // 
            this.buttonDocs.AppearanceKey = "button-menu-demo";
            this.buttonDocs.Dock = Wisej.Web.DockStyle.Left;
            this.buttonDocs.Focusable = false;
            this.buttonDocs.Font = new System.Drawing.Font("@menuDemo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonDocs.Location = new System.Drawing.Point(3, 3);
            this.buttonDocs.Name = "buttonDocs";
            this.buttonDocs.Size = new System.Drawing.Size(176, 65);
            this.buttonDocs.TabIndex = 0;
            this.buttonDocs.Text = "Wisej Documentation";
            this.buttonDocs.Click += new System.EventHandler(this.buttonDocs_Click);
            // 
            // buttonAPI
            // 
            this.buttonAPI.AppearanceKey = "button-menu-demo";
            this.buttonAPI.Dock = Wisej.Web.DockStyle.Left;
            this.buttonAPI.Focusable = false;
            this.buttonAPI.Font = new System.Drawing.Font("@menuDemo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonAPI.Location = new System.Drawing.Point(205, 3);
            this.buttonAPI.Name = "buttonAPI";
            this.buttonAPI.Size = new System.Drawing.Size(81, 65);
            this.buttonAPI.TabIndex = 1;
            this.buttonAPI.Text = "Wisej API";
            this.buttonAPI.Click += new System.EventHandler(this.buttonAPI_Click);
            // 
            // buttonSupport
            // 
            this.buttonSupport.AppearanceKey = "button-menu-demo";
            this.buttonSupport.Dock = Wisej.Web.DockStyle.Left;
            this.buttonSupport.Focusable = false;
            this.buttonSupport.Font = new System.Drawing.Font("@menuDemo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonSupport.Location = new System.Drawing.Point(312, 3);
            this.buttonSupport.Name = "buttonSupport";
            this.buttonSupport.Size = new System.Drawing.Size(77, 65);
            this.buttonSupport.TabIndex = 2;
            this.buttonSupport.Text = "Support";
            this.buttonSupport.Click += new System.EventHandler(this.buttonSupport_Click);
            // 
            // buttonMWW
            // 
            this.buttonMWW.AppearanceKey = "button-menu-demo";
            this.buttonMWW.Dock = Wisej.Web.DockStyle.Left;
            this.buttonMWW.Focusable = false;
            this.buttonMWW.Font = new System.Drawing.Font("@menuDemo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonMWW.Location = new System.Drawing.Point(415, 3);
            this.buttonMWW.Name = "buttonMWW";
            this.buttonMWW.Size = new System.Drawing.Size(161, 65);
            this.buttonMWW.TabIndex = 3;
            this.buttonMWW.Text = "madewithwisej.com";
            this.buttonMWW.Click += new System.EventHandler(this.buttonMWW_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.comboBoxLanguage);
            this.rightPanel.Controls.Add(this.buttonBuy);
            this.rightPanel.Controls.Add(this.comboBoxTheme);
            this.rightPanel.Controls.Add(this.lineMenuDivider3);
            this.rightPanel.Controls.Add(this.lineMenuDivider1);
            this.rightPanel.Controls.Add(this.buttonFreeTrial);
            this.rightPanel.Controls.Add(this.buttonContact);
            this.rightPanel.Controls.Add(this.lineMenuDivider2);
            this.rightPanel.Location = new System.Drawing.Point(907, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(817, 71);
            this.rightPanel.TabIndex = 25;
            this.rightPanel.TabStop = true;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxLanguage.AppearanceKey = "combobox-demo";
            this.comboBoxLanguage.AutoSize = false;
            this.comboBoxLanguage.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.Enabled = false;
            this.comboBoxLanguage.Focusable = false;
            this.comboBoxLanguage.Font = new System.Drawing.Font("@defaultDemo", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "EN",
            "DE",
            "IT",
            "ES"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(17, 18);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(84, 40);
            this.comboBoxLanguage.TabIndex = 8;
            this.comboBoxLanguage.Text = "EN";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonBuy.AppearanceKey = "button-menu-demo";
            this.buttonBuy.Focusable = false;
            this.buttonBuy.Font = new System.Drawing.Font("@menuDemo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonBuy.ImageSource = "Images\\Icon Buy.png";
            this.buttonBuy.Location = new System.Drawing.Point(678, 10);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(131, 57);
            this.buttonBuy.TabIndex = 4;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxTheme.AppearanceKey = "combobox-demo";
            this.comboBoxTheme.AutoSize = false;
            this.comboBoxTheme.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.Focusable = false;
            this.comboBoxTheme.Font = new System.Drawing.Font("@defaultDemo", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxTheme.Items.AddRange(new object[] {
            "Bootstrap-4",
            "Blue-1",
            "Blue-2",
            "Blue-3",
            "Classic-2",
            "Clear-1",
            "Clear-2",
            "Clear-3",
            "Material-3",
            "Graphite-3",
            "Vista-2"});
            this.comboBoxTheme.Location = new System.Drawing.Point(116, 18);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(193, 40);
            this.comboBoxTheme.TabIndex = 1;
            this.comboBoxTheme.Watermark = "Choose Theme";
            this.comboBoxTheme.SelectedIndexChanged += new System.EventHandler(this.comboBoxTheme_SelectedIndexChanged);
            // 
            // lineMenuDivider3
            // 
            this.lineMenuDivider3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.lineMenuDivider3.Location = new System.Drawing.Point(666, 1);
            this.lineMenuDivider3.Name = "lineMenuDivider3";
            this.lineMenuDivider3.Orientation = Wisej.Web.Orientation.Vertical;
            this.lineMenuDivider3.Padding = new Wisej.Web.Padding(0, 15, 0, 15);
            this.lineMenuDivider3.Size = new System.Drawing.Size(5, 74);
            // 
            // lineMenuDivider1
            // 
            this.lineMenuDivider1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.lineMenuDivider1.Location = new System.Drawing.Point(339, 1);
            this.lineMenuDivider1.Name = "lineMenuDivider1";
            this.lineMenuDivider1.Orientation = Wisej.Web.Orientation.Vertical;
            this.lineMenuDivider1.Padding = new Wisej.Web.Padding(0, 15, 0, 15);
            this.lineMenuDivider1.Size = new System.Drawing.Size(5, 74);
            // 
            // buttonFreeTrial
            // 
            this.buttonFreeTrial.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonFreeTrial.AppearanceKey = "button-menu-demo";
            this.buttonFreeTrial.Focusable = false;
            this.buttonFreeTrial.Font = new System.Drawing.Font("@menuDemo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonFreeTrial.ImageSource = "Images\\Icon Free Trial.png";
            this.buttonFreeTrial.Location = new System.Drawing.Point(520, 10);
            this.buttonFreeTrial.Name = "buttonFreeTrial";
            this.buttonFreeTrial.Size = new System.Drawing.Size(140, 57);
            this.buttonFreeTrial.TabIndex = 3;
            this.buttonFreeTrial.Text = "Free Trial";
            this.buttonFreeTrial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFreeTrial.Click += new System.EventHandler(this.buttonFreeTrial_Click);
            // 
            // buttonContact
            // 
            this.buttonContact.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonContact.AppearanceKey = "button-menu-demo";
            this.buttonContact.Focusable = false;
            this.buttonContact.Font = new System.Drawing.Font("@menuDemo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonContact.ImageSource = "Images\\Icon Contact.png";
            this.buttonContact.Location = new System.Drawing.Point(360, 10);
            this.buttonContact.Name = "buttonContact";
            this.buttonContact.Size = new System.Drawing.Size(135, 57);
            this.buttonContact.TabIndex = 2;
            this.buttonContact.Text = "Contact";
            this.buttonContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContact.Click += new System.EventHandler(this.buttonContact_Click);
            // 
            // lineMenuDivider2
            // 
            this.lineMenuDivider2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.lineMenuDivider2.Location = new System.Drawing.Point(499, 1);
            this.lineMenuDivider2.Name = "lineMenuDivider2";
            this.lineMenuDivider2.Orientation = Wisej.Web.Orientation.Vertical;
            this.lineMenuDivider2.Padding = new Wisej.Web.Padding(0, 15, 0, 15);
            this.lineMenuDivider2.Size = new System.Drawing.Size(5, 74);
            // 
            // panelComponents
            // 
            this.panelComponents.AppearanceKey = "panel-demo";
            this.panelComponents.AutoShow = Wisej.Web.PanelAutoShowMode.OnPointerOver;
            this.panelComponents.CollapseSide = Wisej.Web.HeaderPosition.Left;
            this.panelComponents.Controls.Add(this.panelSearch);
            this.panelComponents.Controls.Add(this.treeViewComponents);
            this.panelComponents.CssStyle = "border-right: 1px solid #E5E8E9;";
            this.panelComponents.Dock = Wisej.Web.DockStyle.Left;
            this.panelComponents.Font = new System.Drawing.Font("@defaultDemo", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.panelComponents.HeaderBackColor = System.Drawing.Color.FromName("@hotTrack-demo");
            this.panelComponents.HeaderSize = 40;
            this.panelComponents.Location = new System.Drawing.Point(0, 77);
            this.panelComponents.Name = "panelComponents";
            this.panelComponents.ResizableEdges = Wisej.Web.AnchorStyles.Right;
            this.panelComponents.ShowHeader = true;
            this.panelComponents.Size = new System.Drawing.Size(345, 772);
            this.panelComponents.TabIndex = 1;
            this.panelComponents.TabStop = true;
            this.panelComponents.Text = "Components";
            this.panelComponents.PanelCollapsed += new System.EventHandler(this.panelComponents_PanelCollapsed);
            this.panelComponents.PanelExpanded += new System.EventHandler(this.panelComponents_PanelExpanded);
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.buttonCollapse);
            this.panelSearch.CssStyle = "border-bottom: 1px solid #D2D5D6;\r\n";
            this.panelSearch.Dock = Wisej.Web.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(345, 48);
            this.panelSearch.TabIndex = 0;
            this.panelSearch.TabStop = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AppearanceKey = "textbox-demo";
            this.textBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.textBoxSearch.BorderStyle = Wisej.Web.BorderStyle.None;
            this.textBoxSearch.Dock = Wisej.Web.DockStyle.Fill;
            this.textBoxSearch.Focusable = false;
            this.textBoxSearch.Font = new System.Drawing.Font("@defaultDemo", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSearch.InitScript = resources.GetString("textBoxSearch.InitScript");
            this.textBoxSearch.Location = new System.Drawing.Point(70, 0);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Padding = new Wisej.Web.Padding(13, 0, 0, 0);
            this.textBoxSearch.SelectOnEnter = true;
            this.textBoxSearch.Size = new System.Drawing.Size(247, 48);
            this.textBoxSearch.TabIndex = 1;
            componentTool1.ImageSource = "icon-left";
            componentTool1.Name = "back";
            componentTool1.ToolTipText = "Previous (F8)";
            componentTool1.Visible = false;
            componentTool2.ImageSource = "icon-right";
            componentTool2.Name = "forward";
            componentTool2.ToolTipText = "Next (F9)";
            componentTool2.Visible = false;
            this.textBoxSearch.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1,
            componentTool2});
            this.textBoxSearch.Watermark = "Search Component";
            this.textBoxSearch.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textBoxSearch_ToolClick);
            this.textBoxSearch.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.textBoxSearch_WidgetEvent);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BorderStyle = Wisej.Web.BorderStyle.None;
            this.buttonSearch.Dock = Wisej.Web.DockStyle.Left;
            this.buttonSearch.Focusable = false;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSearch.ImageSource = "Images\\search.png";
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(70, 48);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.AppearanceKey = "button-demo";
            this.buttonCollapse.BackColor = System.Drawing.Color.Transparent;
            this.buttonCollapse.BackgroundImageLayout = Wisej.Web.ImageLayout.Stretch;
            this.buttonCollapse.BackgroundImageSource = "Images/collapse icon.png";
            this.buttonCollapse.CssStyle = "border-radius: 0px;";
            this.buttonCollapse.Dock = Wisej.Web.DockStyle.Right;
            this.buttonCollapse.Focusable = false;
            this.buttonCollapse.Location = new System.Drawing.Point(317, 0);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(28, 48);
            this.buttonCollapse.TabIndex = 2;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // treeViewComponents
            // 
            this.treeViewComponents.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.treeViewComponents.AppearanceKey = "tree-demo";
            this.treeViewComponents.BackColor = System.Drawing.Color.FromName("@tree-background-demo");
            this.treeViewComponents.BorderStyle = Wisej.Web.BorderStyle.None;
            this.treeViewComponents.Focusable = false;
            this.treeViewComponents.ImageIndex = 0;
            this.treeViewComponents.ImageList = this.imageList1;
            this.treeViewComponents.ItemHeight = 33;
            this.treeViewComponents.Location = new System.Drawing.Point(48, 77);
            this.treeViewComponents.Name = "treeViewComponents";
            treeNode1.Name = "Node0";
            treeNode1.NodeFont = new System.Drawing.Font("@defaultBoldDemo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            treeNode2.Name = "Node1";
            treeNode2.NodeFont = new System.Drawing.Font("@defaultDemo", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            treeNode2.Text = "Data Binding";
            treeNode1.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode2});
            treeNode1.Text = "COMBOBOX";
            this.treeViewComponents.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode1});
            this.treeViewComponents.PathSeparator = "/";
            this.treeViewComponents.SelectedImageIndex = 0;
            this.treeViewComponents.Size = new System.Drawing.Size(268, 632);
            this.treeViewComponents.TabIndex = 1;
            this.treeViewComponents.AfterSelect += new Wisej.Web.TreeViewEventHandler(this.treeViewComponents_AfterSelect);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelDemo);
            this.panelContainer.Controls.Add(this.line6);
            this.panelContainer.Controls.Add(this.flowLayoutPanel1);
            this.panelContainer.Controls.Add(this.panelLinks);
            this.panelContainer.Controls.Add(this.line4);
            this.panelContainer.Controls.Add(this.labelDescription);
            this.panelContainer.Controls.Add(this.labelTitle);
            this.panelContainer.Controls.Add(this.pictureBoxControl);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Dock = Wisej.Web.DockStyle.Fill;
            this.panelContainer.HeaderBackColor = System.Drawing.Color.FromArgb(25, 68, 156);
            this.panelContainer.HeaderSize = 40;
            this.panelContainer.Location = new System.Drawing.Point(345, 77);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.ShowCloseButton = false;
            this.panelContainer.Size = new System.Drawing.Size(1382, 772);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.TabStop = true;
            this.panelContainer.Text = "Test";
            // 
            // panelDemo
            // 
            this.panelDemo.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.panelDemo.AppearanceKey = "panel-demo";
            this.panelDemo.AutoScroll = true;
            this.panelDemo.Location = new System.Drawing.Point(39, 280);
            this.panelDemo.MinimumSize = new System.Drawing.Size(300, 0);
            this.panelDemo.Name = "panelDemo";
            this.panelDemo.Size = new System.Drawing.Size(1250, 435);
            this.panelDemo.TabIndex = 21;
            this.panelDemo.TabStop = true;
            // 
            // line6
            // 
            this.line6.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.line6.Location = new System.Drawing.Point(39, 277);
            this.line6.MinimumSize = new System.Drawing.Size(300, 0);
            this.line6.Name = "line6";
            this.line6.Size = new System.Drawing.Size(1250, 5);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.labelNavigationWisejDemos);
            this.flowLayoutPanel1.Controls.Add(this.labelNavigationSeparator1);
            this.flowLayoutPanel1.Controls.Add(this.labelNaivgationCategory);
            this.flowLayoutPanel1.Controls.Add(this.labelNavigationSeparator2);
            this.flowLayoutPanel1.Controls.Add(this.labelNavigationControl);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.labelNavigationDemo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(36, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1252, 30);
            this.flowLayoutPanel1.TabIndex = 12;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // labelNavigationWisejDemos
            // 
            this.labelNavigationWisejDemos.Font = new System.Drawing.Font("@defaultDemo", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelNavigationWisejDemos.ForeColor = System.Drawing.Color.FromName("@demoPanelText-demo");
            this.labelNavigationWisejDemos.Location = new System.Drawing.Point(3, 3);
            this.labelNavigationWisejDemos.Name = "labelNavigationWisejDemos";
            this.labelNavigationWisejDemos.Size = new System.Drawing.Size(101, 22);
            this.labelNavigationWisejDemos.TabIndex = 5;
            this.labelNavigationWisejDemos.Text = "Wisej Demos";
            // 
            // labelNavigationSeparator1
            // 
            this.labelNavigationSeparator1.AutoSize = true;
            this.labelNavigationSeparator1.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelNavigationSeparator1.ForeColor = System.Drawing.Color.FromName("@highlightText-demo");
            this.labelNavigationSeparator1.Location = new System.Drawing.Point(110, 3);
            this.labelNavigationSeparator1.Name = "labelNavigationSeparator1";
            this.labelNavigationSeparator1.Size = new System.Drawing.Size(14, 18);
            this.labelNavigationSeparator1.TabIndex = 6;
            this.labelNavigationSeparator1.Text = ">";
            // 
            // labelNaivgationCategory
            // 
            this.labelNaivgationCategory.AutoSize = true;
            this.labelNaivgationCategory.Font = new System.Drawing.Font("@defaultDemo", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelNaivgationCategory.ForeColor = System.Drawing.Color.FromName("@demoPanelText-demo");
            this.labelNaivgationCategory.Location = new System.Drawing.Point(130, 3);
            this.labelNaivgationCategory.Name = "labelNaivgationCategory";
            this.labelNaivgationCategory.Size = new System.Drawing.Size(54, 19);
            this.labelNaivgationCategory.TabIndex = 7;
            this.labelNaivgationCategory.Text = "Editors";
            // 
            // labelNavigationSeparator2
            // 
            this.labelNavigationSeparator2.AutoSize = true;
            this.labelNavigationSeparator2.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelNavigationSeparator2.ForeColor = System.Drawing.Color.FromName("@highlightText-demo");
            this.labelNavigationSeparator2.Location = new System.Drawing.Point(190, 3);
            this.labelNavigationSeparator2.Name = "labelNavigationSeparator2";
            this.labelNavigationSeparator2.Size = new System.Drawing.Size(14, 18);
            this.labelNavigationSeparator2.TabIndex = 8;
            this.labelNavigationSeparator2.Text = ">";
            // 
            // labelNavigationControl
            // 
            this.labelNavigationControl.AutoSize = true;
            this.labelNavigationControl.Font = new System.Drawing.Font("@defaultDemo", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelNavigationControl.ForeColor = System.Drawing.Color.FromName("@demoPanelText-demo");
            this.labelNavigationControl.Location = new System.Drawing.Point(210, 3);
            this.labelNavigationControl.Name = "labelNavigationControl";
            this.labelNavigationControl.Size = new System.Drawing.Size(84, 19);
            this.labelNavigationControl.TabIndex = 10;
            this.labelNavigationControl.Text = "ComboBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromName("@highlightText-demo");
            this.label2.Location = new System.Drawing.Point(300, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = ">";
            // 
            // labelNavigationDemo
            // 
            this.labelNavigationDemo.AutoSize = true;
            this.labelNavigationDemo.Font = new System.Drawing.Font("@defaultBoldDemo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelNavigationDemo.ForeColor = System.Drawing.Color.FromName("@highlightText-demo");
            this.labelNavigationDemo.Location = new System.Drawing.Point(320, 3);
            this.labelNavigationDemo.Name = "labelNavigationDemo";
            this.labelNavigationDemo.Size = new System.Drawing.Size(116, 19);
            this.labelNavigationDemo.TabIndex = 9;
            this.labelNavigationDemo.Text = "Simple Binding";
            // 
            // panelLinks
            // 
            this.panelLinks.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.panelLinks.BackColor = System.Drawing.Color.FromName("@controlText");
            this.panelLinks.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panelLinks.Controls.Add(this.buttonDocumentation);
            this.panelLinks.Controls.Add(this.line5);
            this.panelLinks.Controls.Add(this.buttonSourceCode);
            this.panelLinks.CssStyle = "border-width: 1px;\r\nborder-color: #D2D8DB;\r\nborder-right-style: none;\r\nborder-rad" +
    "ius: 6px 0px 0px 6px;\r\n";
            this.panelLinks.Location = new System.Drawing.Point(1318, 71);
            this.panelLinks.Name = "panelLinks";
            this.panelLinks.Size = new System.Drawing.Size(64, 125);
            this.panelLinks.TabIndex = 22;
            this.panelLinks.TabStop = true;
            // 
            // buttonDocumentation
            // 
            this.buttonDocumentation.AppearanceKey = "button-demo";
            this.buttonDocumentation.BackColor = System.Drawing.Color.Transparent;
            this.buttonDocumentation.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.buttonDocumentation.BackgroundImageSource = "Images/book.png";
            this.buttonDocumentation.Dock = Wisej.Web.DockStyle.Top;
            this.buttonDocumentation.Focusable = false;
            this.buttonDocumentation.Location = new System.Drawing.Point(0, 66);
            this.buttonDocumentation.Name = "buttonDocumentation";
            this.buttonDocumentation.Size = new System.Drawing.Size(62, 55);
            this.buttonDocumentation.TabIndex = 2;
            this.buttonDocumentation.Click += new System.EventHandler(this.buttonDocumentation_Click);
            // 
            // line5
            // 
            this.line5.Dock = Wisej.Web.DockStyle.Top;
            this.line5.Location = new System.Drawing.Point(0, 55);
            this.line5.Name = "line5";
            this.line5.Padding = new Wisej.Web.Padding(9, 0, 9, 0);
            this.line5.Size = new System.Drawing.Size(62, 11);
            // 
            // buttonSourceCode
            // 
            this.buttonSourceCode.AppearanceKey = "button-demo";
            this.buttonSourceCode.BackColor = System.Drawing.Color.Transparent;
            this.buttonSourceCode.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.buttonSourceCode.BackgroundImageSource = "Images/html.png";
            this.buttonSourceCode.Dock = Wisej.Web.DockStyle.Top;
            this.buttonSourceCode.Focusable = false;
            this.buttonSourceCode.Location = new System.Drawing.Point(0, 0);
            this.buttonSourceCode.Name = "buttonSourceCode";
            this.buttonSourceCode.Size = new System.Drawing.Size(62, 55);
            this.buttonSourceCode.TabIndex = 0;
            this.buttonSourceCode.Click += new System.EventHandler(this.buttonSourceCode_Click);
            // 
            // line4
            // 
            this.line4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.line4.Location = new System.Drawing.Point(39, 224);
            this.line4.MinimumSize = new System.Drawing.Size(300, 0);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(1250, 5);
            // 
            // labelDescription
            // 
            this.labelDescription.AllowHtml = true;
            this.labelDescription.Font = new System.Drawing.Font("default", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.ForeColor = System.Drawing.Color.FromName("@demoPanelText-demo");
            this.labelDescription.Location = new System.Drawing.Point(38, 136);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(820, 73);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "You can use Wisej to display your data however you want. This demo demonstrates h" +
    "ow you can present data with just a simple array.";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("@condensedWindowTitle", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.ForeColor = System.Drawing.Color.FromName("@demoPanelText-demo");
            this.labelTitle.Location = new System.Drawing.Point(115, 67);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1174, 67);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "ComboBox Simple Binding";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxControl
            // 
            this.pictureBoxControl.ForeColor = System.Drawing.Color.FromName("@demoPanelText-demo");
            this.pictureBoxControl.ImageSource = "Images\\combo.png";
            this.pictureBoxControl.Location = new System.Drawing.Point(29, 58);
            this.pictureBoxControl.Name = "pictureBoxControl";
            this.pictureBoxControl.Padding = new Wisej.Web.Padding(10);
            this.pictureBoxControl.Size = new System.Drawing.Size(80, 82);
            this.pictureBoxControl.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Location = new System.Drawing.Point(39, 228);
            this.panel1.MinimumSize = new System.Drawing.Size(300, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 50);
            this.panel1.TabIndex = 25;
            this.panel1.TabStop = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.AppearanceKey = "button-demo";
            this.buttonPrevious.Focusable = false;
            this.buttonPrevious.Font = new System.Drawing.Font("@defaultDemo", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonPrevious.ImageSource = "icon-left";
            this.buttonPrevious.Location = new System.Drawing.Point(1, 5);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(130, 40);
            this.buttonPrevious.TabIndex = 20;
            this.buttonPrevious.Text = "Prev Demo";
            this.buttonPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonNext.AppearanceKey = "button-demo";
            this.buttonNext.Focusable = false;
            this.buttonNext.Font = new System.Drawing.Font("@defaultDemo", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonNext.ImageSource = "icon-right";
            this.buttonNext.Location = new System.Drawing.Point(1119, 5);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(130, 40);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = "Next Demo";
            this.buttonNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNext.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelComponents);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(1727, 849);
            this.Text = "Wisej Demo Browser";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.menuSlideBar.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.panelComponents.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelLinks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.FlexLayoutPanel panelMenu;
        private Web.ComboBox comboBoxTheme;
        private Web.PictureBox pictureBoxLogo;
        private Web.ImageList imageList1;
		private Web.Button buttonContact;
		private Web.Button buttonFreeTrial;
		private Web.Button buttonBuy;
		private Web.Button buttonMWW;
		private Web.Button buttonSupport;
		private Web.Button buttonAPI;
		private Web.Button buttonDocs;
		private Web.Line lineMenuDivider2;
		private Web.Line lineMenuDivider3;
		private Web.Line lineMenuDivider1;
		private Web.Panel panelComponents;
		private Web.Panel panelSearch;
		private Web.TextBox textBoxSearch;
		private Web.Button buttonSearch;
		private Web.Button buttonCollapse;
		private Web.TreeView treeViewComponents;
		private Web.Panel panelContainer;
		private Web.SlideBar menuSlideBar;
		public Web.FlowLayoutPanel flowLayoutPanel1;
		private Web.Label labelNavigationWisejDemos;
		private Web.Label labelNavigationSeparator1;
		public Web.Label labelNaivgationCategory;
		private Web.Label labelNavigationSeparator2;
		public Web.Label labelNavigationDemo;
		public Web.Label labelDescription;
		public Web.Label labelTitle;
		public Web.PictureBox pictureBoxControl;
		private Web.Line line4;
		public Web.Panel panelDemo;
		private Web.Button buttonNext;
		private Web.Panel panelLinks;
		private Web.Button buttonDocumentation;
		private Web.Line line5;
		private Web.Button buttonSourceCode;
		private Web.Line line6;
		public Web.Label labelNavigationControl;
		private Web.Label label2;
		private Web.Panel rightPanel;
		private Web.Panel panel1;
		private Web.Button buttonPrevious;
		private Web.ComboBox comboBoxLanguage;
	}
}
