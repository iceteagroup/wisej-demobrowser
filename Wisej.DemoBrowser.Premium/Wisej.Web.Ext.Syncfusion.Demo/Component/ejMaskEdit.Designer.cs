namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejMaskEdit
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
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.textBox1 = new Wisej.Web.TextBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.label4 = new Wisej.Web.Label();
            this.ejMaskEdit1 = new Wisej.Web.Ext.Syncfusion.ejMaskEdit();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/maskedit/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 430);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 344);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "N/A";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejmaskedit";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.ejMaskEdit1);
            this.panel.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Password",
            "Text"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Input Mode";
            this.comboBox1.Location = new System.Drawing.Point(28, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 60);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.Label.Size = 50;
            this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox1.LabelText = "Custom Character";
            this.textBox1.Location = new System.Drawing.Point(28, 259);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 60);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "*";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(28, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 57);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Hide Prompt on Leave";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.checkBox2.Location = new System.Drawing.Point(28, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 31);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Show Prompt Char";
            // 
            // label4
            // 
            this.label4.Anchor = Wisej.Web.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password Format";
            // 
            // ejMaskEdit1
            // 
            this.ejMaskEdit1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejMaskEdit1.Location = new System.Drawing.Point(394, 262);
            this.ejMaskEdit1.Name = "ejMaskEdit1";
            this.ejMaskEdit1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"watermarkText\":\"Enter password\",\"inputMode\":\"Password\"}")));
            this.ejMaskEdit1.Size = new System.Drawing.Size(300, 35);
            this.ejMaskEdit1.TabIndex = 3;
            this.ejMaskEdit1.Text = "ejMaskEdit1";
            // 
            // ejMaskEdit
            // 
            this.Name = "ejMaskEdit";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private ComboBox comboBox1;
		private TextBox textBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private Label label4;
		private Syncfusion.ejMaskEdit ejMaskEdit1;
	}
}
