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
    }
}
