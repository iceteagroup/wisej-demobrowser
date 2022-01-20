using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Wisej.DemoBrowser.DataGridView.Views.Data
{
    public class SampleData 
    {
        private DateTime _orderDate;
        private string _clientID;
        private string _product;
        private int _quantity;
        private double _unitPrice;
        private double _totalPrice;

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
                    throw(new Exception("Date can't be null"));
                }
            }
        }
        public SampleData()
        {

        }

        public string ClientID
        {
            get => this._clientID;
            set => this._clientID = value;
        }

        public string Product
        {
            get => this._product;
            set => this._product = value;
        }

        public double UnitPrice
        {
            get => Math.Round(this._unitPrice,2);
            set => this._unitPrice = value;
        }

        public int Quantity
        {
            get => this._quantity;
            set => this._quantity = value;
        }

        public double TotalPrice
        {
            get
            {
                if (this._totalPrice == 0)
                {
                    return Math.Round(Quantity * UnitPrice,2);
                }
                else
                {
                    return Math.Round(this._totalPrice);
                }
            }
            set => this._totalPrice = Quantity*UnitPrice;
        }
    }
}