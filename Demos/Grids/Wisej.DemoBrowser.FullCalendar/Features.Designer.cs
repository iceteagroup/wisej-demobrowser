namespace Wisej.DemoBrowser.FullCalendar
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
            this.fullCalendar1 = new Wisej.Web.Ext.FullCalendar.FullCalendar();
            this.SuspendLayout();
            // 
            // fullCalendar1
            // 
            this.fullCalendar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.fullCalendar1.BackColor = System.Drawing.Color.White;
            this.fullCalendar1.EnableNativeContextMenu = true;
            this.fullCalendar1.EventLimit = 2;
            this.fullCalendar1.Location = new System.Drawing.Point(447, 21);
            this.fullCalendar1.Name = "fullCalendar1";
            this.fullCalendar1.Size = new System.Drawing.Size(529, 433);
            this.fullCalendar1.TabIndex = 0;
            this.fullCalendar1.Text = "fullCalendar1";
            this.fullCalendar1.EventClick += new Wisej.Web.Ext.FullCalendar.EventClickEventHandler(this.fullCalendar1_EventClick);
            // 
            // Features
            // 
            this.Controls.Add(this.fullCalendar1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Ext.FullCalendar.FullCalendar fullCalendar1;
    }
}
