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
            this.dataRepeater1 = new Wisej.Web.DataRepeater();
            this.buttonSelect = new Wisej.Web.Button();
            this.labelPhone = new Wisej.Web.Label();
            this.labelAddress = new Wisej.Web.Label();
            this.labelName = new Wisej.Web.Label();
            this.pictureBoxProfile = new Wisej.Web.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).BeginInit();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dataRepeater1.ItemSize = new System.Drawing.Size(200, 72);
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.BackColor = System.Drawing.Color.White;
            this.dataRepeater1.ItemTemplate.Controls.Add(this.buttonSelect);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.labelPhone);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.labelAddress);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.labelName);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.pictureBoxProfile);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(1327, 72);
            this.dataRepeater1.Location = new System.Drawing.Point(47, 22);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.PrefetchItems = 25;
            this.dataRepeater1.Size = new System.Drawing.Size(1329, 430);
            this.dataRepeater1.TabIndex = 0;
            this.dataRepeater1.Text = "dataRepeater1";
            this.dataRepeater1.VirtualMode = true;
            this.dataRepeater1.ItemUpdate += new Wisej.Web.DataRepeaterItemEventHandler(this.dataRepeater1_ItemUpdate);
            // 
            // buttonSelect
            // 
            this.buttonSelect.AppearanceKey = "panel";
            this.buttonSelect.BackColor = System.Drawing.Color.White;
            this.buttonSelect.BorderStyle = Wisej.Web.BorderStyle.None;
            this.buttonSelect.Cursor = Wisej.Web.Cursors.Hand;
            this.buttonSelect.Dock = Wisej.Web.DockStyle.Right;
            this.buttonSelect.ImageSource = "icon-right";
            this.buttonSelect.Location = new System.Drawing.Point(1287, 0);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(20, 72);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(75, 27);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 18);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(75, 48);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(51, 18);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelName.Location = new System.Drawing.Point(74, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(116, 18);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name LastName 0";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.pictureBoxProfile.CssStyle = "border-radius: 100px;\r\nborder: 2px solid gray;";
            this.pictureBoxProfile.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(66, 66);
            this.pictureBoxProfile.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // Features
            // 
            this.Controls.Add(this.dataRepeater1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).EndInit();
            this.dataRepeater1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private Web.DataRepeater dataRepeater1;
		private Web.Label labelAddress;
		private Web.Label labelName;
		private Web.PictureBox pictureBoxProfile;
		private Web.Label labelPhone;
		private Web.Button buttonSelect;
	}
}
