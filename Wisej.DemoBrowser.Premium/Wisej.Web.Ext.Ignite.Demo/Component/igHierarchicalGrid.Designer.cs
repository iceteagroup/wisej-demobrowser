namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igHierarchicalGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igHierarchicalGrid));
            this.button1 = new Wisej.Web.Button();
            this.igHierarchicalGrid1 = new Wisej.Web.Ext.Ignite.igHierarchicalGrid();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igHierarchicalGrid1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/hierarchical-grid/overview";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igHierarchicalGrid";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/ighierarchicalgrid-ighierarchicalgrid";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.checkBox5);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            // 
            // button1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.button1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.button1, true);
            this.button1.Location = new System.Drawing.Point(3, 300);
            this.button1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add new Item";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // igHierarchicalGrid1
            // 
            this.igHierarchicalGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.igHierarchicalGrid1.Location = new System.Drawing.Point(20, 15);
            this.igHierarchicalGrid1.Name = "igHierarchicalGrid1";
            this.igHierarchicalGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igHierarchicalGrid1.Options"))));
            this.igHierarchicalGrid1.Size = new System.Drawing.Size(1048, 528);
            this.igHierarchicalGrid1.TabIndex = 0;
            this.igHierarchicalGrid1.Text = "igHierarchicalGrid1";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 60);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 38);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Alternate Row Styles";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 38);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable Hover Styles";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox3, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox3, true);
            this.checkBox3.Location = new System.Drawing.Point(3, 117);
            this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(212, 50);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Expand Collapse Animations";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 186);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 38);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Fixed Footers";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox5, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox5, true);
            this.checkBox5.Location = new System.Drawing.Point(3, 243);
            this.checkBox5.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(212, 38);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Fixed Headers";
            // 
            // igHierarchicalGrid
            // 
            this.MinimumSize = new System.Drawing.Size(1234, 660);
            this.Name = "igHierarchicalGrid";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Ignite.igHierarchicalGrid igHierarchicalGrid1;
		private Button button1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
	}
}
