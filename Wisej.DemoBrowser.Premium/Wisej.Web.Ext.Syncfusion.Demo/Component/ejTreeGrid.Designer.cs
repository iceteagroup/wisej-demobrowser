namespace Wisej.Web.Ext.Syncfusion.Demo
{
	partial class ejTreeGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejTreeGrid));
            this.ejTreeGrid1 = new Wisej.Web.Ext.Syncfusion.ejTreeGrid();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.buttonGetSelectedCells = new Wisej.Web.Button();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.checkBox6 = new Wisej.Web.CheckBox();
            this.checkBox7 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/treegrid/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.buttonGetSelectedCells);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 553);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonGetSelectedCells, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox5, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox6, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox7, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 456);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(592, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/treegrid/DefaultFunctionalities";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejtreegrid";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejTreeGrid1);
            this.panel.TabIndex = 7;
            // 
            // ejTreeGrid1
            // 
            this.ejTreeGrid1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejTreeGrid1.Location = new System.Drawing.Point(8, 8);
            this.ejTreeGrid1.Name = "ejTreeGrid1";
            this.ejTreeGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejTreeGrid1.Options"))));
            this.ejTreeGrid1.Size = new System.Drawing.Size(1073, 542);
            this.ejTreeGrid1.TabIndex = 0;
            this.ejTreeGrid1.Text = "ejTreeGrid1";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(28, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 30);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Allow TextWrap";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.checkBox2.Location = new System.Drawing.Point(28, 80);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 30);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Allow Selection";
            // 
            // buttonGetSelectedCells
            // 
            this.buttonGetSelectedCells.Location = new System.Drawing.Point(28, 412);
            this.buttonGetSelectedCells.Name = "buttonGetSelectedCells";
            this.buttonGetSelectedCells.Size = new System.Drawing.Size(195, 30);
            this.buttonGetSelectedCells.TabIndex = 7;
            this.buttonGetSelectedCells.Text = "Get Selected Cells";
            this.buttonGetSelectedCells.Click += new System.EventHandler(this.buttonGetSelectedCells_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(28, 124);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 47);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Allow Column Reordering";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Location = new System.Drawing.Point(28, 185);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(195, 47);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Allow Column Resize";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Location = new System.Drawing.Point(28, 246);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(195, 47);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Allow Drag and Drop";
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox6.AutoSize = false;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox6.Location = new System.Drawing.Point(28, 307);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(195, 30);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Allow Filtering";
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox7.AutoSize = false;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox7.Checked = true;
            this.checkBox7.Location = new System.Drawing.Point(28, 351);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(195, 47);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Allow Keyboard Navigation";
            // 
            // ejTreeGrid
            // 
            this.Name = "ejTreeGrid";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejTreeGrid ejTreeGrid1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private Button buttonGetSelectedCells;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox7;
		private CheckBox checkBox6;
	}
}
