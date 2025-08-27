namespace Wisej.DemoBrowser.PropertyGrid
{
    partial class PersonCard
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
            this.panel1 = new Wisej.Web.Panel();
            this.pbVip = new Wisej.Web.PictureBox();
            this.label1 = new Wisej.Web.Label();
            this.lblIssued = new Wisej.Web.Label();
            this.panel2 = new Wisej.Web.Panel();
            this.label2 = new Wisej.Web.Label();
            this.lblDob = new Wisej.Web.Label();
            this.lblDobTxt = new Wisej.Web.Label();
            this.pnlFavColor = new Wisej.Web.Panel();
            this.lblFirstName = new Wisej.Web.Label();
            this.lblFirstNameTxt = new Wisej.Web.Label();
            this.lblLastName = new Wisej.Web.Label();
            this.lblLastNameTxt = new Wisej.Web.Label();
            this.lblGender = new Wisej.Web.Label();
            this.lblGenderTxt = new Wisej.Web.Label();
            this.lblAddress = new Wisej.Web.Label();
            this.lblAddressTxt = new Wisej.Web.Label();
            this.barcode1 = new Wisej.Web.Ext.Barcode.Barcode();
            this.lblID = new Wisej.Web.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVip)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbVip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 44);
            this.panel1.TabIndex = 0;
            // 
            // pbVip
            // 
            this.pbVip.Anchor = Wisej.Web.AnchorStyles.Right;
            this.pbVip.ImageSource = "resource.wx/Wisej.DemoBrowser.PropertyGrid/wisej.png";
            this.pbVip.Location = new System.Drawing.Point(541, 6);
            this.pbVip.Name = "pbVip";
            this.pbVip.Size = new System.Drawing.Size(37, 32);
            this.pbVip.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Wisej.Web.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("defaultBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wisej.NET Identification Card";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIssued
            // 
            this.lblIssued.AutoSize = true;
            this.lblIssued.Location = new System.Drawing.Point(12, 266);
            this.lblIssued.Name = "lblIssued";
            this.lblIssued.Size = new System.Drawing.Size(46, 15);
            this.lblIssued.TabIndex = 2;
            this.lblIssued.Text = "Issued:  ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblDob);
            this.panel2.Controls.Add(this.lblDobTxt);
            this.panel2.Controls.Add(this.pnlFavColor);
            this.panel2.Controls.Add(this.lblFirstName);
            this.panel2.Controls.Add(this.lblFirstNameTxt);
            this.panel2.Controls.Add(this.lblLastName);
            this.panel2.Controls.Add(this.lblLastNameTxt);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.lblGenderTxt);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblAddressTxt);
            this.panel2.Location = new System.Drawing.Point(210, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 187);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = Wisej.Web.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(3, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Favorite Color: ";
            // 
            // lblDob
            // 
            this.lblDob.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDob.Location = new System.Drawing.Point(3, 124);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(38, 15);
            this.lblDob.TabIndex = 17;
            this.lblDob.Text = "DOB: ";
            // 
            // lblDobTxt
            // 
            this.lblDobTxt.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblDobTxt.AutoSize = true;
            this.lblDobTxt.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDobTxt.Location = new System.Drawing.Point(106, 124);
            this.lblDobTxt.Name = "lblDobTxt";
            this.lblDobTxt.Size = new System.Drawing.Size(72, 15);
            this.lblDobTxt.TabIndex = 18;
            this.lblDobTxt.Text = "dateofbirth";
            // 
            // pnlFavColor
            // 
            this.pnlFavColor.Anchor = Wisej.Web.AnchorStyles.Left;
            this.pnlFavColor.Location = new System.Drawing.Point(107, 157);
            this.pnlFavColor.Name = "pnlFavColor";
            this.pnlFavColor.Size = new System.Drawing.Size(27, 27);
            this.pnlFavColor.TabIndex = 16;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFirstName.Location = new System.Drawing.Point(3, 8);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 15);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblFirstNameTxt
            // 
            this.lblFirstNameTxt.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblFirstNameTxt.AutoSize = true;
            this.lblFirstNameTxt.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFirstNameTxt.Location = new System.Drawing.Point(106, 8);
            this.lblFirstNameTxt.Name = "lblFirstNameTxt";
            this.lblFirstNameTxt.Size = new System.Drawing.Size(63, 15);
            this.lblFirstNameTxt.TabIndex = 9;
            this.lblFirstNameTxt.Text = "firstname";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastName.Location = new System.Drawing.Point(3, 37);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 15);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name: ";
            // 
            // lblLastNameTxt
            // 
            this.lblLastNameTxt.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblLastNameTxt.AutoSize = true;
            this.lblLastNameTxt.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastNameTxt.Location = new System.Drawing.Point(106, 37);
            this.lblLastNameTxt.Name = "lblLastNameTxt";
            this.lblLastNameTxt.Size = new System.Drawing.Size(61, 15);
            this.lblLastNameTxt.TabIndex = 11;
            this.lblLastNameTxt.Text = "lastname";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblGender.Location = new System.Drawing.Point(3, 66);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 15);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender: ";
            // 
            // lblGenderTxt
            // 
            this.lblGenderTxt.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblGenderTxt.AutoSize = true;
            this.lblGenderTxt.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblGenderTxt.Location = new System.Drawing.Point(106, 66);
            this.lblGenderTxt.Name = "lblGenderTxt";
            this.lblGenderTxt.Size = new System.Drawing.Size(48, 15);
            this.lblGenderTxt.TabIndex = 13;
            this.lblGenderTxt.Text = "gender";
            this.lblGenderTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAddress.Location = new System.Drawing.Point(3, 95);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 15);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address: ";
            // 
            // lblAddressTxt
            // 
            this.lblAddressTxt.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblAddressTxt.AutoEllipsis = true;
            this.lblAddressTxt.AutoSize = true;
            this.lblAddressTxt.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAddressTxt.Location = new System.Drawing.Point(106, 95);
            this.lblAddressTxt.Name = "lblAddressTxt";
            this.lblAddressTxt.Size = new System.Drawing.Size(54, 15);
            this.lblAddressTxt.TabIndex = 15;
            this.lblAddressTxt.Text = "address";
            // 
            // barcode1
            // 
            this.barcode1.Anchor = Wisej.Web.AnchorStyles.Left;
            this.barcode1.BarcodeType = Wisej.Web.Ext.Barcode.BarcodeType.QR;
            this.barcode1.Location = new System.Drawing.Point(12, 73);
            this.barcode1.Name = "barcode1";
            this.barcode1.Size = new System.Drawing.Size(187, 178);
            this.barcode1.TabIndex = 5;
            this.barcode1.Text = "SDFSDFSDF";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(210, 266);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(39, 15);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "label2";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonCard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = Wisej.Web.ImageLayout.Center;
            this.BackgroundImageSource = "(none)";
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.barcode1);
            this.Controls.Add(this.lblIssued);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.CssClass = "shadow";
            this.Name = "PersonCard";
            this.Padding = new Wisej.Web.Padding(5);
            this.Size = new System.Drawing.Size(598, 306);
            this.Load += new System.EventHandler(this.PersonCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVip)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Panel panel1;
        private Web.Label lblIssued;
        private Web.Label label1;
        private Web.Panel panel2;
        private Web.Label lblFirstName;
        private Web.Label lblFirstNameTxt;
        private Web.Label lblLastName;
        private Web.Label lblLastNameTxt;
        private Web.Label lblGender;
        private Web.Label lblGenderTxt;
        private Web.Label lblAddress;
        private Web.Label lblAddressTxt;
        private Web.Ext.Barcode.Barcode barcode1;
        private Web.Label lblID;
        private Web.Label lblDob;
        private Web.Label lblDobTxt;
        private Web.Panel pnlFavColor;
        private Web.PictureBox pbVip;
        private Web.Label label2;
    }
}
