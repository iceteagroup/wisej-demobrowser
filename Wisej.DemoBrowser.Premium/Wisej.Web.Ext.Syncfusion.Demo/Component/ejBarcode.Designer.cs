﻿namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejBarcode
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
            this.textBox3 = new Wisej.Web.TextBox();
            this.ejBarcode1 = new Wisej.Web.Ext.Syncfusion.ejBarcode();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.textBox1 = new Wisej.Web.TextBox();
            this.textBox2 = new Wisej.Web.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/barcode/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Size = new System.Drawing.Size(250, 527);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox2, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 440);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/barcode/qrbarcode";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejbarcode";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejBarcode1);
            this.panel.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.AutoSize = false;
            this.textBox3.Label.Size = 50;
            this.textBox3.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox3.LabelText = "Text";
            this.textBox3.Location = new System.Drawing.Point(28, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 60);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "HTTP://WISEJ.COM";
            // 
            // ejBarcode1
            // 
            this.ejBarcode1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejBarcode1.Location = new System.Drawing.Point(344, 79);
            this.ejBarcode1.Name = "ejBarcode1";
            this.ejBarcode1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"text\":\"HTTP://WISEJ.COM\"}")));
            this.ejBarcode1.Size = new System.Drawing.Size(400, 400);
            this.ejBarcode1.TabIndex = 0;
            this.ejBarcode1.Text = "HTTP://WISEJ.COM";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "QRBarcode",
            "DataMatrix",
            "Code39",
            "Code39Extended",
            "Code11",
            "Codabar",
            "Code32",
            "Code93",
            "Code93Extended",
            "Code128A",
            "Code128B",
            "Code128C"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Symbology";
            this.comboBox1.Location = new System.Drawing.Point(28, 339);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 60);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "QRBarcode";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.InputType.Type = Wisej.Web.TextBoxType.Color;
            this.textBox1.Label.Size = 50;
            this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox1.LabelText = "Dark Bar Color";
            this.textBox1.Location = new System.Drawing.Point(28, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 60);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.AutoSize = false;
            this.textBox2.InputType.Type = Wisej.Web.TextBoxType.Color;
            this.textBox2.Label.Size = 50;
            this.textBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox2.LabelText = "Light Bar Color";
            this.textBox2.Location = new System.Drawing.Point(28, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 60);
            this.textBox2.TabIndex = 1;
            // 
            // ejBarcode
            // 
            this.Name = "ejBarcode";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private TextBox textBox3;
		private Syncfusion.ejBarcode ejBarcode1;
		private ComboBox comboBox1;
		private TextBox textBox1;
		private TextBox textBox2;
	}
}