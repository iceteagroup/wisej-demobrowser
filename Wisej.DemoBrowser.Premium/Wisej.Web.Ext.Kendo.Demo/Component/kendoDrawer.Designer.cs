namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoDrawer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoDrawer));
            this.buttonShow = new Wisej.Web.Button();
            this.buttonHide = new Wisej.Web.Button();
            this.kendoDrawer1 = new Wisej.Web.Ext.Kendo.kendoDrawer();
            this.comboBoxMode = new Wisej.Web.ComboBox();
            this.buttonSh = new Wisej.Web.Button();
            this.buttonHi = new Wisej.Web.Button();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoDrawer1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonHide);
            this.groupBox1.Controls.Add(this.buttonShow);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonShow, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonHide, 0);
            this.groupBox1.Controls.SetChildIndex(this.flowLayoutPanelProperties, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(16, 472);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/drawer/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/drawer";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/navigation/drawer/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxMode);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonSh);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonHi);
            this.flowLayoutPanelProperties.Location = new System.Drawing.Point(16, 35);
            this.flowLayoutPanelProperties.Size = new System.Drawing.Size(218, 437);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(28, 49);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(195, 35);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(28, 90);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(195, 35);
            this.buttonHide.TabIndex = 2;
            this.buttonHide.Text = "Hide";
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // kendoDrawer1
            // 
            this.kendoDrawer1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoDrawer1.Location = new System.Drawing.Point(434, 112);
            this.kendoDrawer1.Name = "kendoDrawer1";
            this.kendoDrawer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoDrawer1.Options"))));
            this.kendoDrawer1.Size = new System.Drawing.Size(232, 334);
            this.kendoDrawer1.TabIndex = 0;
            this.kendoDrawer1.Text = "kendoDrawer1";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxMode.Items.AddRange(new object[] {
            "push",
            "overlay"});
            this.comboBoxMode.LabelText = "Mode";
            this.comboBoxMode.Location = new System.Drawing.Point(3, 3);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(212, 46);
            this.comboBoxMode.TabIndex = 0;
            // 
            // buttonSh
            // 
            this.buttonSh.Location = new System.Drawing.Point(3, 55);
            this.buttonSh.Name = "buttonSh";
            this.buttonSh.Size = new System.Drawing.Size(100, 27);
            this.buttonSh.TabIndex = 1;
            this.buttonSh.Text = "Show";
            this.buttonSh.Click += new System.EventHandler(this.buttonSh_Click);
            // 
            // buttonHi
            // 
            this.buttonHi.Location = new System.Drawing.Point(109, 55);
            this.buttonHi.Name = "buttonHi";
            this.buttonHi.Size = new System.Drawing.Size(100, 27);
            this.buttonHi.TabIndex = 2;
            this.buttonHi.Text = "Hide";
            this.buttonHi.Click += new System.EventHandler(this.buttonHi_Click);
            // 
            // kendoDrawer
            // 
            this.Name = "kendoDrawer";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDrawer kendoDrawer1;
		private Button buttonHide;
		private Button buttonShow;
        private ComboBox comboBoxMode;
        private Button buttonSh;
        private Button buttonHi;
    }
}
