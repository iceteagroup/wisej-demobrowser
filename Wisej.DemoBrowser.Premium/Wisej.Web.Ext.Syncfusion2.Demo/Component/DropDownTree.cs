using System;
using System.Collections.Generic;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DropDownTree : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public DropDownTree()
		{
			InitializeComponent();

            this.dropDownTree1.Instance.onChange += new WidgetEventHandler(dropDownTree1_WidgetEvent);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			List<object> subNodes = new List<object>();
            foreach (var item in tagTextBoxSubNodeDataSource.Text.Split(','))
            {
                subNodes.Add(new
                {
                    id = Guid.NewGuid().ToString(),
                    name = item,
                });
            }

            if(comboBoxNode.SelectedIndex>=0)
                this.dropDownTree1.Options.fields.dataSource[comboBoxNode.SelectedIndex].subChild = subNodes.ToArray();

            this.dropDownTree1.Update();
        }

        private void dropDownTree1_WidgetEvent(object sender, WidgetEventArgs e)
        {
            AlertBox.Show(
                $"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
                MessageBoxIcon.Information);

            Application.Play(MessageBoxIcon.Information);
        }
    }
}
