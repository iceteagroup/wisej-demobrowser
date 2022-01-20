
namespace Wisej.DemoBrowser.ListView.Views
{
    partial class VirtualScrolling
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
			this.tabPage5 = new Wisej.Web.TabPage();
			this.tabPage4 = new Wisej.Web.TabPage();
			this.tabPage3 = new Wisej.Web.TabPage();
			this.listView1 = new Wisej.Web.ListView();
			this.groupBox3 = new Wisej.Web.GroupBox();
			this.groupBox4 = new Wisej.Web.GroupBox();
			this.comboBox1 = new Wisej.Web.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.labelTitle.Size = new System.Drawing.Size(208, 34);
			this.labelTitle.Text = "Virtual Scrolling";
			// 
			// picBoxControl
			// 
			this.pictureBoxControl.ImageSource = "resource.wx/Wisej.Ext.VisualStudioIcons/Virtual.svg";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(0, 163);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.groupBox3);
			this.panel4.Controls.Add(this.groupBox4);
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(0, 0);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(200, 100);
			this.tabPage5.Text = "Coming Soon";
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(0, 0);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(200, 100);
			this.tabPage4.Text = "Coming Soon";
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(0, 0);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(200, 100);
			this.tabPage3.Text = "Coming Soon";
			// 
			// listView1
			// 
			this.listView1.Dock = Wisej.Web.DockStyle.Fill;
			this.listView1.Location = new System.Drawing.Point(10, 25);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1388, 556);
			this.listView1.TabIndex = 0;
			this.listView1.VirtualMode = true;
			this.listView1.RetrieveVirtualItem += new Wisej.Web.RetrieveVirtualItemEventHandler(this.listView1_RetrieveVirtualItem);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.listView1);
			this.groupBox3.Dock = Wisej.Web.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(0, 60);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new Wisej.Web.Padding(10);
			this.groupBox3.Size = new System.Drawing.Size(1408, 591);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.Text = "VirtualScrolling = true";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.comboBox1);
			this.groupBox4.Dock = Wisej.Web.DockStyle.Top;
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new Wisej.Web.Padding(10);
			this.groupBox4.Size = new System.Drawing.Size(1408, 60);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.Text = "Change View";
			// 
			// comboBox1
			// 
			this.comboBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.comboBox1.Location = new System.Drawing.Point(10, 25);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(1388, 25);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Watermark = "Select a view";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// VirtualScrolling
			// 
			this.Name = "VirtualScrolling";
			this.Load += new System.EventHandler(this.VirtualScrolling_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Web.TabPage tabPage3;
        private Web.ListView listView1;
        private Web.TabPage tabPage4;
        private Web.GroupBox groupBox3;
        private Web.GroupBox groupBox4;
        private Web.ComboBox comboBox1;
        private Web.TabPage tabPage5;
    }
}
