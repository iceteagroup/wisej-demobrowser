namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxList));
			this.dxList1 = new Wisej.Web.Ext.DevExtreme.dxList();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.comboBox3 = new Wisej.Web.ComboBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.checkBox5 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/List/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxList/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.comboBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 622);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox5, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 534);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxList1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/List/ListEditingAndAPI/jQuery" +
    "/Light/";
			// 
			// dxList1
			// 
			this.dxList1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxList1.Location = new System.Drawing.Point(27, 29);
			this.dxList1.Name = "dxList1";
			this.dxList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxList1.Options"))));
			this.dxList1.Size = new System.Drawing.Size(1034, 499);
			this.dxList1.TabIndex = 0;
			this.dxList1.Text = "dxList1";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Search Enabled";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "contains",
            "startswith",
            "equals"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Search Mode";
			this.comboBox1.Location = new System.Drawing.Point(28, 306);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 9;
			this.comboBox1.Text = "contains";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 90);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 10;
			this.checkBox2.Text = "Bounce Enabled";
			// 
			// comboBox3
			// 
			this.comboBox3.AutoSize = false;
			this.comboBox3.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox3.Items.AddRange(new object[] {
            "context",
            "slideButton",
            "slideItem",
            "static",
            "swipe",
            "toggle"});
			this.comboBox3.Label.Size = 50;
			this.comboBox3.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox3.LabelText = "Item Delete Mode";
			this.comboBox3.Location = new System.Drawing.Point(28, 458);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(195, 60);
			this.comboBox3.TabIndex = 11;
			this.comboBox3.Text = "static";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Location = new System.Drawing.Point(28, 144);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 12;
			this.checkBox3.Text = "Pull Refresh Enabled";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Location = new System.Drawing.Point(28, 198);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 38);
			this.checkBox4.TabIndex = 13;
			this.checkBox4.Text = "Repaint changes Only";
			// 
			// comboBox2
			// 
			this.comboBox2.AutoSize = false;
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
            "all",
            "multiple",
            "none",
            "single"});
			this.comboBox2.Label.Size = 50;
			this.comboBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox2.LabelText = "Selection Mode";
			this.comboBox2.Location = new System.Drawing.Point(28, 382);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 60);
			this.comboBox2.TabIndex = 14;
			this.comboBox2.Text = "all";
			// 
			// checkBox5
			// 
			this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox5.AutoSize = false;
			this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox5.Checked = true;
			this.checkBox5.Location = new System.Drawing.Point(28, 252);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(195, 38);
			this.checkBox5.TabIndex = 15;
			this.checkBox5.Text = "Show Selection Controls";
			// 
			// dxList
			// 
			this.Name = "dxList";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxList dxList1;
		private CheckBox checkBox1;
		private ComboBox comboBox1;
		private CheckBox checkBox5;
		private ComboBox comboBox2;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private ComboBox comboBox3;
		private CheckBox checkBox2;
	}
}
