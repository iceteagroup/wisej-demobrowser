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
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction3 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            this.igScheduler1 = new Wisej.Web.Ext.Ignite.igScheduler();
            this.buttonLoad = new Wisej.Web.Upload();
            this.dateTimePicker1 = new Wisej.Web.DateTimePicker();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.button1 = new Wisej.Web.Button();
            this.dateTimePicker2 = new Wisej.Web.DateTimePicker();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igScheduler1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/scheduler/overview";
            // 
            // linkAPI
            // 
            this.linkApi.TabIndex = 5;
            this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igScheduler";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igscheduler-overview";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.buttonLoad);
            // 
            // igScheduler1
            // 
            this.igScheduler1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.igScheduler1.Location = new System.Drawing.Point(21, 16);
            this.igScheduler1.Name = "igScheduler1";
            this.igScheduler1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igScheduler1.Options"))));
            this.igScheduler1.Size = new System.Drawing.Size(1048, 528);
            this.igScheduler1.TabIndex = 0;
            this.igScheduler1.Text = "igScheduler1";
            widgetFunction3.Name = "loadData";
            widgetFunction3.Source = resources.GetString("widgetFunction3.Source");
            this.igScheduler1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction3};
            // 
            // buttonLoad
            // 
            this.buttonLoad.AllowedFileTypes = ".json";
            this.buttonLoad.HideValue = true;
            this.buttonLoad.ImageSource = "icon-file";
            this.buttonLoad.Location = new System.Drawing.Point(3, 309);
            this.buttonLoad.Margin = new Wisej.Web.Padding(3, 7, 3, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(42, 42);
            this.buttonLoad.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dateTimePicker1.LabelText = "From";
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 57);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 1, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel1.SetFillWeight(this.groupBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.groupBox2, true);
            this.groupBox2.Location = new System.Drawing.Point(3, 74);
            this.groupBox2.Margin = new Wisej.Web.Padding(3, 7, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 225);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.Text = "Export Appts. in Range";
            // 
            // button1
            // 
            this.button1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Export";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Format = Wisej.Web.DateTimePickerFormat.Short;
            this.dateTimePicker2.LabelText = "To";
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 57);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "monthView",
            "agendaView"});
            this.comboBox1.LabelText = "View Mode";
            this.comboBox1.Location = new System.Drawing.Point(3, 7);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 7, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 57);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "monthView";
            // 
            // igScheduler
            // 
            this.MinimumSize = new System.Drawing.Size(1009, 669);
            this.Name = "igScheduler";
            this.Load += new System.EventHandler(this.igScheduler_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
	}
}
