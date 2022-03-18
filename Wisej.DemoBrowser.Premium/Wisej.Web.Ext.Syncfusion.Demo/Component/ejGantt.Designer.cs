namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejGantt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejGantt));
            this.ejGantt1 = new Wisej.Web.Ext.Syncfusion.ejGantt();
            this.textBox1 = new Wisej.Web.TextBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.textBox2 = new Wisej.Web.TextBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.checkBox7 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/gantt/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 560);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox7, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 465);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(576, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/gantt/Sorting/DefaultFunctionali" +
    "ties";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejgantt";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejGantt1);
            this.panel.TabIndex = 7;
            // 
            // ejGantt1
            // 
            this.ejGantt1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejGantt1.Location = new System.Drawing.Point(8, 8);
            this.ejGantt1.Name = "ejGantt1";
            this.ejGantt1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejGantt1.Options"))));
            this.ejGantt1.Size = new System.Drawing.Size(1073, 542);
            this.ejGantt1.TabIndex = 0;
            this.ejGantt1.Text = "ejGantt1";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.InputType.Type = Wisej.Web.TextBoxType.Date;
            this.textBox1.Label.Size = 50;
            this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox1.LabelText = "Schedule Start Date";
            this.textBox1.Location = new System.Drawing.Point(28, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 60);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "2017-02-23";
            this.textBox1.Watermark = "Select date...";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 30);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Progress Status";
            // 
            // textBox2
            // 
            this.textBox2.AutoSize = false;
            this.textBox2.InputType.Type = Wisej.Web.TextBoxType.Date;
            this.textBox2.Label.Size = 50;
            this.textBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox2.LabelText = "Schedule End Date";
            this.textBox2.Location = new System.Drawing.Point(28, 309);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 60);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "2017-03-20";
            this.textBox2.Watermark = "Select date...";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(28, 80);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 30);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Gantt Chart Editing";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Location = new System.Drawing.Point(28, 124);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(195, 30);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Enable Collapse All";
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox7.AutoSize = false;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox7.Location = new System.Drawing.Point(28, 168);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(195, 53);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Highlight Non-Working Time";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.Items.AddRange(new object[] {
            "ProjectView",
            "ResourceView",
            "HistogramView"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "View Type";
            this.comboBox1.Location = new System.Drawing.Point(28, 383);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 60);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "ProjectView";
            // 
            // ejGantt
            // 
            this.Name = "ejGantt";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejGantt ejGantt1;
		private TextBox textBox1;
		private CheckBox checkBox1;
		private TextBox textBox2;
		private ComboBox comboBox1;
		private CheckBox checkBox7;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
	}
}
