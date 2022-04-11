using System;
using System.Linq;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.DataGridView
{
    public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void ColumnTypes_Load(object sender, EventArgs e)
		{
			InitializeGenderBinding();
			FillDataGrid();
		}

		private void Button_Click(object sender, EventArgs e)
		{
			AlertBox.Show("Button Clicked");
		}

		private void FillDataGrid()
		{
			var data = DataGenerator.GeneratePersonData(300);

			personBindingSource.DataSource = data;
		}

		private void InitializeGenderBinding()
		{
			var gender = Enum.GetNames(typeof(PersonGender)).ToList();

			genderBindingSource.DataSource = gender;
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == -1)
				return;

			var dgv = (Web.DataGridView) sender;
			if (dgv.Columns[e.ColumnIndex].Name == "colButton") dgv.Rows.RemoveAt(e.RowIndex);
		}
	}
}