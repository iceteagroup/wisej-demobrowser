namespace Wisej.DemoBrowser.PropertyGrid
{
    partial class Features
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
            this.propertyGrid1 = new Wisej.Web.PropertyGrid();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.txtDemo = new Wisej.Web.TextBox();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.button1 = new Wisej.Web.Button();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.radioButton1 = new Wisej.Web.RadioButton();
            this.monthCalendar1 = new Wisej.Web.MonthCalendar();
            this.timeUpDown1 = new Wisej.Web.TimeUpDown();
            this.dateTimePicker1 = new Wisej.Web.DateTimePicker();
            this.label1 = new Wisej.Web.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = Wisej.Web.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 18);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.txtDemo;
            this.propertyGrid1.Size = new System.Drawing.Size(287, 443);
            this.propertyGrid1.TabIndex = 0;
            // 
            // 
            // 
            this.propertyGrid1.ToolBar.Enabled = true;
            this.propertyGrid1.SelectedObjectsChanged += new System.EventHandler(this.propertyGrid1_SelectedObjectsChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.propertyGrid1);
            this.groupBox1.Dock = Wisej.Web.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(1124, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 464);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "Default ";
            // 
            // txtDemo
            // 
            this.txtDemo.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtDemo.Location = new System.Drawing.Point(422, 97);
            this.txtDemo.Name = "txtDemo";
            this.txtDemo.Size = new System.Drawing.Size(293, 22);
            this.txtDemo.TabIndex = 3;
            this.txtDemo.Text = "PropertyGrid Demo";
            this.txtDemo.Watermark = "Type here";
            this.txtDemo.Enter += new System.EventHandler(this.txtDemo_Enter);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = Wisej.Web.AnchorStyles.None;
            this.numericUpDown1.Location = new System.Drawing.Point(422, 141);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(293, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Enter += new System.EventHandler(this.numericUpDown1_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(422, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Button";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkBox1.Location = new System.Drawing.Point(422, 227);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 22);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "CheckBox";
            this.checkBox1.Enter += new System.EventHandler(this.checkBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = Wisej.Web.AnchorStyles.None;
            this.radioButton1.Location = new System.Drawing.Point(611, 226);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 22);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "RadioButton";
            this.radioButton1.Enter += new System.EventHandler(this.radioButton1_Enter);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.monthCalendar1.AutoSize = true;
            this.monthCalendar1.Location = new System.Drawing.Point(741, 101);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(260, 234);
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.Enter += new System.EventHandler(this.monthCalendar1_Enter);
            // 
            // timeUpDown1
            // 
            this.timeUpDown1.Anchor = Wisej.Web.AnchorStyles.None;
            this.timeUpDown1.Location = new System.Drawing.Point(422, 269);
            this.timeUpDown1.Name = "timeUpDown1";
            this.timeUpDown1.Size = new System.Drawing.Size(293, 22);
            this.timeUpDown1.TabIndex = 9;
            this.timeUpDown1.Value = System.TimeSpan.Parse("13:58:00");
            this.timeUpDown1.Enter += new System.EventHandler(this.timeUpDown1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 313);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 22);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 18, 13, 58, 57, 679);
            this.dateTimePicker1.Enter += new System.EventHandler(this.dateTimePicker1_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = Wisej.Web.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Label";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.timeUpDown1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtDemo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(5);
            this.Load += new System.EventHandler(this.Features_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.PropertyGrid propertyGrid1;
        private Web.GroupBox groupBox1;
        private Web.TextBox txtDemo;
        private Web.NumericUpDown numericUpDown1;
        private Web.Button button1;
        private Web.CheckBox checkBox1;
        private Web.RadioButton radioButton1;
        private Web.MonthCalendar monthCalendar1;
        private Web.TimeUpDown timeUpDown1;
        private Web.DateTimePicker dateTimePicker1;
        private Web.Label label1;
    }
}
