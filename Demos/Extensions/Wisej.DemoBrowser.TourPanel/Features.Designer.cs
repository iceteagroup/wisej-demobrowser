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
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Anchor = Wisej.Web.AnchorStyles.None;
            this.button.Location = new System.Drawing.Point(483, 123);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(218, 37);
            this.button.TabIndex = 0;
            this.button.Text = "Button";
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStartTour
            // 
            this.buttonStartTour.Anchor = Wisej.Web.AnchorStyles.None;
            this.buttonStartTour.Location = new System.Drawing.Point(139, 214);
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
            this.textBox1.Location = new System.Drawing.Point(483, 299);
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
            this.comboBox1.Location = new System.Drawing.Point(483, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 53);
            this.comboBox1.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.monthCalendar1.AutoSize = true;
            this.monthCalendar1.Location = new System.Drawing.Point(878, 75);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(299, 325);
            this.monthCalendar1.TabIndex = 4;
            // 
            // Features
            // 
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonStartTour);
            this.Controls.Add(this.button);
            this.Name = "Features";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.Button button;
        private Web.Button buttonStartTour;
        private Web.TextBox textBox1;
        private Web.ComboBox comboBox1;
        private Web.MonthCalendar monthCalendar1;
    }
}
