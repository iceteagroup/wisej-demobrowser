namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxLookup));
            this.dxLookup1 = new Wisej.Web.Ext.DevExtreme.dxLookup();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Lookup/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Lookup/Basics/jQuery/Light/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxLookup/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxLookup1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.checkBox5);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            // 
            // dxLookup1
            // 
            this.dxLookup1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dxLookup1.Location = new System.Drawing.Point(269, 271);
            this.dxLookup1.Name = "dxLookup1";
            this.dxLookup1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxLookup1.Options"))));
            this.dxLookup1.Size = new System.Drawing.Size(350, 35);
            this.dxLookup1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "instantly",
            "useButtons"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Apply Value Mode";
            this.comboBox1.Location = new System.Drawing.Point(3, 244);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "instantly";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 16);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 38);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Clean Search on Open";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox3, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox3, true);
            this.checkBox3.Location = new System.Drawing.Point(3, 73);
            this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(212, 38);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Close on Outside Click";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 130);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 38);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Is Valid";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox5, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox5, true);
            this.checkBox5.Location = new System.Drawing.Point(3, 187);
            this.checkBox5.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(212, 38);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "Search Enabled";
            // 
            // dxLookup
            // 
            this.Name = "dxLookup";
            this.Size = new System.Drawing.Size(1299, 720);
            this.Load += new System.EventHandler(this.dxLookup_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxLookup dxLookup1;
		private ComboBox comboBox1;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
    }
}
