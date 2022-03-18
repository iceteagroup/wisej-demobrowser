namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejRecurrenceEditor
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
            this.ejRecurrenceEditor1 = new Wisej.Web.Ext.Syncfusion.ejRecurrenceEditor();
            this.buttonGenerateRule = new Wisej.Web.Button();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.dateTimePicker1 = new Wisej.Web.DateTimePicker();
            this.dateTimePicker2 = new Wisej.Web.DateTimePicker();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.buttonGenerateRule);
            this.groupBox1.Size = new System.Drawing.Size(250, 552);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonGenerateRule, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 463);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(520, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/schedule/RecurrenceEditor";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejrecurrenceeditor";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejRecurrenceEditor1);
            this.panel.TabIndex = 7;
            // 
            // ejRecurrenceEditor1
            // 
            this.ejRecurrenceEditor1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.ejRecurrenceEditor1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejRecurrenceEditor1.Location = new System.Drawing.Point(8, 8);
            this.ejRecurrenceEditor1.Name = "ejRecurrenceEditor1";
            this.ejRecurrenceEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"selectedRecurrenceType\":1,\"isResponsive\":true}")));
            this.ejRecurrenceEditor1.Size = new System.Drawing.Size(1073, 542);
            this.ejRecurrenceEditor1.TabIndex = 0;
            this.ejRecurrenceEditor1.Text = "ejRecurrenceEditor1";
            // 
            // buttonGenerateRule
            // 
            this.buttonGenerateRule.Location = new System.Drawing.Point(28, 397);
            this.buttonGenerateRule.Name = "buttonGenerateRule";
            this.buttonGenerateRule.Size = new System.Drawing.Size(195, 30);
            this.buttonGenerateRule.TabIndex = 4;
            this.buttonGenerateRule.Text = "Generate Rule";
            this.buttonGenerateRule.Click += new System.EventHandler(this.buttonGenerateRule_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable Spinners";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AutoSize = false;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Label.Size = 50;
            this.dateTimePicker1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.dateTimePicker1.LabelText = "Max Date";
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 60);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 18, 15, 25, 37, 9);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AutoSize = false;
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.Label.Size = 50;
            this.dateTimePicker2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.dateTimePicker2.LabelText = "MinDate";
            this.dateTimePicker2.Location = new System.Drawing.Point(28, 205);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(195, 60);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2020, 5, 18, 15, 25, 38, 739);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = false;
            this.numericUpDown1.Label.Size = 50;
            this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown1.LabelText = "Selected Recurrence Type";
            this.numericUpDown1.Location = new System.Drawing.Point(28, 301);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ejRecurrenceEditor
            // 
            this.Name = "ejRecurrenceEditor";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejRecurrenceEditor ejRecurrenceEditor1;
		private Button buttonGenerateRule;
		private CheckBox checkBox1;
		private NumericUpDown numericUpDown1;
		private DateTimePicker dateTimePicker2;
		private DateTimePicker dateTimePicker1;
	}
}
