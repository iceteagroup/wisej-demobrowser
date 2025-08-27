using System;
using System.Dynamic;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejGrid : TestBase
	{
		public ejGrid()
		{
			InitializeComponent();

			this.ejGrid1.Instance.onCellSave += new WidgetEventHandler(ejGrid1_WidgetEvent);
			this.ejGrid1.Instance.onBatchSave += new WidgetEventHandler(ejGrid1_WidgetEvent);
			this.ejGrid1.Instance.onRowSelected += new WidgetEventHandler(ejGrid1_WidgetEvent);
			this.ejGrid1.Instance.onCellSelected += new WidgetEventHandler(ejGrid1_WidgetEvent);
			this.ejGrid1.Instance.onToolbarClick += new WidgetEventHandler(ejGrid1_WidgetEvent);
		}

		private void ejGrid_Load(object sender, EventArgs e)
		{
			this.ejGrid1.Options.dataSource = new dynamic[]
			{
				new
				{
					iD = 1004641, age = 38, employment = "Private",
					education = "College",
					marital = "Unmarried",
					occupation = "Service",
					income = 81838, sex = "Female",
					deductions = 0, hours = 72, accounts = "UnitedStates",
					adjustment = 0, adjusted = 0
				},
				new
				{
					iD = 1010229, age = 35, employment = "Private",
					education = "Associate",
					marital = "Absent",
					occupation = "Transport",
					income = 72099, sex = "Male",
					deductions = 0, hours = 30, accounts = "Jamaica",
					adjustment = 0, adjusted = 0
				},
				new
				{
					iD = 1024587, age = 32, employment = "Private",
					education = "HSgrad",
					marital = "Divorced",
					occupation = "Clerical",
					income = 154676.74, sex = "Male",
					deductions = 0, hours = 40, accounts = "UnitedStates",
					adjustment = 0, adjusted = 0
				},
				new
				{
					iD = 1038288, age = 45, employment = "Private",
					education = "Bachelor",
					marital = "Married",
					occupation = "Repair",
					income = 27743.82, sex = "Male",
					deductions = 0, hours = 55, accounts = "UnitedStates",
					adjustment = 7298, adjusted = 1
				},
				new
				{
					iD = 1044221, age = 60, employment = "Private",
					education = "College",
					marital = "Married",
					occupation = "Executive",
					income = 7568.23, sex = "Male",
					deductions = 0, hours = 40, accounts = "UnitedStates",
					adjustment = 15024, adjusted = 1
				},
				new
				{
					iD = 1047095, age = 74, employment = "Private",
					education = "HSgrad",
					marital = "Married",
					occupation = "Service",
					income = 33144.4, sex = "Male",
					deductions = 0, hours = 30, accounts = "UnitedStates",
					adjustment = 0, adjusted = 0
				},
				new
				{
					iD = 1047698, age = 43, employment = "Private",
					education = "Bachelor",
					marital = "Married",
					occupation = "Executive",
					income = 43391.17, sex = "Male",
					deductions = 0, hours = 50, accounts = "UnitedStates",
					adjustment = 22418, adjusted = 1
				},
				new
				{
					iD = 1053888, age = 35, employment = "Private",
					education = "Yr12",
					marital = "Married",
					occupation = "Machinist",
					income = 59906.65, sex = "Male",
					deductions = 0, hours = 40, accounts = "UnitedStates",
					adjustment = 0, adjusted = 0
				},
				new
				{
					iD = 1061323, age = 25, employment = "Private",
					education = "Associate",
					marital = "Divorced",
					occupation = "Clerical",
					income = 126888.91, sex = "Female",
					deductions = 0, hours = 40, accounts = "UnitedStates",
					adjustment = 0, adjusted = 0
				},
				new
				{
					iD = 1062363, age = 22, employment = "Private",
					education = "HSgrad",
					marital = "Absent",
					occupation = "Sales",
					income = 52466.49, sex = "Female",
					deductions = 0, hours = 37, accounts = "UnitedStates",
					adjustment = 0, adjusted = 0
				},
				new
				{
					iD = 1068642, age = 48, employment = "Private",
					education = "College",
					marital = "Divorced",
					occupation = "Service",
					income = 291416.11, sex = "Female",
					deductions = 0, hours = 35, accounts = "UnitedStates",
					adjustment = 0, adjusted = 0
				},
				new
				{
					iD = 1071615, age = 60, employment = "Private",
					education = "Vocational",
					marital = "Widowed",
					occupation = "Clerical",
					income = 24155.31, sex = "Male",
					deductions = 0, hours = 40, accounts = "UnitedStates",
					adjustment = 0, adjusted = 0
				},
				new
				{
					iD = 1071878, age = 21, employment = "Private",
					education = "College",
					marital = "Absent",
					occupation = "Service",
					income = 143254.86, sex = "Female",
					deductions = 0, hours = 35, accounts = "UnitedStates",
					adjustment = 0, adjusted = 0
				},
				new
				{
					iD = 1077831, age = 21, employment = "Private",
					education = "College",
					marital = "Absent",
					occupation = "Machinist",
					income = 120554.81, sex = "Male",
					deductions = 0, hours = 40, accounts = "UnitedStates",
					adjustment = 0, adjusted = 0
				}
			};
			this.ejGrid1.Options.allowPaging = true;
			this.ejGrid1.Options.isResponsive = true;
			this.ejGrid1.Options.columns = new object[]
			{
				new
				{
					field = "iD",
					headerText = "ID",
					width = 75, textAlign = 0
				},
				new
				{
					field = "age",
					headerText = "Age",
					width = 40
				},
				new
				{
					field = "employment",
					headerText = "Employment",
					width = 75, textAlign = 0, priority = 4
				},
				new
				{
					field = "education",
					headerText = "Education",
					width = 75, textAlign = 0, priority = 3
				},
				new
				{
					field = "marital",
					headerText = "Marital",
					width = 75, textAlign = 0, priority = 4
				}
			};

			this.ejGrid1.Options.editSettings.allowEditing = true;
			this.ejGrid1.Options.editSettings.allowAdding = true;
			this.ejGrid1.Options.editSettings.allowDeleting = true;
			this.ejGrid1.Options.editSettings.editMode = "batch";

			this.ejGrid1.Options.allowCellMerging = this.checkBox2.Checked;
			this.ejGrid1.Options.allowGrouping = this.checkBox3.Checked;
			this.ejGrid1.Options.allowKeyboardNavigation = this.checkBox4.Checked;
			this.ejGrid1.Options.allowFiltering = this.checkBox5.Checked;
			this.ejGrid1.Options.allowSorting = this.checkBox6.Checked;
			this.ejGrid1.Options.allowMultiSorting = this.checkBox7.Checked;

			this.ejGrid1.Options.toolbarSettings = new
			{
				showToolbar = true,
				toolbarItems = new object[]
				{
					"add", "edit", "delete", "update", "cancel"
				}
			};
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
				using (var stream = new StreamReader(e.Files[0].InputStream))
				{
					var json = stream.ReadToEnd();
					this.ejGrid1.Instance.dataSource(JSON.Parse(json));
				}
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.ejGrid1.Instance.optionAsync("dataSource");
			var json = Core.WisejSerializer.Serialize(data);

			Application.Download(new MemoryStream(Encoding.UTF8.GetBytes(json)), "grid.json");
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejGrid1.Options.editSettings.allowEditing = this.checkBox1.Checked;
			this.ejGrid1.Options.allowCellMerging = this.checkBox2.Checked;
			this.ejGrid1.Options.allowGrouping = this.checkBox3.Checked;
			this.ejGrid1.Options.allowKeyboardNavigation = this.checkBox4.Checked;
			this.ejGrid1.Options.allowFiltering = this.checkBox5.Checked;
			this.ejGrid1.Options.allowSorting = this.checkBox6.Checked;
			this.ejGrid1.Options.allowMultiSorting = this.checkBox7.Checked;

			this.ejGrid1.Update();
		}

		private void ejGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}