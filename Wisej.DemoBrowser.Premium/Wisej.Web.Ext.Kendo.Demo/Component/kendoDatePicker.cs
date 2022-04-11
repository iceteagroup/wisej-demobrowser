using System;
using System.Linq;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDatePicker : TestBase
	{
		private readonly string[] _possibilities;
		public kendoDatePicker()
		{
			InitializeComponent();

			_possibilities = new string[7]
			{
				"mo","tu","we","th","fr","sa","su"
			};

			this.kendoDatePicker1.Instance.onChange += new WidgetEventHandler(kendoDatePicker1_WidgetEvent);
		}

		private void kendoDatePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			var disableDate = this.tagTextBoxDisableDate.Text.Split(',');
			if(disableDate.Length > this._possibilities.Length)
            {
				AlertBox.Show("Lenght is 7",MessageBoxIcon.Error);
				Application.Play(MessageBoxIcon.Error);
				return;
			}

			bool contains = true;

			disableDate.ToList().ForEach(d =>
			{
				if (!this._possibilities.Contains(d))
					contains = false;
			});

            if (!contains)
            {
				AlertBox.Show("Must contain only mo,tu,we,th,fr,sa,su", MessageBoxIcon.Error);
				Application.Play(MessageBoxIcon.Error);

				return;
            }

			this.kendoDatePicker1.Options.disableDates = disableDate;

			this.kendoDatePicker1.Update();

		}
    }
}
