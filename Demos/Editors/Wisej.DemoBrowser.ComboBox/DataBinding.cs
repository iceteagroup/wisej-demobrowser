using System;
using System.Collections.Generic;
using System.ComponentModel;
using Wisej.DemoBrowser.ComboBox.Components;
using Wisej.DemoBrowser.ComboBox.Data;
using Wisej.DemoBrowser.Common;

namespace Wisej.DemoBrowser.ComboBox
{
	public partial class DataBinding : Common.DemoView
	{
		public DataBinding()
		{
			InitializeComponent();
		}

		private List<string> paymentMethods = new List<string>
		{
			"Cheque",
			"Credit/Debit Card",
			"Bank Wire"
		};

		private void DataBinding_Load(object sender, EventArgs e)
		{
			this.cmbInvoice.DataSource = InvoiceData.InvoiceList();
			this.cmbInvoice.DisplayMember = "InvoiceID";

			this.cmbPaymentMethod.DataSource = paymentMethods;

			this.cmbSavedCards.DataSource = SavedCard.SavedCards();
			this.cmbSavedCards.DisplayMember = "CardHolder";

		}

		private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.cmbPaymentMethod.SelectedIndex == 1)
			{
				this.panelSavedCards.Visible = true;
			}
			else
			{
				this.panelSavedCards.Visible = false;
			}
		}

        private void btnPay_Click(object sender, EventArgs e)
        {
			panelPreview.Controls.Clear();
			panelPreview.Controls.Add(new InvoicePreview((InvoiceData)this.cmbInvoice.SelectedItem, (SavedCard)this.cmbSavedCards.SelectedItem, (string)this.cmbPaymentMethod.SelectedItem));
		}
    }
}
