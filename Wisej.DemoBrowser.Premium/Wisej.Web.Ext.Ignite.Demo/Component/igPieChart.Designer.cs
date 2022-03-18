namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igPieChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igPieChart));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igPieChart1 = new Wisej.Web.Ext.Ignite.igPieChart();
			this.groupBox2 = new Wisej.Web.GroupBox();
			this.button1 = new Wisej.Web.Button();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.textBox1 = new Wisej.Web.TextBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.comboBox2 = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Size = new System.Drawing.Size(250, 624);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Controls.SetChildIndex(this.groupBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 539);
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igPieChart1);
			this.panel.Size = new System.Drawing.Size(455, 624);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/pie-chart/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igPieChart";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igpiechart";
			// 
			// igPieChart1
			// 
			this.igPieChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igPieChart1.Location = new System.Drawing.Point(18, 18);
			this.igPieChart1.Name = "igPieChart1";
			this.igPieChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igPieChart1.Options"))));
			this.igPieChart1.Size = new System.Drawing.Size(417, 586);
			this.igPieChart1.TabIndex = 0;
			this.igPieChart1.Text = "igPieChart1";
			widgetFunction1.Name = "AddItem";
			widgetFunction1.Source = "this.Instance.addItem({\r\n    Label: \"Test\",\r\n    Budget: 50\r\n});";
			this.igPieChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.numericUpDown1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(28, 337);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(195, 182);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.Text = "Add Item";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 146);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(183, 27);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Budget";
			this.numericUpDown1.Location = new System.Drawing.Point(6, 83);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(183, 41);
			this.numericUpDown1.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Label.Text = "Department";
			this.textBox1.Location = new System.Drawing.Point(6, 22);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(183, 41);
			this.textBox1.TabIndex = 0;
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(27, 96);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Allow Slice Selection";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(27, 38);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Allow Slice Explosion";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.DecimalPlaces = 2;
			this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown2.Label.Text = "Exploded Radius";
			this.numericUpDown2.Location = new System.Drawing.Point(28, 154);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown2.TabIndex = 2;
			this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "single",
            "multiple",
            "manual"});
			this.comboBox1.Label.Text = "Selection Mode";
			this.comboBox1.Location = new System.Drawing.Point(28, 215);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 41);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "single";
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox2.Items.AddRange(new object[] {
            "counterclockwise",
            "clockwise"});
			this.comboBox2.Label.Text = "Sweep Direction";
			this.comboBox2.Location = new System.Drawing.Point(27, 276);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(195, 41);
			this.comboBox2.TabIndex = 4;
			this.comboBox2.Text = "clockwise";
			// 
			// igPieChart
			// 
			this.Name = "igPieChart";
			this.Size = new System.Drawing.Size(864, 814);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igPieChart igPieChart1;
		private GroupBox groupBox2;
		private Button button1;
		private NumericUpDown numericUpDown1;
		private TextBox textBox1;
		private NumericUpDown numericUpDown2;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private ComboBox comboBox2;
		private ComboBox comboBox1;
	}
}
