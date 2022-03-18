namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxForm));
			this.dxForm1 = new Wisej.Web.Ext.DevExtreme.dxForm();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.button1 = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Form/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxForm/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 468);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 383);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxForm1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Form/Overview/jQuery/Light/";
			// 
			// dxForm1
			// 
			this.dxForm1.Anchor = Wisej.Web.AnchorStyles.None;
			this.dxForm1.Location = new System.Drawing.Point(283, 54);
			this.dxForm1.Name = "dxForm1";
			this.dxForm1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxForm1.Options"))));
			this.dxForm1.Size = new System.Drawing.Size(523, 450);
			this.dxForm1.TabIndex = 0;
			this.dxForm1.Text = "dxForm1";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Label Location";
			this.comboBox1.Location = new System.Drawing.Point(28, 260);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Text = "Top";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Show Optional Mark";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.Location = new System.Drawing.Point(28, 92);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 14;
			this.checkBox2.Text = "Show Required Mark";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Checked = true;
			this.checkBox3.Location = new System.Drawing.Point(28, 148);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 15;
			this.checkBox3.Text = "Scrolling Enabled";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Checked = true;
			this.checkBox4.Location = new System.Drawing.Point(28, 204);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 38);
			this.checkBox4.TabIndex = 16;
			this.checkBox4.Text = "Show Validation Summary";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 338);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 17;
			this.button1.Text = "Reset Values";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dxForm
			// 
			this.Name = "dxForm";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxForm dxForm1;
        private ComboBox comboBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private CheckBox checkBox3;
		private Button button1;
		private CheckBox checkBox4;
	}
}
