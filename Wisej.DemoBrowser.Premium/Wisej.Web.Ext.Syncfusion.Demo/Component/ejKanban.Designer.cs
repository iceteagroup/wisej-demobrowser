namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejKanban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejKanban));
            this.ejKanban1 = new Wisej.Web.Ext.Syncfusion.ejKanban();
            this.buttonSave = new Wisej.Web.Button();
            this.buttonLoad = new Wisej.Web.Upload();
            this.buttonGetVisibleColumnNames = new Wisej.Web.Button();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/kanban/overview";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(574, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/kanban/Columns/HeaderTemplate";
            // 
            // linkApi
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "https://help.syncfusion.com/api/js/ejkanban";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejKanban1);
            this.panel.TabIndex = 7;
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox3);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox4);
            this.flowLayoutPanelProperties.Controls.Add(this.checkBox5);
            this.flowLayoutPanelProperties.Controls.Add(this.comboBox1);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonLoad);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonSave);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonGetVisibleColumnNames);
            // 
            // ejKanban1
            // 
            this.ejKanban1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejKanban1.Location = new System.Drawing.Point(8, 8);
            this.ejKanban1.Name = "ejKanban1";
            this.ejKanban1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejKanban1.Options"))));
            this.ejKanban1.Size = new System.Drawing.Size(872, 560);
            this.ejKanban1.TabIndex = 0;
            this.ejKanban1.Text = "ejKanban1";
            // 
            // buttonSave
            // 
            this.buttonSave.Display = Wisej.Web.Display.Icon;
            this.flowLayoutPanelProperties.SetFlowBreak(this.buttonSave, true);
            this.buttonSave.ImageSource = "icon-save";
            this.buttonSave.Location = new System.Drawing.Point(51, 315);
            this.buttonSave.Margin = new Wisej.Web.Padding(3, 14, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(42, 42);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".json";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(3, 315);
            this.buttonLoad.Margin = new Wisej.Web.Padding(3, 14, 3, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 42);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
            // 
            // buttonGetVisibleColumnNames
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.buttonGetVisibleColumnNames, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.buttonGetVisibleColumnNames, true);
            this.buttonGetVisibleColumnNames.Location = new System.Drawing.Point(3, 374);
            this.buttonGetVisibleColumnNames.Margin = new Wisej.Web.Padding(3, 14, 3, 3);
            this.buttonGetVisibleColumnNames.Name = "buttonGetVisibleColumnNames";
            this.buttonGetVisibleColumnNames.Size = new System.Drawing.Size(212, 35);
            this.buttonGetVisibleColumnNames.TabIndex = 8;
            this.buttonGetVisibleColumnNames.Text = "Get Visible Columns";
            this.buttonGetVisibleColumnNames.Click += new System.EventHandler(this.buttonGetVisibleColumnNames_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 30);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Drag and Drop";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanelProperties.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "Single",
            "Multiple"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Selection Type";
            this.comboBox1.Location = new System.Drawing.Point(3, 238);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 14, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Single";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 50);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 14, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 30);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Allow Title";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox3, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox3, true);
            this.checkBox3.Location = new System.Drawing.Point(3, 97);
            this.checkBox3.Margin = new Wisej.Web.Padding(3, 14, 3, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(212, 30);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Allow Searching";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 144);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 14, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 30);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Allow Filtering";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox5, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox5, true);
            this.checkBox5.Location = new System.Drawing.Point(3, 191);
            this.checkBox5.Margin = new Wisej.Web.Padding(3, 14, 3, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(212, 30);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Allow Printing";
            // 
            // ejKanban
            // 
            this.Name = "ejKanban";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.ejKanban ejKanban1;
		private Upload buttonLoad;
		private Button buttonSave;
		private Button buttonGetVisibleColumnNames;
		private CheckBox checkBox1;
		private ComboBox comboBox1;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox5;
	}
}
