﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igRating : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igRating()
		{
			InitializeComponent();

			this.igRating1.Instance.onValueChange += new WidgetEventHandler(igRating_WidgetEvent);
		}

		private void igRating_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

			this.comboBoxPrecision.SelectedIndex = 0;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igRating1.Instance.value(this.numericUpDown1.Value);

			this.igRating1.Options.precision = this.comboBoxPrecision.SelectedItem.ToString();
			this.igRating1.Update();
		}
	}
}
