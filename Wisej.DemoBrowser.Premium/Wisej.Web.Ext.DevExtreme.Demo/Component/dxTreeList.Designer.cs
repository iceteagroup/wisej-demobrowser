namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxTreeList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxTreeList));
			this.dxTreeList1 = new Wisej.Web.Ext.DevExtreme.dxTreeList();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.checkBox5 = new Wisej.Web.CheckBox();
			this.checkBox6 = new Wisej.Web.CheckBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.checkBox7 = new Wisej.Web.CheckBox();
			this.checkBox8 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/TreeList/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxTreeList/";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.checkBox8);
			this.groupBox1.Controls.Add(this.checkBox7);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.checkBox6);
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 1122);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox5, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox6, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox7, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox8, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 874);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.panel.Controls.Add(this.dxTreeList1);
			this.panel.Size = new System.Drawing.Size(1091, 626);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/TreeList/Overview/jQuery/Ligh" +
    "t/";
			// 
			// dxTreeList1
			// 
			this.dxTreeList1.Anchor = Wisej.Web.AnchorStyles.None;
			this.dxTreeList1.Location = new System.Drawing.Point(244, 87);
			this.dxTreeList1.Name = "dxTreeList1";
			this.dxTreeList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxTreeList1.Options"))));
			this.dxTreeList1.Size = new System.Drawing.Size(601, 450);
			this.dxTreeList1.TabIndex = 0;
			this.dxTreeList1.Text = "dxTreeList1";
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
			this.checkBox1.Text = "Allow Column Reordering";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 92);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 14;
			this.checkBox2.Text = "Allow Column Resizing";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Location = new System.Drawing.Point(28, 148);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 15;
			this.checkBox3.Text = "Auto Expand All";
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
			this.checkBox4.Text = "Auto Navigate to Focused Row";
			// 
			// checkBox5
			// 
			this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox5.AutoSize = false;
			this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox5.Location = new System.Drawing.Point(28, 260);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(195, 38);
			this.checkBox5.TabIndex = 17;
			this.checkBox5.Text = "Column Chooser Enabled";
			// 
			// checkBox6
			// 
			this.checkBox6.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox6.AutoSize = false;
			this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox6.Location = new System.Drawing.Point(28, 372);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(195, 38);
			this.checkBox6.TabIndex = 18;
			this.checkBox6.Text = "Column Hiding Enabled";
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "nextColumn",
            "widget"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Column Resizing Mode";
			this.comboBox1.Location = new System.Drawing.Point(28, 484);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 22;
			this.comboBox1.Text = "nextColumn";
			// 
			// checkBox7
			// 
			this.checkBox7.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox7.AutoSize = false;
			this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox7.Checked = true;
			this.checkBox7.Location = new System.Drawing.Point(28, 428);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(195, 38);
			this.checkBox7.TabIndex = 23;
			this.checkBox7.Text = "Expand Nodes on Filtering";
			// 
			// checkBox8
			// 
			this.checkBox8.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox8.AutoSize = false;
			this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox8.Location = new System.Drawing.Point(28, 316);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(195, 38);
			this.checkBox8.TabIndex = 24;
			this.checkBox8.Text = "Allow Column Search";
			// 
			// dxTreeList
			// 
			this.AutoScroll = true;
			this.Name = "dxTreeList";
			this.Size = new System.Drawing.Size(1500, 816);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxTreeList dxTreeList1;
		private CheckBox checkBox6;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private ComboBox comboBox1;
		private CheckBox checkBox8;
		private CheckBox checkBox7;
	}
}
