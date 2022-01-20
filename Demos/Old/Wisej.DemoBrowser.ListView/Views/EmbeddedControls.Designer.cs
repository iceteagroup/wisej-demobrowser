
namespace Wisej.DemoBrowser.ListView.Views
{
    partial class EmbeddedControls
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
            this.components = new System.ComponentModel.Container();
            Wisej.Web.ListViewItem listViewItem41 = new Wisej.Web.ListViewItem("Item1");
            Wisej.Web.ListViewItem listViewItem42 = new Wisej.Web.ListViewItem("Item2");
            Wisej.Web.ListViewItem listViewItem43 = new Wisej.Web.ListViewItem("Item3");
            Wisej.Web.ListViewItem listViewItem44 = new Wisej.Web.ListViewItem("Item4");
            Wisej.Web.ListViewItem listViewItem45 = new Wisej.Web.ListViewItem("Item5");
            Wisej.Web.ListViewItem listViewItem46 = new Wisej.Web.ListViewItem("Item6");
            Wisej.Web.ListViewItem listViewItem47 = new Wisej.Web.ListViewItem("Item7");
            Wisej.Web.ListViewItem listViewItem48 = new Wisej.Web.ListViewItem("Item8");
            this.tabPage3 = new Wisej.Web.TabPage();
            this.groupBox3 = new Wisej.Web.GroupBox();
            this.listView1 = new Wisej.Web.ListView();
            this.columnHeader1 = new Wisej.Web.ColumnHeader();
            this.columnHeader2 = new Wisej.Web.ColumnHeader();
            this.columnHeader3 = new Wisej.Web.ColumnHeader();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.timer1 = new Wisej.Web.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.labelTitle.Size = new System.Drawing.Size(261, 40);
            this.labelTitle.Text = "Embedded Controls";
            // 
            // picBoxControl
            // 
            this.pictureBoxControl.ImageSource = "resource.wx/Wisej.Ext.VisualStudioIcons/ItemListView.svg";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.Text = "Coming Soon";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Dock = Wisej.Web.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new Wisej.Web.Padding(10);
            this.groupBox3.Size = new System.Drawing.Size(1458, 663);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.Text = "Embedded Controls in ListView";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = Wisej.Web.DockStyle.Fill;
            this.listView1.Items.AddRange(new Wisej.Web.ListViewItem[] {
            listViewItem41,
            listViewItem42,
            listViewItem43,
            listViewItem44,
            listViewItem45,
            listViewItem46,
            listViewItem47,
            listViewItem48});
            this.listView1.Location = new System.Drawing.Point(10, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1438, 595);
            this.listView1.TabIndex = 4;
            this.listView1.View = Wisej.Web.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Image = null;
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "columnHeader1";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Image = null;
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "columnHeader2";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Image = null;
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "columnHeader3";
            this.columnHeader3.Width = 119;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = Wisej.Web.DockStyle.Bottom;
            this.comboBox1.Location = new System.Drawing.Point(10, 623);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1438, 30);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Watermark = "Select the View";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EmbeddedControls
            // 
            this.Name = "EmbeddedControls";
            this.Load += new System.EventHandler(this.EmbeddedControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.TabPage tabPage3;
        private Web.GroupBox groupBox3;
        private Web.ListView listView1;
        private Web.ColumnHeader columnHeader1;
        private Web.ColumnHeader columnHeader2;
        private Web.ColumnHeader columnHeader3;
        private Web.ComboBox comboBox1;
        private Web.Timer timer1;
    }
}
