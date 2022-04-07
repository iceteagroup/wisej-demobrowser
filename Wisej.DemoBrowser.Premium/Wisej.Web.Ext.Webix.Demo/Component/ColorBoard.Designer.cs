namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class ColorBoard
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
            this.colorBoard1 = new Wisej.Web.Ext.Webix.ColorBoard();
            this.checkBoxGrayScale = new Wisej.Web.CheckBox();
            this.comboBoxType = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__colorboard.html";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#colorboard";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.colorboard.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.colorBoard1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxGrayScale);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxType);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 434);
            // 
            // colorBoard1
            // 
            this.colorBoard1.Anchor = Wisej.Web.AnchorStyles.None;
            this.colorBoard1.Location = new System.Drawing.Point(294, 79);
            this.colorBoard1.Name = "colorBoard1";
            this.colorBoard1.Size = new System.Drawing.Size(500, 400);
            this.colorBoard1.TabIndex = 0;
            this.colorBoard1.Text = "colorBoard1";
            // 
            // checkBoxGrayScale
            // 
            this.checkBoxGrayScale.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxGrayScale.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxGrayScale.AutoSize = false;
            this.checkBoxGrayScale.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxGrayScale, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxGrayScale, true);
            this.checkBoxGrayScale.Location = new System.Drawing.Point(3, 3);
            this.checkBoxGrayScale.Name = "checkBoxGrayScale";
            this.checkBoxGrayScale.Size = new System.Drawing.Size(212, 26);
            this.checkBoxGrayScale.TabIndex = 0;
            this.checkBoxGrayScale.Text = "Gray Scale";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxType, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxType, true);
            this.comboBoxType.Items.AddRange(new object[] {
            "material",
            "classic"});
            this.comboBoxType.LabelText = "Type";
            this.comboBoxType.Location = new System.Drawing.Point(3, 48);
            this.comboBoxType.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(212, 57);
            this.comboBoxType.TabIndex = 1;
            // 
            // ColorBoard
            // 
            this.Name = "ColorBoard";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.ColorBoard colorBoard1;
        private CheckBox checkBoxGrayScale;
        private ComboBox comboBoxType;
    }
}
