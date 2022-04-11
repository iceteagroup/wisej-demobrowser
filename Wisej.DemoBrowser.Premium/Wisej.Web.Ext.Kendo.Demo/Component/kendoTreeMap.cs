using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoTreeMap : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoTreeMap()
		{
			InitializeComponent();
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.comboBoxType.SelectedIndex = 0;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.kendoTreeMap1.Options.type = this.comboBoxType.SelectedText?.ToLower();

            this.kendoTreeMap1.Update();
        }
    }
}
