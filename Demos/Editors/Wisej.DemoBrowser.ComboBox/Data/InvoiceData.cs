using System;
using System.Collections.Generic;

namespace Wisej.DemoBrowser.ComboBox.Data
{
	public class InvoiceData
    {
        
        public static List<InvoiceData> InvoiceList()
        {
            var invoices = new List<InvoiceData>();
            //First invoice
            var products = new List<InvoiceProducts>();
            products.Add(new InvoiceProducts()
            {
                ProductName = "Intek X7 11700K",
                Quantity = 12,
                UnitPrice = 399.99
            });

            products.Add(new InvoiceProducts()
            {
                ProductName = "8GB 3200MHz RAM STICK",
                Quantity = 28,
                UnitPrice = 40.99
            });

            products.Add(new InvoiceProducts()
            {
                ProductName = "X399 Watercooler",
                Quantity = 10,
                UnitPrice = 400.95
            });

            products.Add(new InvoiceProducts()
            {
                ProductName = "DVD-Drive",
                Quantity = 100,
                UnitPrice = 20.00
            });

            invoices.Add(new InvoiceData
            {
                InvoiceID = "INV00034",
                ClientID = "CL0221",
                InvoiceProducts = products
            });

            //second invoice
            var products2 = new List<InvoiceProducts>();
            products2.Add(new InvoiceProducts()
            {
                ProductName = "XYZ Phantom X8",
                Quantity = 24,
                UnitPrice = 199.85
            });

            products2.Add(new InvoiceProducts()
            {
                ProductName = "Floppy Disks",
                Quantity = 100,
                UnitPrice = 2.99
            });

            products2.Add(new InvoiceProducts()
            {
                ProductName = "A very rare GPU",
                Quantity = 1,
                UnitPrice = 1500.95
            });

            products2.Add(new InvoiceProducts()
            {
                ProductName = "Floppy Drive",
                Quantity = 100,
                UnitPrice = 20.00
            });
            invoices.Add(new InvoiceData()
            {
                InvoiceID = "INV00034",
                ClientID = "CL00234",
                InvoiceProducts = products2
            });

            return invoices;
        }
        public DateTime OrderDate
        {
            get => this._orderDate;
            set
            {
                try
                {
                    this._orderDate = value;
                }
                catch
                {
                    throw (new Exception("Date can't be null"));
                }
            }
        }

        public string ClientID
        {
            get => this._clientID;
            set => this._clientID = value;
        }

        public List<InvoiceProducts> InvoiceProducts
        {
            get => this._invoiceProducts;
            set => this._invoiceProducts = value;
        }
        public double TotalPrice
        {
            get
            {
                double total = 0;
                foreach(var product in InvoiceProducts)
                {
                    total += product.TotalPrice;
                }
                return total;
            }
        }

        public string InvoiceID
        {
            get => this._invoiceID;
            set => this._invoiceID = value;
        }
        private DateTime _orderDate;
        private string _clientID;
        private List<InvoiceProducts> _invoiceProducts;
        private string _invoiceID;
    }

   

    public class InvoiceProducts
    {
        public int Quantity
        {
            get => this._quantity;
            set => this._quantity = value;
        }

        
        public string ProductName
        {
            get => this._productName;
            set => this._productName = value;
        }

        public double UnitPrice
        {
            get => Math.Round(this._unitPrice, 2);
            set => this._unitPrice = value;
        }
        public double TotalPrice
        {
            get
            {
                if (this._totalPrice == 0)
                {
                    return Math.Round(Quantity * UnitPrice, 2);
                }
                else
                {
                    return Math.Round(this._totalPrice);
                }
            }
            set => this._totalPrice = Quantity * UnitPrice;
        }

        private int _quantity;
        private string _productName;
        private double _unitPrice;
        private double _totalPrice;
    }
}