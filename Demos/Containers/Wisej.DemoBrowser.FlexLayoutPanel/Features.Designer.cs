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
            this.flexLayoutPanel3 = new Wisej.Web.FlexLayoutPanel();
            this.txtUsername = new Wisej.Web.TextBox();
            this.txtEmail = new Wisej.Web.TextBox();
            this.txtPassword = new Wisej.Web.TextBox();
            this.cmbGender = new Wisej.Web.ComboBox();
            this.chkSubscribe = new Wisej.Web.CheckBox();
            this.btnConfirm = new Wisej.Web.Button();
            this.cmbLayoutStyle = new Wisej.Web.ComboBox();
            this.cmbHorizontalAlignment = new Wisej.Web.ComboBox();
            this.cmbVerticalAlignment = new Wisej.Web.ComboBox();
            this.flexLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flexLayoutPanel3
            // 
            this.flexLayoutPanel3.Anchor = Wisej.Web.AnchorStyles.None;
            this.flexLayoutPanel3.AutoScroll = true;
            this.flexLayoutPanel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flexLayoutPanel3.Controls.Add(this.txtUsername);
            this.flexLayoutPanel3.Controls.Add(this.txtEmail);
            this.flexLayoutPanel3.Controls.Add(this.txtPassword);
            this.flexLayoutPanel3.Controls.Add(this.cmbGender);
            this.flexLayoutPanel3.Controls.Add(this.chkSubscribe);
            this.flexLayoutPanel3.Controls.Add(this.btnConfirm);
            this.flexLayoutPanel3.HeaderAlignment = Wisej.Web.HorizontalAlignment.Center;
            this.flexLayoutPanel3.HorizontalAlign = Wisej.Web.HorizontalAlignment.Center;
            this.flexLayoutPanel3.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.flexLayoutPanel3.Location = new System.Drawing.Point(626, 6);
            this.flexLayoutPanel3.Margin = new Wisej.Web.Padding(6);
            this.flexLayoutPanel3.Name = "flexLayoutPanel3";
            this.flexLayoutPanel3.Padding = new Wisej.Web.Padding(3);
            this.flexLayoutPanel3.ShowCloseButton = false;
            this.flexLayoutPanel3.Size = new System.Drawing.Size(566, 462);
            this.flexLayoutPanel3.TabIndex = 4;
            this.flexLayoutPanel3.TabStop = true;
            this.flexLayoutPanel3.VerticalAlign = Wisej.Web.VerticalAlignment.Middle;
            // 
            // txtUsername
            // 
            this.txtUsername.LabelText = "Username";
            this.txtUsername.Location = new System.Drawing.Point(6, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(552, 53);
            this.txtUsername.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.LabelText = "E-Mail";
            this.txtEmail.Location = new System.Drawing.Point(6, 124);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(552, 53);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.LabelText = "Password";
            this.txtPassword.Location = new System.Drawing.Point(6, 193);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(552, 53);
            this.txtPassword.TabIndex = 4;
            // 
            // cmbGender
            // 
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.LabelText = "Gender";
            this.cmbGender.Location = new System.Drawing.Point(6, 262);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(552, 53);
            this.cmbGender.TabIndex = 6;
            // 
            // chkSubscribe
            // 
            this.chkSubscribe.Location = new System.Drawing.Point(6, 331);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.Size = new System.Drawing.Size(552, 23);
            this.chkSubscribe.TabIndex = 7;
            this.chkSubscribe.Text = "Subscribe To Newsletter";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(105, 205, 116);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnConfirm.Location = new System.Drawing.Point(6, 370);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(552, 34);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            // 
            // cmbLayoutStyle
            // 
            this.cmbLayoutStyle.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbLayoutStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbLayoutStyle.Items.AddRange(new object[] {
            "Default",
            "Vertical",
            "Horizontal"});
            this.cmbLayoutStyle.LabelText = "LayoutStyle";
            this.cmbLayoutStyle.Location = new System.Drawing.Point(231, 144);
            this.cmbLayoutStyle.Name = "cmbLayoutStyle";
            this.cmbLayoutStyle.Size = new System.Drawing.Size(230, 53);
            this.cmbLayoutStyle.TabIndex = 5;
            this.cmbLayoutStyle.SelectedIndexChanged += new System.EventHandler(this.cmbLayoutStyle_SelectedIndexChanged);
            // 
            // cmbHorizontalAlignment
            // 
            this.cmbHorizontalAlignment.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbHorizontalAlignment.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Center"});
            this.cmbHorizontalAlignment.LabelText = "HorizontalAlignment";
            this.cmbHorizontalAlignment.Location = new System.Drawing.Point(231, 218);
            this.cmbHorizontalAlignment.Name = "cmbHorizontalAlignment";
            this.cmbHorizontalAlignment.Size = new System.Drawing.Size(230, 53);
            this.cmbHorizontalAlignment.TabIndex = 6;
            this.cmbHorizontalAlignment.SelectedIndexChanged += new System.EventHandler(this.cmbHorizontalAlignment_SelectedIndexChanged);
            // 
            // cmbVerticalAlignment
            // 
            this.cmbVerticalAlignment.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbVerticalAlignment.Items.AddRange(new object[] {
            "Top",
            "Middle",
            "Bottom"});
            this.cmbVerticalAlignment.LabelText = "VerticalAlignment";
            this.cmbVerticalAlignment.Location = new System.Drawing.Point(231, 298);
            this.cmbVerticalAlignment.Name = "cmbVerticalAlignment";
            this.cmbVerticalAlignment.Size = new System.Drawing.Size(230, 53);
            this.cmbVerticalAlignment.TabIndex = 7;
            this.cmbVerticalAlignment.SelectedIndexChanged += new System.EventHandler(this.cmbVerticalAlignment_SelectedIndexChanged);
            // 
            // Features
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.cmbVerticalAlignment);
            this.Controls.Add(this.cmbHorizontalAlignment);
            this.Controls.Add(this.cmbLayoutStyle);
            this.Controls.Add(this.flexLayoutPanel3);
            this.MinimumSize = new System.Drawing.Size(940, 400);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.flexLayoutPanel3.ResumeLayout(false);
            this.flexLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Web.FlexLayoutPanel flexLayoutPanel3;
        private Web.TextBox txtUsername;
        private Web.TextBox txtEmail;
        private Web.TextBox txtPassword;
        private Web.Button btnConfirm;
        private Web.ComboBox cmbGender;
        private Web.CheckBox chkSubscribe;
        private Web.ComboBox cmbLayoutStyle;
        private Web.ComboBox cmbHorizontalAlignment;
        private Web.ComboBox cmbVerticalAlignment;
    }
}
