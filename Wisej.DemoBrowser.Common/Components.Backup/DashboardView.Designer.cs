
namespace Wisej.DemoBrowser.Common.Components
{
    partial class DashboardView
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
			this.tabControl1 = new Wisej.Web.TabControl();
			this.tabMain = new Wisej.Web.TabPage();
			this.panel1 = new Wisej.Web.Panel();
			this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
			this.tabControl1.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabMain);
			this.tabControl1.Dock = Wisej.Web.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.PageInsets = new Wisej.Web.Padding(1, 35, 1, 1);
			this.tabControl1.Size = new System.Drawing.Size(1500, 850);
			this.tabControl1.SizeMode = Wisej.Web.TabSizeMode.Fill;
			this.tabControl1.TabIndex = 0;
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.panel1);
			this.tabMain.Controls.Add(this.tableLayoutPanel1);
			this.tabMain.Location = new System.Drawing.Point(1, 35);
			this.tabMain.Name = "tabMain";
			this.tabMain.Size = new System.Drawing.Size(1498, 814);
			this.tabMain.Text = "tabPage1";
			// 
			// panel1
			// 
			this.panel1.Dock = Wisej.Web.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 715);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1498, 99);
			this.panel1.TabIndex = 1;
			this.panel1.TabStop = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1498, 814);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.TabStop = true;
			// 
			// DashboardView
			// 
			this.Controls.Add(this.tabControl1);
			this.Name = "DashboardView";
			this.Size = new System.Drawing.Size(1500, 850);
			this.tabControl1.ResumeLayout(false);
			this.tabMain.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        public Web.TabControl tabControl1;
        public Web.TabPage tabMain;
        public Web.Panel panel1;
        public Web.TableLayoutPanel tableLayoutPanel1;
    }
}
