namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igScheduler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igScheduler));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igScheduler1 = new Wisej.Web.Ext.Ignite.igScheduler();
			this.buttonLoad = new Wisej.Web.Upload();
			this.dateTimePicker1 = new Wisej.Web.DateTimePicker();
			this.groupBox2 = new Wisej.Web.GroupBox();
			this.button1 = new Wisej.Web.Button();
			this.dateTimePicker2 = new Wisej.Web.DateTimePicker();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Size = new System.Drawing.Size(250, 673);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 590);
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igScheduler1);
			this.panel.Size = new System.Drawing.Size(536, 673);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/scheduler/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igScheduler";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igscheduler-overview";
			// 
			// igScheduler1
			// 
			this.igScheduler1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igScheduler1.Location = new System.Drawing.Point(21, 16);
			this.igScheduler1.Name = "igScheduler1";
			this.igScheduler1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igScheduler1.Options"))));
			this.igScheduler1.Size = new System.Drawing.Size(493, 641);
			this.igScheduler1.TabIndex = 0;
			this.igScheduler1.Text = "igScheduler1";
			widgetFunction1.Name = "loadData";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			this.igScheduler1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			this.igScheduler1.Appear += new System.EventHandler(this.igScheduler1_Appear);
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".json";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 522);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 5;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Checked = false;
			this.dateTimePicker1.Label.Text = "From";
			this.dateTimePicker1.Location = new System.Drawing.Point(6, 35);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(183, 41);
			this.dateTimePicker1.TabIndex = 0;
			this.dateTimePicker1.Value = new System.DateTime(2020, 3, 3, 0, 0, 0, 0);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.dateTimePicker2);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Location = new System.Drawing.Point(28, 299);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(195, 197);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.Text = "Export Appts. in Range";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 164);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(183, 27);
			this.button1.TabIndex = 2;
			this.button1.Text = "Export";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Checked = false;
			this.dateTimePicker2.Label.Text = "To";
			this.dateTimePicker2.Location = new System.Drawing.Point(6, 101);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(183, 41);
			this.dateTimePicker2.TabIndex = 1;
			this.dateTimePicker2.Value = new System.DateTime(2020, 3, 10, 16, 0, 25, 25);
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
            "monthView",
            "agendaView"});
			this.comboBox1.Label.Text = "View Mode";
			this.comboBox1.Location = new System.Drawing.Point(28, 165);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 41);
			this.comboBox1.TabIndex = 2;
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 37);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Enable Today Button";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 101);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Appointment Dialog Suppress";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Date Range Interval";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 232);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// igScheduler
			// 
			this.Name = "igScheduler";
			this.Size = new System.Drawing.Size(945, 863);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igScheduler igScheduler1;
		private Upload buttonLoad;
		private GroupBox groupBox2;
		private Button button1;
		private DateTimePicker dateTimePicker2;
		private DateTimePicker dateTimePicker1;
		private ComboBox comboBox1;
		private CheckBox checkBox1;
		private NumericUpDown numericUpDown1;
		private CheckBox checkBox2;
	}
}
