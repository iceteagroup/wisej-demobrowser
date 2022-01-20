namespace Wisej.DemoBrowser.TableLayoutPanel
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
            this.panel1 = new Wisej.Web.Panel();
            this.btnRemoveLastColumn = new Wisej.Web.Button();
            this.btnRemoveLastRow = new Wisej.Web.Button();
            this.btnAddColumn = new Wisej.Web.Button();
            this.btnAddRow = new Wisej.Web.Button();
            this.panel2 = new Wisej.Web.Panel();
            this.tableLayoutPanel = new Wisej.Web.TableLayoutPanel();
            this.pictureBox4 = new Wisej.Web.PictureBox();
            this.pictureBox2 = new Wisej.Web.PictureBox();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.pictureBox3 = new Wisej.Web.PictureBox();
            this.label1 = new Wisej.Web.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRemoveLastColumn);
            this.panel1.Controls.Add(this.btnRemoveLastRow);
            this.panel1.Controls.Add(this.btnAddColumn);
            this.panel1.Controls.Add(this.btnAddRow);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new Wisej.Web.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1422, 41);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // btnRemoveLastColumn
            // 
            this.btnRemoveLastColumn.AutoSize = true;
            this.btnRemoveLastColumn.Dock = Wisej.Web.DockStyle.Left;
            this.btnRemoveLastColumn.Location = new System.Drawing.Point(355, 5);
            this.btnRemoveLastColumn.Margin = new Wisej.Web.Padding(5);
            this.btnRemoveLastColumn.Name = "btnRemoveLastColumn";
            this.btnRemoveLastColumn.Padding = new Wisej.Web.Padding(3);
            this.btnRemoveLastColumn.Size = new System.Drawing.Size(176, 31);
            this.btnRemoveLastColumn.TabIndex = 3;
            this.btnRemoveLastColumn.Text = "Remove Last Column";
            this.btnRemoveLastColumn.Click += new System.EventHandler(this.btnRemoveLastColumn_Click);
            // 
            // btnRemoveLastRow
            // 
            this.btnRemoveLastRow.AutoSize = true;
            this.btnRemoveLastRow.Dock = Wisej.Web.DockStyle.Left;
            this.btnRemoveLastRow.Location = new System.Drawing.Point(202, 5);
            this.btnRemoveLastRow.Margin = new Wisej.Web.Padding(5);
            this.btnRemoveLastRow.Name = "btnRemoveLastRow";
            this.btnRemoveLastRow.Padding = new Wisej.Web.Padding(3);
            this.btnRemoveLastRow.Size = new System.Drawing.Size(153, 31);
            this.btnRemoveLastRow.TabIndex = 2;
            this.btnRemoveLastRow.Text = "Remove Last Row";
            this.btnRemoveLastRow.Click += new System.EventHandler(this.btnRemoveLastRow_Click);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.AutoSize = true;
            this.btnAddColumn.Dock = Wisej.Web.DockStyle.Left;
            this.btnAddColumn.Location = new System.Drawing.Point(92, 5);
            this.btnAddColumn.Margin = new Wisej.Web.Padding(5);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Padding = new Wisej.Web.Padding(3);
            this.btnAddColumn.Size = new System.Drawing.Size(110, 31);
            this.btnAddColumn.TabIndex = 1;
            this.btnAddColumn.Text = "Add Column";
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.AutoSize = true;
            this.btnAddRow.Dock = Wisej.Web.DockStyle.Left;
            this.btnAddRow.Location = new System.Drawing.Point(5, 5);
            this.btnAddRow.Margin = new Wisej.Web.Padding(5);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Padding = new Wisej.Web.Padding(3);
            this.btnAddRow.Size = new System.Drawing.Size(87, 31);
            this.btnAddRow.TabIndex = 0;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1422, 433);
            this.panel2.TabIndex = 2;
            this.panel2.TabStop = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.pictureBox4, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1422, 433);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.TabStop = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = Wisej.Web.DockStyle.Fill;
            this.pictureBox4.ImageSource = "resource.wx/Images/splash.png";
            this.pictureBox4.Location = new System.Drawing.Point(3, 219);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(705, 211);
            this.pictureBox4.SizeMode = Wisej.Web.PictureBoxSizeMode.Cover;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = Wisej.Web.DockStyle.Fill;
            this.pictureBox2.ImageSource = "resource.wx/Images/splash.png";
            this.pictureBox2.Location = new System.Drawing.Point(714, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(705, 211);
            this.pictureBox2.SizeMode = Wisej.Web.PictureBoxSizeMode.Cover;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = Wisej.Web.DockStyle.Fill;
            this.pictureBox1.ImageSource = "resource.wx/Images/splash.png";
            this.pictureBox1.Location = new System.Drawing.Point(714, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 210);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Cover;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = Wisej.Web.DockStyle.Fill;
            this.pictureBox3.ImageSource = "resource.wx/Images/splash.png";
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(705, 210);
            this.pictureBox3.SizeMode = Wisej.Web.PictureBoxSizeMode.Cover;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(975, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "WIP; Couldn\'t figure out how to make a feature for this control";
            // 
            // Features
            // 
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Features";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Panel panel1;
        private Web.Panel panel2;
        private Web.Button btnRemoveLastColumn;
        private Web.Button btnRemoveLastRow;
        private Web.Button btnAddColumn;
        private Web.Button btnAddRow;
        private Web.TableLayoutPanel tableLayoutPanel;
        private Web.PictureBox pictureBox1;
        private Web.PictureBox pictureBox4;
        private Web.PictureBox pictureBox2;
        private Web.PictureBox pictureBox3;
        private Web.Label label1;
    }
}
