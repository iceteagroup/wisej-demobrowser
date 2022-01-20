
namespace Wisej.DemoBrowser.ComboBox
{
    partial class DataBinding
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
			this.tabPage4 = new Wisej.Web.TabPage();
			this.tabPage3 = new Wisej.Web.TabPage();
			this.panel5 = new Wisej.Web.Panel();
			this.btnPay = new Wisej.Web.Button();
			this.panelSavedCards = new Wisej.Web.Panel();
			this.cmbSavedCards = new Wisej.Web.ComboBox();
			this.cmbPaymentMethod = new Wisej.Web.ComboBox();
			this.cmbInvoice = new Wisej.Web.ComboBox();
			this.panelPreview = new Wisej.Web.Panel();
			this.panel5.SuspendLayout();
			this.panelSavedCards.SuspendLayout();
			this.SuspendLayout();

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
			// panel5
			// 
			this.panel5.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel5.Controls.Add(this.btnPay);
			this.panel5.Controls.Add(this.panelSavedCards);
			this.panel5.Controls.Add(this.cmbPaymentMethod);
			this.panel5.Controls.Add(this.cmbInvoice);
			this.panel5.Location = new System.Drawing.Point(7, 19);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(372, 625);
			this.panel5.TabIndex = 0;
			this.panel5.TabStop = true;
			// 
			// btnPay
			// 
			this.btnPay.BackColor = System.Drawing.Color.FromArgb(25, 61, 148);
			this.btnPay.ForeColor = System.Drawing.Color.White;
			this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPay.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/credit-card.svg";
			this.btnPay.Location = new System.Drawing.Point(212, 582);
			this.btnPay.Name = "btnPay";
			this.btnPay.Size = new System.Drawing.Size(152, 38);
			this.btnPay.TabIndex = 3;
			this.btnPay.Text = "Pay";
			this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
			// 
			// panelSavedCards
			// 
			this.panelSavedCards.Controls.Add(this.cmbSavedCards);
			this.panelSavedCards.Location = new System.Drawing.Point(3, 200);
			this.panelSavedCards.Name = "panelSavedCards";
			this.panelSavedCards.Size = new System.Drawing.Size(364, 70);
			this.panelSavedCards.TabIndex = 2;
			this.panelSavedCards.TabStop = true;
			this.panelSavedCards.Visible = false;
			// 
			// cmbSavedCards
			// 
			this.cmbSavedCards.LabelText = "Saved Card";
			this.cmbSavedCards.Location = new System.Drawing.Point(3, 10);
			this.cmbSavedCards.Name = "cmbSavedCards";
			this.cmbSavedCards.Size = new System.Drawing.Size(358, 42);
			this.cmbSavedCards.TabIndex = 0;
			this.cmbSavedCards.Watermark = "Select a saved card";
			// 
			// cmbPaymentMethod
			// 
			this.cmbPaymentMethod.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.cmbPaymentMethod.LabelText = "Payment Method";
			this.cmbPaymentMethod.Location = new System.Drawing.Point(3, 124);
			this.cmbPaymentMethod.Name = "cmbPaymentMethod";
			this.cmbPaymentMethod.Size = new System.Drawing.Size(364, 42);
			this.cmbPaymentMethod.TabIndex = 1;
			this.cmbPaymentMethod.Watermark = "Select a payment method";
			this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
			// 
			// cmbInvoice
			// 
			this.cmbInvoice.LabelText = "Invoice";
			this.cmbInvoice.Location = new System.Drawing.Point(3, 46);
			this.cmbInvoice.Name = "cmbInvoice";
			this.cmbInvoice.Size = new System.Drawing.Size(364, 42);
			this.cmbInvoice.TabIndex = 0;
			this.cmbInvoice.Watermark = "Select an invoice....";
			// 
			// panelPreview
			// 
			this.panelPreview.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panelPreview.Location = new System.Drawing.Point(406, 19);
			this.panelPreview.Name = "panelPreview";
			this.panelPreview.Size = new System.Drawing.Size(1027, 625);
			this.panelPreview.TabIndex = 1;
			this.panelPreview.TabStop = true;
			// 
			// ComboBoxDataBinding
			// 
			this.Name = "ComboBoxDataBinding";
			this.Load += new System.EventHandler(this.DataBinding_Load);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panelSavedCards.ResumeLayout(false);
			this.panelSavedCards.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private Web.TabPage tabPage3;
        private Web.Panel panelPreview;
        private Web.Panel panel5;
        private Web.Panel panelSavedCards;
        private Web.ComboBox cmbSavedCards;
        private Web.ComboBox cmbPaymentMethod;
        private Web.ComboBox cmbInvoice;
        private Web.TabPage tabPage4;
        private Web.Button btnPay;
    }
}
