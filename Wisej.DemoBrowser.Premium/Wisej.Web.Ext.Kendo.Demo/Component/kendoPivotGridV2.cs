using System;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoPivotGridV2 : TestBase
	{
		public kendoPivotGridV2()
		{
			InitializeComponent();
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.kendoPivotGridV21.Options.columnWidth = this.numericUpDownColumnWidth.Value;

            this.kendoPivotGridV21.Update();
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            this.kendoPivotGridV21.Instance.saveAsPDF();
        }
    }
}
