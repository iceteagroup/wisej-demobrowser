namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igDateEditor
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
			this.igDateEditor1 = new Wisej.Web.Ext.Ignite.igDateEditor();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.button1 = new Wisej.Web.Button();
			this.comboBox3 = new Wisej.Web.ComboBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.comboBox3);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 428);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 344);
			this.buttonUpdate.TabIndex = 5;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igDateEditor1);
			this.panel.Size = new System.Drawing.Size(455, 428);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/editors/date-editor";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igdateeditor";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igeditors-landingpage";
			// 
			// igDateEditor1
			// 
			this.igDateEditor1.Anchor = Wisej.Web.AnchorStyles.None;
			this.igDateEditor1.Location = new System.Drawing.Point(79, 193);
			this.igDateEditor1.Name = "igDateEditor1";
			this.igDateEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"dateInputFormat\":\"dateTime\",\"value\":\"2020-01-01\",\"dataMode\":\"date\"}")));
			this.igDateEditor1.Size = new System.Drawing.Size(295, 40);
			this.igDateEditor1.TabIndex = 0;
			this.igDateEditor1.Text = "igDateEditor1";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "clear",
            "spin"});
			this.comboBox1.Label.Text = "Button Type";
			this.comboBox1.Location = new System.Drawing.Point(28, 98);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 41);
			this.comboBox1.TabIndex = 1;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
            "selectAll",
            "atStart",
            "atEnd",
            "browserDefault"});
			this.comboBox2.Label.Text = "Selection on Focus";
			this.comboBox2.Location = new System.Drawing.Point(28, 163);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 41);
			this.comboBox2.TabIndex = 2;
			this.comboBox2.Text = "selectAll";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 293);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 4;
			this.button1.Text = "Get Selected Date";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox3
			// 
			this.comboBox3.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox3.Items.AddRange(new object[] {
            "date",
            "displayModeText",
            "editModeText"});
			this.comboBox3.Label.Text = "Data Mode";
			this.comboBox3.Location = new System.Drawing.Point(28, 228);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(195, 41);
			this.comboBox3.TabIndex = 3;
			this.comboBox3.Text = "date";
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
			this.checkBox1.Text = "Revert if Not Valid";
			// 
			// igDateEditor
			// 
			this.Name = "igDateEditor";
			this.Size = new System.Drawing.Size(864, 618);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igDateEditor igDateEditor1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private Button button1;
		private ComboBox comboBox3;
		private CheckBox checkBox1;
	}
}
