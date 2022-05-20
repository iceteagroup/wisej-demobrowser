namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejSchedule));
            this.ejSchedule1 = new Wisej.Web.Ext.Syncfusion.ejSchedule();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
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
            this.linkDocs.Text = "https://help.syncfusion.com/js/schedule/overview";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(546, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/schedule/AppointmentCategorize";
            // 
            // linkApi
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "https://help.syncfusion.com/api/js/ejschedule";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejSchedule1);
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
            this.flowLayoutPanelProperties.Controls.Add(this.comboBox2);
            // 
            // ejSchedule1
            // 
            this.ejSchedule1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejSchedule1.Location = new System.Drawing.Point(8, 8);
            this.ejSchedule1.Name = "ejSchedule1";
            this.ejSchedule1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejSchedule1.Options"))));
            this.ejSchedule1.Size = new System.Drawing.Size(872, 560);
            this.ejSchedule1.TabIndex = 0;
            this.ejSchedule1.Text = "ejSchedule1";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanelProperties.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Workweek",
            "Month",
            "Agenda"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "View";
            this.comboBox1.Location = new System.Drawing.Point(3, 284);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Week";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoSize = false;
            this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanelProperties.SetFillWeight(this.comboBox2, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.comboBox2, true);
            this.comboBox2.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.comboBox2.Label.Size = 50;
            this.comboBox2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox2.LabelText = "Orientation";
            this.comboBox2.Location = new System.Drawing.Point(3, 363);
            this.comboBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 60);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "Vertical";
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
            this.checkBox1.Text = "Non-Working Days";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 52);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 30);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Allow Delete";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox3, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox3, true);
            this.checkBox3.Location = new System.Drawing.Point(3, 101);
            this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(212, 46);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Allow Keyboard Navigation";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 166);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 30);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Allow Inline";
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Checked = true;
            this.flowLayoutPanelProperties.SetFillWeight(this.checkBox5, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox5, true);
            this.checkBox5.Location = new System.Drawing.Point(3, 215);
            this.checkBox5.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(212, 50);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Show Appointment Navigator";
            // 
            // ejSchedule
            // 
            this.Name = "ejSchedule";
            this.Load += new System.EventHandler(this.ejSchedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.ejSchedule ejSchedule1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private CheckBox checkBox1;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox5;
	}
}
