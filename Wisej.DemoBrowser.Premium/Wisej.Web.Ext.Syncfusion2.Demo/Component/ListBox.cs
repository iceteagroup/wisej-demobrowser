using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class ListBox : TestBase
	{
		public ListBox()
		{
			InitializeComponent();

			this.listBox1.Instance.onChange += new WidgetEventHandler(listBox1_change);
		}

		private void ListBox_Load(object sender, EventArgs e)
		{
			this.listBox1.Options.dataSource = new object[]
			{
				new
				{
					text = "Hennessey Venom"
				},
				new
				{
					text = "Bugatti Chiron"
				},
				new
				{
					text = "Bugatti Veyron Super Sport"
				},
				new
				{
					text = "SSC Ultimate Aero"
				},
				new
				{
					text = "Koenigsegg CCR"
				},
				new
				{
					text = "McLaren F1"
				},
				new
				{
					text = "Aston Martin One- 77"
				},
				new
				{
					text = "Jaguar XJ220"
				},
				new
				{
					text = "McLaren P1"
				},
				new
				{
					text = "Ferrari LaFerrari"
				}
			};
			this.listBox1.Options.allowFiltering = true;
			this.listBox1.Options.filterType = "StartsWith";
			this.listBox1.Options.filterBarPlaceholder = "Search ...";
			this.listBox1.Options.sortOrder = "Ascending";
		}

		private void listBox1_change(object sender, WidgetEventArgs e)
		{
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
						MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.listBox1.Options.sortOrder = this.comboBoxSortOrder.Text;
			this.listBox1.Options.filterType = this.comboBoxFilterType.Text;
			this.listBox1.Options.allowFiltering = this.checkBoxFiltering.Checked;
			this.listBox1.Options.allowDragAndDrop = this.checkBoxDragAndDrop.Checked;

			// For force enabling of filtering
			this.listBox1.Instance.refresh();

			this.listBox1.Update();
		}

		private void checkBoxFiltering_CheckedChanged(object sender, EventArgs e)
		{
			this.comboBoxFilterType.Enabled = this.checkBoxFiltering.Checked;
		}
	}
}