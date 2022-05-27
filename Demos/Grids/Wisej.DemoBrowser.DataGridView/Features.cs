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
			
			personBindingSource.DataSource = DataGenerator.GeneratePersonData(300);
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

			if (this.dataGridView1.Columns[e.ColumnIndex].Name == "colButton")
			{
				var result = MessageBox.Show("Are you sure you would like to delete this user?",
					caption: "Confirm Deletion",
					buttons: MessageBoxButtons.YesNo,
					icon: MessageBoxIcon.Warning);

				if (result == DialogResult.Yes)
					this.dataGridView1.Rows.RemoveAt(e.RowIndex);
			}
		}
	}
}