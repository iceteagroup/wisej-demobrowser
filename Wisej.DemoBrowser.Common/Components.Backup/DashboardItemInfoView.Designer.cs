
namespace Wisej.DemoBrowser.Common.Components
{
    partial class DashboardItemInfoView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new Wisej.Web.Panel();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.tabControl1 = new Wisej.Web.TabControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 134);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 134);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new Wisej.Web.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1500, 716);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = Wisej.Web.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(753, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageInsets = new Wisej.Web.Padding(1, 0, 1, 1);
            this.tabControl1.Size = new System.Drawing.Size(734, 690);
            this.tabControl1.TabIndex = 0;
            // 
            // DashboardItemInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardItemInfoView";
            this.Size = new System.Drawing.Size(1500, 850);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Web.Panel panel1;
        public Web.TabControl tabControl1;
        public Web.TableLayoutPanel tableLayoutPanel1;
    }
}
