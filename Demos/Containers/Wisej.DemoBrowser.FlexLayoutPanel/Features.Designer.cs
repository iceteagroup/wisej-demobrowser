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
            this.btnConfirm = new Wisej.Web.Button();
            this.cmbGender = new Wisej.Web.ComboBox();
            this.chkSubscribe = new Wisej.Web.CheckBox();
            this.cmbLayoutStyle = new Wisej.Web.ComboBox();
            this.cmbHorizontalAlignement = new Wisej.Web.ComboBox();
            this.cmbVerticalAlignement = new Wisej.Web.ComboBox();
            this.flexLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flexLayoutPanel3
            // 
            this.flexLayoutPanel3.Anchor = Wisej.Web.AnchorStyles.None;
            this.flexLayoutPanel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flexLayoutPanel3.Controls.Add(this.txtUsername);
            this.flexLayoutPanel3.Controls.Add(this.txtEmail);
            this.flexLayoutPanel3.Controls.Add(this.txtPassword);
            this.flexLayoutPanel3.Controls.Add(this.cmbGender);
            this.flexLayoutPanel3.Controls.Add(this.chkSubscribe);
            this.flexLayoutPanel3.Controls.Add(this.btnConfirm);
            this.flexLayoutPanel3.HorizontalAlign = Wisej.Web.HorizontalAlignment.Center;
            this.flexLayoutPanel3.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.flexLayoutPanel3.Location = new System.Drawing.Point(626, 6);
            this.flexLayoutPanel3.Margin = new Wisej.Web.Padding(6);
            this.flexLayoutPanel3.Name = "flexLayoutPanel3";
            this.flexLayoutPanel3.Padding = new Wisej.Web.Padding(3);
            this.flexLayoutPanel3.ShowCloseButton = false;
            this.flexLayoutPanel3.ShowHeader = true;
            this.flexLayoutPanel3.Size = new System.Drawing.Size(566, 462);
            this.flexLayoutPanel3.TabIndex = 4;
            this.flexLayoutPanel3.TabStop = true;
            this.flexLayoutPanel3.Text = "LayoutStyle Vertical";
            this.flexLayoutPanel3.VerticalAlign = Wisej.Web.VerticalAlignment.Middle;
            // 
            // txtUsername
            // 
            this.txtUsername.LabelText = "Username";
            this.txtUsername.Location = new System.Drawing.Point(6, 41);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(552, 53);
            this.txtUsername.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.LabelText = "E-Mail";
            this.txtEmail.Location = new System.Drawing.Point(6, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(552, 53);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.LabelText = "Password";
            this.txtPassword.Location = new System.Drawing.Point(6, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(552, 53);
            this.txtPassword.TabIndex = 4;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(105, 205, 116);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnConfirm.Location = new System.Drawing.Point(6, 356);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(552, 34);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            // 
            // cmbGender
            // 
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.LabelText = "Gender";
            this.cmbGender.Location = new System.Drawing.Point(6, 248);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(552, 53);
            this.cmbGender.TabIndex = 6;
            // 
            // chkSubscribe
            // 
            this.chkSubscribe.Location = new System.Drawing.Point(6, 317);
            this.chkSubscribe.Name = "chkSubscribe";
            this.chkSubscribe.Size = new System.Drawing.Size(552, 23);
            this.chkSubscribe.TabIndex = 7;
            this.chkSubscribe.Text = "Subscribe To Newsletter";
            // 
            // cmbLayoutStyle
            // 
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
            // 
            // cmbHorizontalAlignement
            // 
            this.cmbHorizontalAlignement.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Center"});
            this.cmbHorizontalAlignement.LabelText = "HorizontalAlignement";
            this.cmbHorizontalAlignement.Location = new System.Drawing.Point(231, 218);
            this.cmbHorizontalAlignement.Name = "cmbHorizontalAlignement";
            this.cmbHorizontalAlignement.Size = new System.Drawing.Size(230, 53);
            this.cmbHorizontalAlignement.TabIndex = 6;
            // 
            // cmbVerticalAlignement
            // 
            this.cmbVerticalAlignement.Items.AddRange(new object[] {
            "Top",
            "Center",
            "Bottom"});
            this.cmbVerticalAlignement.LabelText = "VerticalAlignement";
            this.cmbVerticalAlignement.Location = new System.Drawing.Point(231, 298);
            this.cmbVerticalAlignement.Name = "cmbVerticalAlignement";
            this.cmbVerticalAlignement.Size = new System.Drawing.Size(230, 53);
            this.cmbVerticalAlignement.TabIndex = 7;
            // 
            // Features
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.cmbVerticalAlignement);
            this.Controls.Add(this.cmbHorizontalAlignement);
            this.Controls.Add(this.cmbLayoutStyle);
            this.Controls.Add(this.flexLayoutPanel3);
            this.MinimumSize = new System.Drawing.Size(940, 400);
            this.Name = "Features";
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
        private Web.ComboBox cmbHorizontalAlignement;
        private Web.ComboBox cmbVerticalAlignement;
    }
}
