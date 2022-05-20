using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxTreeList : TestBase
	{
		public dxTreeList()
		{
			InitializeComponent();

			this.dxTreeList1.Instance.onCellClick += new WidgetEventHandler(dxTreeList1_WidgetEvent);
		}

		private void dxTreeList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxTreeList1.Options.autoExpandAll = this.checkBox3.Checked;
			this.dxTreeList1.Options.columnHidingEnabled = this.checkBox6.Checked;
			this.dxTreeList1.Options.allowColumnReordering = this.checkBox1.Checked;
			this.dxTreeList1.Options.columnChooser = new
			{
				enabled = this.checkBox5.Checked,
				allowSearch = this.checkBox8.Checked
			};
			this.dxTreeList1.Options.expandNodesOnFiltering = this.checkBox8.Checked;

			this.dxTreeList1.Update();
		}

        private void dxTreeList_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;
			this.dxTreeList1.Options = new
			{
				autoExpandAll = true,
				columns = new string[3] { "position", "fullName", "email" },
				dataSource = new object[]
				{
					new 
					{
						id =  1,
						parentId =  0,
						fullName = "John Heart",
						position =  "CEO",
						email =  "jheart@dx-email.com"
					},
					new 
					{
						id =  2,
						parentId =  1,
						fullName = "Samantha Bright",
						position =  "COO",
						email =  "samanthab@dx-email.com"
					},
					new 
					{
						id =  3,
						parentId =  1,
						fullName = "Arthur Miller",
						position =  "CTO",
						email =  "arthurm@dx-email.com"
					},
					new 
					{
						id =  4,
						parentId =  1,
						fullName = "Robert Reagan",
						position =  "CMO",
						email =  "robertr@dx-email.com"
					},
					new 
					{
						id =  5,
						parentId =  2,
						fullName = "Greta Sims",
						position =  "HR Manager",
						email =  "gretas@dx-email.com"
					}
				},
				showRowLines = true
			};
			this.dxTreeList1.Update();
		}
	}
}
