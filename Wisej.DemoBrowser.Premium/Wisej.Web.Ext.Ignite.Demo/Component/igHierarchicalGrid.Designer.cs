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
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Size = new System.Drawing.Size(250, 469);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox5, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 385);
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igHierarchicalGrid1);
			this.panel.Size = new System.Drawing.Size(455, 469);
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 336);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
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
			this.igHierarchicalGrid1.Size = new System.Drawing.Size(412, 437);
			this.igHierarchicalGrid1.TabIndex = 0;
			this.igHierarchicalGrid1.Text = "igHierarchicalGrid1";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(28, 96);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Alternate Row Styles";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Enable Hover Styles";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox3.Location = new System.Drawing.Point(28, 156);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Expand Collapse Animations";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox4.Location = new System.Drawing.Point(28, 216);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(195, 38);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Fixed Footers";
			// 
			// checkBox5
			// 
			this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox5.AutoSize = false;
			this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox5.Checked = true;
			this.checkBox5.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox5.Location = new System.Drawing.Point(28, 276);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(195, 38);
			this.checkBox5.TabIndex = 4;
			this.checkBox5.Text = "Fixed Headers";
			// 
			// igHierarchicalGrid
			// 
			this.Name = "igHierarchicalGrid";
			this.Size = new System.Drawing.Size(864, 659);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
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
