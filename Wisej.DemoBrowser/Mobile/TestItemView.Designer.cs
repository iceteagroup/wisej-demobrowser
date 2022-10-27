namespace Wisej.DemoBrowser
{
	public partial class TestItemView
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
            this.labelTitle = new Wisej.Web.Label();
            this.pictureBoxIcon = new Wisej.Web.PictureBox();
            this.buttonMenu = new Wisej.Web.Button();
            this.flowLayoutPanelMain = new Wisej.Web.FlowLayoutPanel();
            this.labelContent1 = new Wisej.Web.Label();
            this.labelContent2 = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.flowLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AllowHtml = true;
            this.labelTitle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.labelTitle.Anonymous = true;
            this.flowLayoutPanelMain.SetFillWeight(this.labelTitle, 1);
            this.flowLayoutPanelMain.SetFlowBreak(this.labelTitle, true);
            this.labelTitle.Font = new System.Drawing.Font("@defaultBoldDemo", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.Location = new System.Drawing.Point(3, 49);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(134, 22);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Features tes test";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Anonymous = true;
            this.pictureBoxIcon.ImageSource = "Images\\test.png";
            this.pictureBoxIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxIcon.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonMenu.Anonymous = true;
            this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelMain.SetFillWeight(this.buttonMenu, 1);
            this.flowLayoutPanelMain.SetFlowBreak(this.buttonMenu, true);
            this.buttonMenu.Focusable = false;
            this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMenu.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/show-more-button-with-three-dots.svg?color=#" +
    "979797";
            this.buttonMenu.InitScript = "this.setShowArrow(false);";
            this.buttonMenu.Location = new System.Drawing.Point(49, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(88, 40);
            this.buttonMenu.TabIndex = 2;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Anonymous = true;
            this.flowLayoutPanelMain.Controls.Add(this.pictureBoxIcon);
            this.flowLayoutPanelMain.Controls.Add(this.buttonMenu);
            this.flowLayoutPanelMain.Controls.Add(this.labelTitle);
            this.flowLayoutPanelMain.Controls.Add(this.labelContent1);
            this.flowLayoutPanelMain.Controls.Add(this.labelContent2);
            this.flowLayoutPanelMain.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanelMain.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(140, 148);
            this.flowLayoutPanelMain.TabIndex = 4;
            // 
            // labelContent1
            // 
            this.labelContent1.AllowHtml = true;
            this.labelContent1.Anonymous = true;
            this.labelContent1.AutoSize = true;
            this.flowLayoutPanelMain.SetFillWeight(this.labelContent1, 1);
            this.flowLayoutPanelMain.SetFlowBreak(this.labelContent1, true);
            this.labelContent1.Location = new System.Drawing.Point(3, 80);
            this.labelContent1.Margin = new Wisej.Web.Padding(3, 6, 3, 3);
            this.labelContent1.Name = "labelContent1";
            this.labelContent1.Size = new System.Drawing.Size(134, 18);
            this.labelContent1.TabIndex = 3;
            this.labelContent1.Text = "&bull; TextBox";
            // 
            // labelContent2
            // 
            this.labelContent2.AllowHtml = true;
            this.labelContent2.Anonymous = true;
            this.labelContent2.AutoSize = true;
            this.flowLayoutPanelMain.SetFillWeight(this.labelContent2, 1);
            this.flowLayoutPanelMain.SetFlowBreak(this.labelContent2, true);
            this.labelContent2.Location = new System.Drawing.Point(3, 104);
            this.labelContent2.Name = "labelContent2";
            this.labelContent2.Size = new System.Drawing.Size(134, 18);
            this.labelContent2.TabIndex = 4;
            this.labelContent2.Text = "&bull; DateTimePicker";
            // 
            // TestItemView
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanelMain);
            this.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;";
            this.Margin = new Wisej.Web.Padding(10);
            this.Name = "TestItemView";
            this.Padding = new Wisej.Web.Padding(10);
            this.Size = new System.Drawing.Size(160, 168);
            this.Load += new System.EventHandler(this.AppItem_Load);
            this.Click += new System.EventHandler(this.AppItemView_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.flowLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Label labelTitle;
		private Web.PictureBox pictureBoxIcon;
		private Web.Button buttonMenu;
		private Web.FlowLayoutPanel flowLayoutPanelMain;
        private Web.Label labelContent1;
        private Web.Label labelContent2;
    }
}
