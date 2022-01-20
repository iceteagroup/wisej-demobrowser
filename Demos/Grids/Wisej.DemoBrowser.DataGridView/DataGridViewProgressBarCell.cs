using System;
using System.ComponentModel;
using System.Text;
using Wisej.Web;
using Wisej.Base;
namespace Wisej.DemoBrowser.DataGridView
{
    public class DataGridViewProgressBarCell : DataGridViewCell
    {
        public DataGridViewProgressBarCell()
        {
            this.Control = new ProgressBar()
            {
                Dock = DockStyle.Fill,
                Maximum = 100
            };
        }

        public override Type ValueType
        {
            get { return typeof(int); }
            set { }
        }

        public override Type FormattedValueType
        {
            get { return typeof(string); }
        }

        protected override bool SetValue(object value)
        {
            ((ProgressBar)this.Control).Value = (int)value;

            return base.SetValue(value);
        }
    }

}
