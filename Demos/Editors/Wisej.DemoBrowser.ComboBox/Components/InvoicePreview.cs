using System;
using Wisej.Web;
using Wisej.DemoBrowser.Common;
using Wisej.DemoBrowser.ComboBox.Data;
namespace Wisej.DemoBrowser.ComboBox.Components
{
    public partial class InvoicePreview : Wisej.Web.UserControl
    {
        public InvoicePreview(InvoiceData invoiceData,SavedCard card,string method)
        {
            InitializeComponent();
            this._invoiceData = invoiceData;
            this._card = card;
            this._paymentMethod = method;
        }

        private void InvoicePreview_Load(object sender, EventArgs e)
        {
            this.lblClientID.Text += _invoiceData.ClientID;
            this.lblInvoiceID.Text += _invoiceData.InvoiceID;
            this.dataGridView1.DataSource = _invoiceData.InvoiceProducts;
            this.lblTotal.Text += string.Format(Application.CurrentCulture,"{0:C}", _invoiceData.TotalPrice);

            if (_paymentMethod.Equals("Credit/Debit Card"))
            {
                this.panelCardInfo.Visible = true;
                this.lblHolder.Text += _card.CardHolder;
                this.lblNumber.Text += _card.CardNumber;
            }

            this.lblPaymentMethod.Text += _paymentMethod;

            this.dataGridView1.Columns["UnitPrice"].DefaultCellStyle.Format = "c2";
            this.dataGridView1.Columns["UnitPrice"].DefaultCellStyle.FormatProvider = Application.CurrentCulture;

            this.dataGridView1.Columns["TotalPrice"].DefaultCellStyle.Format = "c2";
            this.dataGridView1.Columns["TotalPrice"].DefaultCellStyle.FormatProvider = Application.CurrentCulture;
        }


        private InvoiceData _invoiceData;
        private SavedCard _card;
        private string _paymentMethod;
    }
}
