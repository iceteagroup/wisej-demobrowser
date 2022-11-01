namespace Wisej.DemoBrowser.DataRepeater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
            this.dataRepeater1 = new Wisej.Web.DataRepeater();
            this.panel1 = new Wisej.Web.Panel();
            this.labelEmail = new Wisej.Web.Label();
            this.labelCompany = new Wisej.Web.Label();
            this.buttonSelect = new Wisej.Web.Button();
            this.labelName = new Wisej.Web.Label();
            this.pictureBoxProfile = new Wisej.Web.PictureBox();
            this.checkBoxScrollbar = new Wisej.Web.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).BeginInit();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dataRepeater1.BackgroundImageLayout = Wisej.Web.ImageLayout.Tile;
            this.dataRepeater1.BorderStyle = Wisej.Web.BorderStyle.None;
            this.dataRepeater1.CssClass = "shadow";
            this.dataRepeater1.ItemHeaderVisible = false;
            this.dataRepeater1.ItemSize = new System.Drawing.Size(200, 94);
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Controls.Add(this.panel1);
            this.dataRepeater1.ItemTemplate.CssStyle = "border-bottom: none;";
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(1024, 94);
            this.dataRepeater1.Location = new System.Drawing.Point(199, 54);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.PrefetchItems = 25;
            this.dataRepeater1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("dataRepeater1.ResponsiveProfiles"))));
            this.dataRepeater1.ScrollBarVisible = false;
            this.dataRepeater1.Size = new System.Drawing.Size(1024, 420);
            this.dataRepeater1.TabIndex = 0;
            this.dataRepeater1.Text = "dataRepeater1";
            this.dataRepeater1.VirtualMode = true;
            this.dataRepeater1.ItemUpdate += new Wisej.Web.DataRepeaterItemEventHandler(this.dataRepeater1_ItemUpdate);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelCompany);
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.pictureBoxProfile);
            this.panel1.CssClass = "shadow";
            this.panel1.CssStyle = "transition: background-color 0.2s ease;\r\n";
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles"))));
            this.panel1.Size = new System.Drawing.Size(1016, 88);
            this.panel1.TabIndex = 7;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // labelEmail
            // 
            this.labelEmail.Anonymous = true;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(89, 60);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(85, 18);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email Address";
            // 
            // labelCompany
            // 
            this.labelCompany.Anonymous = true;
            this.labelCompany.AutoEllipsis = true;
            this.labelCompany.Location = new System.Drawing.Point(89, 36);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(868, 18);
            this.labelCompany.TabIndex = 11;
            this.labelCompany.Text = "ACME Corp.";
            // 
            // buttonSelect
            // 
            this.buttonSelect.AppearanceKey = "panel";
            this.buttonSelect.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelect.BorderStyle = Wisej.Web.BorderStyle.None;
            this.buttonSelect.Cursor = Wisej.Web.Cursors.Hand;
            this.buttonSelect.Dock = Wisej.Web.DockStyle.Right;
            this.buttonSelect.ImageSource = "icon-right";
            this.buttonSelect.Location = new System.Drawing.Point(963, 0);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("buttonSelect.ResponsiveProfiles"))));
            this.buttonSelect.Size = new System.Drawing.Size(53, 88);
            this.buttonSelect.TabIndex = 9;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelName
            // 
            this.labelName.Anonymous = true;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelName.Location = new System.Drawing.Point(89, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(116, 18);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name LastName 0";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Anonymous = true;
            this.pictureBoxProfile.CssStyle = "border-radius: 100px;\r\nborder: 2px solid gray;";
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(65, 65);
            this.pictureBoxProfile.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // checkBoxScrollbar
            // 
            this.checkBoxScrollbar.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxScrollbar.Location = new System.Drawing.Point(202, 12);
            this.checkBoxScrollbar.Name = "checkBoxScrollbar";
            this.checkBoxScrollbar.Padding = new Wisej.Web.Padding(0, 0, 0, 16);
            this.checkBoxScrollbar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("checkBoxScrollbar.ResponsiveProfiles"))));
            this.checkBoxScrollbar.Size = new System.Drawing.Size(144, 36);
            this.checkBoxScrollbar.TabIndex = 1;
            this.checkBoxScrollbar.Text = "Scrollbar Visible";
            this.checkBoxScrollbar.CheckedChanged += new System.EventHandler(this.checkBoxScrollbar_CheckedChanged);
            // 
            // Features
            // 
            this.Controls.Add(this.dataRepeater1);
            this.Controls.Add(this.checkBoxScrollbar);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).EndInit();
            this.dataRepeater1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private Web.DataRepeater dataRepeater1;
        private Web.Panel panel1;
        private Web.Label labelName;
        private Web.PictureBox pictureBoxProfile;
        private Web.Button buttonSelect;
        private Web.CheckBox checkBoxScrollbar;
        private Web.Label labelEmail;
        private Web.Label labelCompany;
    }
}
