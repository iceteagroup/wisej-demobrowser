namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxTreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxTreeView));
            this.dxTreeView1 = new Wisej.Web.Ext.DevExtreme.dxTreeView();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.checkBox6 = new Wisej.Web.CheckBox();
            this.checkBox7 = new Wisej.Web.CheckBox();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/TreeView/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/TreeView/HierarchicalDataStru" +
    "cture/jQuery/Light/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxTreeView/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxTreeView1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.checkBox5);
            this.flowLayoutPanel1.Controls.Add(this.checkBox6);
            this.flowLayoutPanel1.Controls.Add(this.checkBox7);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox2);
            // 
            // dxTreeView1
            // 
            this.dxTreeView1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dxTreeView1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.dxTreeView1.Location = new System.Drawing.Point(294, 118);
            this.dxTreeView1.Name = "dxTreeView1";
            this.dxTreeView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxTreeView1.Options"))));
            this.dxTreeView1.Size = new System.Drawing.Size(300, 340);
            this.dxTreeView1.TabIndex = 0;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 7);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 7, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 48);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "Expand Nodes Recursive";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox5, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox5, true);
            this.checkBox5.Location = new System.Drawing.Point(3, 65);
            this.checkBox5.Margin = new Wisej.Web.Padding(3, 7, 3, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(212, 38);
            this.checkBox5.TabIndex = 17;
            this.checkBox5.Text = "Hover State Enabled";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "both",
            "horizontal",
            "vertical"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Scroll Direction";
            this.comboBox1.Location = new System.Drawing.Point(3, 210);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "vertical";
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox6.AutoSize = false;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox6, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox6, true);
            this.checkBox6.Location = new System.Drawing.Point(3, 113);
            this.checkBox6.Margin = new Wisej.Web.Padding(3, 7, 3, 3);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(212, 38);
            this.checkBox6.TabIndex = 19;
            this.checkBox6.Text = "Search Enabled";
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox7.AutoSize = false;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox7, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox7, true);
            this.checkBox7.Location = new System.Drawing.Point(3, 161);
            this.checkBox7.Margin = new Wisej.Web.Padding(3, 7, 3, 3);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(212, 38);
            this.checkBox7.TabIndex = 20;
            this.checkBox7.Text = "Select by Click";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoSize = false;
            this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox2, true);
            this.comboBox2.Items.AddRange(new object[] {
            "none",
            "normal",
            "selectAll"});
            this.comboBox2.Label.Size = 50;
            this.comboBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox2.LabelText = "Show CheckBoxes Mode";
            this.comboBox2.Location = new System.Drawing.Point(3, 281);
            this.comboBox2.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 60);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.Text = "none";
            // 
            // dxTreeView
            // 
            this.AutoScroll = true;
            this.Name = "dxTreeView";
            this.Load += new System.EventHandler(this.dxTreeView_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxTreeView dxTreeView1;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private ComboBox comboBox2;
		private CheckBox checkBox7;
		private CheckBox checkBox6;
		private ComboBox comboBox1;
	}
}
