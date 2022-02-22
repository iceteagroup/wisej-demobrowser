namespace Wisej.DemoBrowser.FullCalendar
{
    partial class Appearances
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
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.fullCalendar1 = new Wisej.Web.Ext.FullCalendar.FullCalendar();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBox1.LabelText = "View Mode";
			this.comboBox1.Location = new System.Drawing.Point(71, 211);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(325, 53);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// fullCalendar1
			// 
			this.fullCalendar1.Anchor = Wisej.Web.AnchorStyles.None;
			this.fullCalendar1.Location = new System.Drawing.Point(491, 36);
			this.fullCalendar1.Name = "fullCalendar1";
			this.fullCalendar1.Size = new System.Drawing.Size(654, 403);
			this.fullCalendar1.TabIndex = 1;
			this.fullCalendar1.Text = "fullCalendar1";
			// 
			// Appearances
			// 
			this.Controls.Add(this.fullCalendar1);
			this.Controls.Add(this.comboBox1);
			this.Name = "Appearances";
			this.Load += new System.EventHandler(this.Appearances_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Web.ComboBox comboBox1;
        private Web.Ext.FullCalendar.FullCalendar fullCalendar1;
    }
}
