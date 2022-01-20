
namespace Wisej.DemoBrowser.ComboBox.Components
{
    partial class InvoicePreview
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
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.label1 = new Wisej.Web.Label();
            this.panel2 = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.lblTotal = new Wisej.Web.Label();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.lblInvoiceID = new Wisej.Web.Label();
            this.lblClientID = new Wisej.Web.Label();
            this.panel4 = new Wisej.Web.Panel();
            this.lblPaymentMethod = new Wisej.Web.Label();
            this.panelCardInfo = new Wisej.Web.Panel();
            this.label3 = new Wisej.Web.Label();
            this.lblHolder = new Wisej.Web.Label();
            this.lblNumber = new Wisej.Web.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelCardInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.panel1.Controls.Add(this.lblClientID);
            this.panel1.Controls.Add(this.lblInvoiceID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1027, 100);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = Wisej.Web.DockStyle.Left;
            this.pictureBox1.ImageSource = "Images\\wisejlogo.png";
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 78);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(253, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.panel2.Controls.Add(this.panelCardInfo);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = Wisej.Web.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 100);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 425);
            this.panel3.TabIndex = 2;
            this.panel3.TabStop = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = Wisej.Web.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("default", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(942, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 98);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1027, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Location = new System.Drawing.Point(857, 13);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(48, 18);
            this.lblInvoiceID.TabIndex = 2;
            this.lblInvoiceID.Text = "Invoice: ";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(857, 37);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(56, 18);
            this.lblClientID.TabIndex = 3;
            this.lblClientID.Text = "Client ID: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPaymentMethod);
            this.panel4.Dock = Wisej.Web.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 98);
            this.panel4.TabIndex = 3;
            this.panel4.TabStop = true;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(10, 47);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(106, 18);
            this.lblPaymentMethod.TabIndex = 0;
            this.lblPaymentMethod.Text = "Payment Method: ";
            // 
            // panelCardInfo
            // 
            this.panelCardInfo.Controls.Add(this.lblNumber);
            this.panelCardInfo.Controls.Add(this.lblHolder);
            this.panelCardInfo.Controls.Add(this.label3);
            this.panelCardInfo.Dock = Wisej.Web.DockStyle.Left;
            this.panelCardInfo.Location = new System.Drawing.Point(276, 0);
            this.panelCardInfo.Name = "panelCardInfo";
            this.panelCardInfo.Size = new System.Drawing.Size(276, 98);
            this.panelCardInfo.TabIndex = 4;
            this.panelCardInfo.TabStop = true;
            this.panelCardInfo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Card Info";
            // 
            // lblHolder
            // 
            this.lblHolder.AutoSize = true;
            this.lblHolder.Location = new System.Drawing.Point(15, 38);
            this.lblHolder.Name = "lblHolder";
            this.lblHolder.Size = new System.Drawing.Size(77, 18);
            this.lblHolder.TabIndex = 1;
            this.lblHolder.Text = "Card Holder: ";
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = Wisej.Web.AnchorStyles.Left;
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(15, 62);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(85, 18);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Card Number:  ";
            // 
            // InvoicePreview
            // 
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InvoicePreview";
            this.Size = new System.Drawing.Size(1027, 625);
            this.Load += new System.EventHandler(this.InvoicePreview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelCardInfo.ResumeLayout(false);
            this.panelCardInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Panel panel1;
        private Web.PictureBox pictureBox1;
        private Web.Label label1;
        private Web.Panel panel2;
        private Web.Label lblTotal;
        private Web.Panel panel3;
        private Web.DataGridView dataGridView1;
        private Web.Label lblClientID;
        private Web.Label lblInvoiceID;
        private Web.Panel panelCardInfo;
        private Web.Label lblNumber;
        private Web.Label lblHolder;
        private Web.Label label3;
        private Web.Panel panel4;
        private Web.Label lblPaymentMethod;
    }
}
