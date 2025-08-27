
namespace Wisej.DemoBrowser.SalesDashboard.Components.Items.ProgressView
{
    partial class ProgressView
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
            this.justGage1 = new Wisej.Web.Ext.JustGage.JustGage();
            this.justGage2 = new Wisej.Web.Ext.JustGage.JustGage();
            this.justGage3 = new Wisej.Web.Ext.JustGage.JustGage();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 300);
            this.button1.Size = new System.Drawing.Size(723, 38);
            // 
            // justGage1
            // 
            this.justGage1.Dock = Wisej.Web.DockStyle.Right;
            this.justGage1.Donut = true;
            this.justGage1.FormatNumber = true;
            this.justGage1.HumanFriendly = true;
            this.justGage1.Location = new System.Drawing.Point(526, 10);
            this.justGage1.Maximum = 1000000F;
            this.justGage1.Name = "justGage1";
            this.justGage1.Size = new System.Drawing.Size(207, 290);
            this.justGage1.TabIndex = 0;
            this.justGage1.Text = "Sales Target";
            this.justGage1.Value = 855223F;
            // 
            // justGage2
            // 
            this.justGage2.Dock = Wisej.Web.DockStyle.Fill;
            this.justGage2.Donut = true;
            this.justGage2.FormatNumber = true;
            this.justGage2.HumanFriendly = true;
            this.justGage2.Location = new System.Drawing.Point(209, 10);
            this.justGage2.Maximum = 10000F;
            this.justGage2.Name = "justGage2";
            this.justGage2.Size = new System.Drawing.Size(317, 290);
            this.justGage2.TabIndex = 1;
            this.justGage2.Text = "Visitors Daily Target";
            this.justGage2.Value = 6733F;
            // 
            // justGage3
            // 
            this.justGage3.Dock = Wisej.Web.DockStyle.Left;
            this.justGage3.Donut = true;
            this.justGage3.HumanFriendly = true;
            this.justGage3.Location = new System.Drawing.Point(10, 10);
            this.justGage3.Maximum = 1000F;
            this.justGage3.Name = "justGage3";
            this.justGage3.Size = new System.Drawing.Size(199, 290);
            this.justGage3.TabIndex = 2;
            this.justGage3.Text = "New Daily Users Target";
            this.justGage3.Value = 150F;
            // 
            // ProgressView
            // 
            this.Controls.Add(this.justGage2);
            this.Controls.Add(this.justGage3);
            this.Controls.Add(this.justGage1);
            this.Name = "ProgressView";
            this.Padding = new Wisej.Web.Padding(10);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.justGage1, 0);
            this.Controls.SetChildIndex(this.justGage3, 0);
            this.Controls.SetChildIndex(this.justGage2, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Web.Ext.JustGage.JustGage justGage1;
        private Web.Ext.JustGage.JustGage justGage2;
        private Web.Ext.JustGage.JustGage justGage3;
    }
}
