﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DatePicker : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public DatePicker()
		{
			InitializeComponent();

			this.datePicker1.Instance.onChange += new WidgetEventHandler(datePicker1_WidgetEvent);
			this.datePicker1.Instance.onNavigated += new WidgetEventHandler(datePicker1_WidgetEvent);
		}

		private void DatePicker_Load(object sender, EventArgs e)
		{
			this.datePicker1.Options.format = "dd-MMM-yy";
			this.datePicker1.Options.value = null;

			this.dateTimePickerStart.Value = DateTime.Now.AddYears(-1);
			this.dateTimePickerEnd.Value = DateTime.Now.AddYears(1);
		}
		private void datePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.datePicker1.Options.format = comboBoxFormat.Text;
			this.datePicker1.Options.max = dateTimePickerEnd.Value.ToShortDateString();
			this.datePicker1.Options.min = dateTimePickerStart.Value.ToShortDateString();
			
			this.datePicker1.Update();
        }
	}
}
