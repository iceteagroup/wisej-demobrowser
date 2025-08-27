
namespace Wisej.DemoBrowser.DataGridView.Views
{
    partial class DGVSimpleBinding
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
			this.tabPage1 = new Wisej.Web.TabPage();
			this.dataGridView1 = new Wisej.Web.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.labelTitle.Size = new System.Drawing.Size(200, 34);
			this.labelTitle.Text = "Simple Binding";
			// 
			// picBoxControl
			// 
			this.pictureBoxControl.ImageSource = "resource.wx/Wisej.Ext.VisualStudioIcons/MemoryArray.svg";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridView1);
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(1, 0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(497, 815);
			this.tabPage1.Text = "Coming Soon";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1234, 669);
			this.dataGridView1.TabIndex = 0;
			// 
			// SimpleBinding
			// 
			this.Name = "SimpleBinding";
			this.Load += new System.EventHandler(this.SimpleBinding_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Web.DataGridView dataGridView1;
        private Web.TabPage tabPage1;
    }
}
