namespace Wisej.DemoBrowser.FlexLayoutPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
            this.flexLayoutPanel3 = new Wisej.Web.FlexLayoutPanel();
            this.txtEmail = new Wisej.Web.TextBox();
            this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
            this.txtUsername = new Wisej.Web.TextBox();
            this.txtPassword = new Wisej.Web.TextBox();
            this.cmbGender = new Wisej.Web.ComboBox();
            this.chkSubscribe = new Wisej.Web.CheckBox();
            this.btnConfirm = new Wisej.Web.Button();
            this.flexLayoutPanel3.SuspendLayout();
            this.flexLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flexLayoutPanel3
            // 
            this.flexLayoutPanel3.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.flexLayoutPanel3.AutoScroll = true;
            this.flexLayoutPanel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flexLayoutPanel3.Controls.Add(this.txtEmail);
            this.flexLayoutPanel3.Controls.Add(this.flexLayoutPanel1);
            this.flexLayoutPanel3.Controls.Add(this.cmbGender);
            this.flexLayoutPanel3.Controls.Add(this.chkSubscribe);
            this.flexLayoutPanel3.Controls.Add(this.btnConfirm);
            this.flexLayoutPanel3.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center;
            this.flexLayoutPanel3.HeaderSize = 38;
            this.flexLayoutPanel3.HorizontalAlign = Wisej.Web.HorizontalAlignment.Center;
            this.flexLayoutPanel3.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.flexLayoutPanel3.Location = new System.Drawing.Point(76, 48);
            this.flexLayoutPanel3.Margin = new Wisej.Web.Padding(6);
            this.flexLayoutPanel3.MinimumSize = new System.Drawing.Size(332, 443);
            this.flexLayoutPanel3.Name = "flexLayoutPanel3";
            this.flexLayoutPanel3.Padding = new Wisej.Web.Padding(20);
            this.flexLayoutPanel3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flexLayoutPanel3.ResponsiveProfiles"))));
            this.flexLayoutPanel3.ShowCloseButton = false;
            this.flexLayoutPanel3.ShowHeader = true;
            this.flexLayoutPanel3.Size = new System.Drawing.Size(756, 582);
            this.flexLayoutPanel3.TabIndex = 0;
            this.flexLayoutPanel3.TabStop = true;
            this.flexLayoutPanel3.Text = "Vertical Layout (VBox)";
            this.flexLayoutPanel3.VerticalAlign = Wisej.Web.VerticalAlignment.Middle;
            // 
            // txtEmail
            // 
            this.txtEmail.LabelText = "E-Mail";
            this.txtEmail.Location = new System.Drawing.Point(23, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtEmail.ResponsiveProfiles"))));
            this.txtEmail.Size = new System.Drawing.Size(708, 42);
            this.txtEmail.TabIndex = 0;
            // 
            // flexLayoutPanel1
            // 
            this.flexLayoutPanel1.Controls.Add(this.txtUsername);
            this.flexLayoutPanel1.Controls.Add(this.txtPassword);
            this.flexLayoutPanel1.HeaderBackColor = System.Drawing.Color.FromName("@control");
            this.flexLayoutPanel1.HeaderForeColor = System.Drawing.Color.FromName("@controlText");
            this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            this.flexLayoutPanel1.Location = new System.Drawing.Point(23, 150);
            this.flexLayoutPanel1.Name = "flexLayoutPanel1";
            this.flexLayoutPanel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flexLayoutPanel1.ResponsiveProfiles"))));
            this.flexLayoutPanel1.ShowCloseButton = false;
            this.flexLayoutPanel1.ShowHeader = true;
            this.flexLayoutPanel1.Size = new System.Drawing.Size(708, 112);
            this.flexLayoutPanel1.TabIndex = 1;
            this.flexLayoutPanel1.Text = "HBox Layout";
            // 
            // txtUsername
            // 
            this.flexLayoutPanel1.SetFillWeight(this.txtUsername, 1);
            this.txtUsername.LabelText = "Username";
            this.txtUsername.Location = new System.Drawing.Point(3, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtUsername.ResponsiveProfiles"))));
            this.txtUsername.Size = new System.Drawing.Size(343, 78);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.flexLayoutPanel1.SetFillWeight(this.txtPassword, 1);
            this.txtPassword.LabelText = "Password";
            this.txtPassword.Location = new System.Drawing.Point(362, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("txtPassword.ResponsiveProfiles"))));
            this.txtPassword.Size = new System.Drawing.Size(343, 78);
            this.txtPassword.TabIndex = 1;
            // 
            // cmbGender
            // 
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.LabelText = "Gender";
            this.cmbGender.Location = new System.Drawing.Point(23, 278);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("cmbGender.ResponsiveProfiles"))));
            this.cmbGender.Size = new System.Drawing.Size(708, 42);
            this.cmbGender.TabIndex = 2;
            // 
            // chkSubscribe
            // 
            this.chkSubscribe.Location = new System.Drawing.Point(23, 336);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("chkSubscribe.ResponsiveProfiles"))));
            this.chkSubscribe.Size = new System.Drawing.Size(708, 22);
            this.chkSubscribe.TabIndex = 3;
            this.chkSubscribe.Text = "Subscribe To Newsletter";
            // 
            // btnConfirm
            // 
            this.flexLayoutPanel3.SetAlignX(this.btnConfirm, Wisej.Web.HorizontalAlignment.Right);
            this.btnConfirm.AppearanceKey = "button-ok";
            this.btnConfirm.Location = new System.Drawing.Point(431, 374);
            this.btnConfirm.MaximumSize = new System.Drawing.Size(300, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnConfirm.ResponsiveProfiles"))));
            this.btnConfirm.Size = new System.Drawing.Size(300, 59);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            // 
            // Features
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flexLayoutPanel3);
            this.Name = "Features";
            this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
            this.Size = new System.Drawing.Size(909, 678);
            this.flexLayoutPanel3.ResumeLayout(false);
            this.flexLayoutPanel3.PerformLayout();
            this.flexLayoutPanel1.ResumeLayout(false);
            this.flexLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Web.FlexLayoutPanel flexLayoutPanel3;
        private Web.TextBox txtUsername;
        private Web.TextBox txtEmail;
        private Web.TextBox txtPassword;
        private Web.Button btnConfirm;
        private Web.ComboBox cmbGender;
        private Web.CheckBox chkSubscribe;
		private Web.FlexLayoutPanel flexLayoutPanel1;
	}
}
