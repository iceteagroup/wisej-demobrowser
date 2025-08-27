using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSunburstChart : TestBase
	{
		public ejSunburstChart()
		{
			InitializeComponent();

			this.ejSunburstChart1.Instance.onClick += new WidgetEventHandler(ejSunburstChart1_WidgetEvent);
			this.ejSunburstChart1.Instance.onLegendItemClick += new WidgetEventHandler(ejSunburstChart1_WidgetEvent);
		}

		private void ejSunburstChart_Load(object sender, EventArgs e)
		{
			this.ejSunburstChart1.Options.dataSource = new object[]
			{
				new
				{
					Category = "Employees",
					Country = "USA",
					JobDescription = "Sales",
					JobGroup = "Executive",
					EmployeesCount = 50
				},
				new
				{
					Category = "Employees",
					Country = "USA",
					JobDescription = "Sales",
					JobGroup = "Analyst",
					EmployeesCount = 40
				},
				new
				{
					Category = "Employees",
					Country = "USA",
					JobDescription = "Marketing",
					EmployeesCount = 40
				},
				new
				{
					Category = "Employees",
					Country = "USA",
					JobDescription = "Technical",
					JobGroup = "Testers",
					EmployeesCount = 55
				},
				new
				{
					Category = "Employees",
					Country = "USA",
					JobDescription = "Technical",
					JobGroup = "Developers",
					JobRole = "Windows",
					EmployeesCount = 175
				},
				new
				{
					Category = "Employees",
					Country = "USA",
					JobDescription = "Technical",
					JobGroup = "Developers",
					JobRole = "Web",
					EmployeesCount = 70
				},
				new
				{
					Category = "Employees",
					Country = "USA",
					JobDescription = "Management",
					EmployeesCount = 40
				},
				new
				{
					Category = "Employees",
					Country = "USA",
					JobDescription = "Accounts",
					EmployeesCount = 60
				},
				new
				{
					Category = "Employees",
					Country = "India",
					JobDescription = "Technical",
					JobGroup = "Testers",
					EmployeesCount = 43
				},
				new
				{
					Category = "Employees",
					Country = "India",
					JobDescription = "Technical",
					JobGroup = "Developers",
					JobRole = "Windows",
					EmployeesCount = 125
				},
				new
				{
					Category = "Employees",
					Country = "India",
					JobDescription = "Technical",
					JobGroup = "Developers",
					JobRole = "Web",
					EmployeesCount = 60
				},
				new
				{
					Category = "Employees",
					Country = "India",
					JobDescription = "HR Executives",
					EmployeesCount = 70
				},
				new
				{
					Category = "Employees",
					Country = "India",
					JobDescription = "Accounts",
					EmployeesCount = 45
				},
				new
				{
					Category = "Employees",
					Country = "Germany",
					JobDescription = "Sales",
					JobGroup = "Executive",
					EmployeesCount = 30
				},
				new
				{
					Category = "Employees",
					Country = "Germany",
					JobDescription = "Sales",
					JobGroup = "Analyst",
					EmployeesCount = 40
				},
				new
				{
					Category = "Employees",
					Country = "Germany",
					JobDescription = "Marketing",
					EmployeesCount = 50
				},
				new
				{
					Category = "Employees",
					Country = "Germany",
					JobDescription = "Technical",
					JobGroup = "Testers",
					EmployeesCount = 40
				},
				new
				{
					Category = "Employees",
					Country = "Germany",
					JobDescription = "Technical",
					JobGroup = "Developers",
					JobRole = "Windows",
					EmployeesCount = 65
				},
				new
				{
					Category = "Employees",
					Country = "Germany",
					JobDescription = "Technical",
					JobGroup = "Developers",
					JobRole = "Web",
					EmployeesCount = 27
				},
				new
				{
					Category = "Employees",
					Country = "Germany",
					JobDescription = "Management",
					EmployeesCount = 33
				},
				new
				{
					Category = "Employees",
					Country = "Germany",
					JobDescription = "Accounts",
					EmployeesCount = 55
				},
				new
				{
					Category = "Employees",
					Country = "UK",
					JobDescription = "Technical",
					JobGroup = "Testers",
					EmployeesCount = 45
				},
				new
				{
					Category = "Employees",
					Country = "UK",
					JobDescription = "Technical",
					JobGroup = "Developers",
					JobRole = "Windows",
					EmployeesCount = 96
				},
				new
				{
					Category = "Employees",
					Country = "UK",
					JobDescription = "Technical",
					JobGroup = "Developers",
					JobRole = "Web",
					EmployeesCount = 55
				},
				new
				{
					Category = "Employees",
					Country = "UK",
					JobDescription = "HR Executives",
					EmployeesCount = 60
				},
				new
				{
					Category = "Employees",
					Country = "UK",
					JobDescription = "Accounts",
					EmployeesCount = 30
				},
				new
				{
					Category = "Employees",
					Country = "France",
					JobDescription = "Technical",
					JobGroup = "Testers",
					EmployeesCount = 40
				},
				new
				{
					Category = "Employees",
					Country = "France",
					JobDescription = "Technical",
					JobGroup = "Developers",
					JobRole = "Windows",
					EmployeesCount = 65
				},
				new
				{
					Category = "Employees",
					Country = "France",
					JobDescription = "Technical",
					JobGroup = "Developers",
					JobRole = "Web",
					EmployeesCount = 27
				},
				new
				{
					Category = "Employees",
					Country = "France",
					JobDescription = "Marketing",
					EmployeesCount = 50
				}
			};
			this.ejSunburstChart1.Options.valueMemberPath = "EmployeesCount";
			this.ejSunburstChart1.Options.levels = new object[]
			{
				new
				{
					groupMemberPath = "Country"
				},
				new
				{
					groupMemberPath = "JobDescription"
				},
				new
				{
					groupMemberPath = "JobGroup"
				},
				new
				{
					groupMemberPath = "JobRole"
				}
			};
			this.ejSunburstChart1.Options.dataLabelSettings = new
			{
				visible = true
			};
			this.ejSunburstChart1.Options.tooltip = new
			{
				visible = true
			};
			this.ejSunburstChart1.Options.innerRadius = 0.2;
			this.ejSunburstChart1.Options.title = new
			{
				text = "Employees Count"
			};
			this.ejSunburstChart1.Options.legend = new
			{
				visible = true,
				position = "top"
			};
		}

		private void ejSunburstChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSunburstChart1.Options.legend = new
			{
				visible = this.checkBox1.Checked,
				position = this.comboBox1.SelectedItem.ToString().ToLower()
			};
			this.ejSunburstChart1.Options.startAngle = this.numericUpDown1.Value;
			this.ejSunburstChart1.Options.endAngle = this.numericUpDown2.Value;
			this.ejSunburstChart1.Options.radius = this.numericUpDown3.Value;
			this.ejSunburstChart1.Options.innerRadius = this.numericUpDown4.Value;

			this.ejSunburstChart1.Update();
		}
	}
}