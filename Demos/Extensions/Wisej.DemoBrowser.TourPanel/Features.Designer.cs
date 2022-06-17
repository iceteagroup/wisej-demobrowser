namespace Wisej.DemoBrowser.TourPanel
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
            this.button = new Wisej.Web.Button();
            this.buttonStartTour = new Wisej.Web.Button();
            this.textBox1 = new Wisej.Web.TextBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.monthCalendar1 = new Wisej.Web.MonthCalendar();
            this.panel1 = new Wisej.Web.Panel();
            this.label1 = new Wisej.Web.Label();
            this.checkBoxAutoPlay = new Wisej.Web.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Anchor = Wisej.Web.AnchorStyles.None;
            this.button.Location = new System.Drawing.Point(8, 53);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(218, 37);
            this.button.TabIndex = 0;
            this.button.Text = "Button";
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStartTour
            // 
            this.buttonStartTour.Anchor = Wisej.Web.AnchorStyles.None;
            this.buttonStartTour.Location = new System.Drawing.Point(2, 164);
            this.buttonStartTour.Name = "buttonStartTour";
            this.buttonStartTour.Size = new System.Drawing.Size(161, 37);
            this.buttonStartTour.TabIndex = 1;
            this.buttonStartTour.Text = "Start Tour";
            this.buttonStartTour.Click += new System.EventHandler(this.buttonStartTour_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox1.LabelText = "Email";
            this.textBox1.Location = new System.Drawing.Point(8, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 53);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBox1.Items.AddRange(new object[] {
            "New York City",
            "Arlington",
            "Washington DC",
            "Las Vegas",
            "San Francisco"});
            this.comboBox1.LabelText = "City";
            this.comboBox1.Location = new System.Drawing.Point(8, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 53);
            this.comboBox1.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.monthCalendar1.AutoSize = true;
            this.monthCalendar1.Location = new System.Drawing.Point(240, 4);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(299, 327);
            this.monthCalendar1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button);
            this.panel1.Location = new System.Drawing.Point(199, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 336);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = Wisej.Web.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Demo Controls";
            // 
            // checkBoxAutoPlay
            // 
            this.checkBoxAutoPlay.Anchor = Wisej.Web.AnchorStyles.None;
            this.checkBoxAutoPlay.Location = new System.Drawing.Point(2, 207);
            this.checkBoxAutoPlay.Name = "checkBoxAutoPlay";
            this.checkBoxAutoPlay.Size = new System.Drawing.Size(82, 23);
            this.checkBoxAutoPlay.TabIndex = 7;
            this.checkBoxAutoPlay.Text = "AutoPlay";
            // 
            // Features
            // 
            this.Controls.Add(this.checkBoxAutoPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStartTour);
            this.MinimumSize = new System.Drawing.Size(751, 371);
            this.Name = "Features";
            this.Size = new System.Drawing.Size(751, 371);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Button button;
        private Web.Button buttonStartTour;
        private Web.TextBox textBox1;
        private Web.ComboBox comboBox1;
        private Web.MonthCalendar monthCalendar1;
        private Web.Panel panel1;
        private Web.Label label1;
        private Web.CheckBox checkBoxAutoPlay;
    }
}
