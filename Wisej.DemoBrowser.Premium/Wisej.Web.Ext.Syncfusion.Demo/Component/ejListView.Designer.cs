namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejListView));
            this.ejListView1 = new Wisej.Web.Ext.Syncfusion.ejListView();
            this.textBoxAddNewItem = new Wisej.Web.TextBox();
            this.buttonAddNewItem = new Wisej.Web.Button();
            this.buttonGetSelectedItems = new Wisej.Web.Button();
            this.buttonClearSelected = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/listview/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.buttonClearSelected);
            this.groupBox1.Controls.Add(this.buttonGetSelectedItems);
            this.groupBox1.Size = new System.Drawing.Size(250, 590);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonGetSelectedItems, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonClearSelected, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 505);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(532, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/listview/DefaultFunctionalities";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejlistview";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejListView1);
            this.panel.Size = new System.Drawing.Size(1091, 585);
            this.panel.TabIndex = 7;
            // 
            // ejListView1
            // 
            this.ejListView1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejListView1.Location = new System.Drawing.Point(8, 8);
            this.ejListView1.Name = "ejListView1";
            this.ejListView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejListView1.Options"))));
            this.ejListView1.Size = new System.Drawing.Size(1073, 567);
            this.ejListView1.TabIndex = 0;
            this.ejListView1.Text = "ejListView1";
            // 
            // textBoxAddNewItem
            // 
            this.textBoxAddNewItem.AutoSize = false;
            this.textBoxAddNewItem.Label.Size = 50;
            this.textBoxAddNewItem.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBoxAddNewItem.LabelText = "Add New Item";
            this.textBoxAddNewItem.Location = new System.Drawing.Point(3, 3);
            this.textBoxAddNewItem.Name = "textBoxAddNewItem";
            this.textBoxAddNewItem.Size = new System.Drawing.Size(195, 60);
            this.textBoxAddNewItem.TabIndex = 0;
            this.textBoxAddNewItem.Text = "Top 1000 Albums";
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.Location = new System.Drawing.Point(2, 69);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(195, 30);
            this.buttonAddNewItem.TabIndex = 1;
            this.buttonAddNewItem.Text = "Add Item";
            this.buttonAddNewItem.Click += new System.EventHandler(this.buttonAddNewItem_Click);
            // 
            // buttonGetSelectedItems
            // 
            this.buttonGetSelectedItems.Location = new System.Drawing.Point(28, 381);
            this.buttonGetSelectedItems.Name = "buttonGetSelectedItems";
            this.buttonGetSelectedItems.Size = new System.Drawing.Size(195, 30);
            this.buttonGetSelectedItems.TabIndex = 4;
            this.buttonGetSelectedItems.Text = "Get Selected Items";
            this.buttonGetSelectedItems.Click += new System.EventHandler(this.buttonGetSelectedItems_Click);
            // 
            // buttonClearSelected
            // 
            this.buttonClearSelected.Location = new System.Drawing.Point(28, 443);
            this.buttonClearSelected.Name = "buttonClearSelected";
            this.buttonClearSelected.Size = new System.Drawing.Size(195, 30);
            this.buttonClearSelected.TabIndex = 5;
            this.buttonClearSelected.Text = "Clear Selected Items";
            this.buttonClearSelected.Click += new System.EventHandler(this.buttonClearSelected_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxAddNewItem);
            this.panel1.Controls.Add(this.buttonAddNewItem);
            this.panel1.Location = new System.Drawing.Point(28, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 103);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable CheckMark";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(28, 106);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 38);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Enable Filtering";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(28, 176);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 38);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Enable Group List";
            // 
            // ejListView
            // 
            this.Name = "ejListView";
            this.Size = new System.Drawing.Size(1500, 775);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejListView ejListView1;
		private TextBox textBoxAddNewItem;
		private Button buttonAddNewItem;
		private Button buttonGetSelectedItems;
		private Button buttonClearSelected;
		private Panel panel1;
		private CheckBox checkBox1;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
	}
}
