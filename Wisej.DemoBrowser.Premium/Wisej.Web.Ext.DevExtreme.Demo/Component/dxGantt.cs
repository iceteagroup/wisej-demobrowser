﻿using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxGantt : TestBase
	{
		public dxGantt()
		{
			InitializeComponent();

			

			this.dxGantt1.Instance.onSelectionChanged += new WidgetEventHandler(dxGantt1_WidgetEvent);
		}


        private void dxGantt1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxGantt1.Options.allowSelection = this.checkBox1.Checked;
			this.dxGantt1.Options.showResources = this.checkBox2.Checked;
			this.dxGantt1.Options.showRowLines = this.checkBox3.Checked;
			this.dxGantt1.Options.scaleType = this.comboBox2.Text.ToLower();
			this.dxGantt1.Options.taskTitlePosition = this.comboBox1.Text.ToLower();

			this.dxGantt1.Update();
		}

        private void dxGantt_Load(object sender, EventArgs e)
        {
			
			this.dxGantt1.Options = new
			{
				editing = new
                {
					enabled = true
                },
				columns = new object[]
                {
                    new
                    {
						dataField = "title",
						caption = "Subject",
						width = 300
					},
					new 
					{
						dataField = "start",
						caption = "Start Date"
					},
					new
					{
						dataField = "end",
						caption = "End Date"
					}
				},
				scaleType = "weeks",
				taskListWidth = 500,
				tasks = new {},
				dependencies = new {},
				resources = new {},
				resourceAssignments = new {}
			};



			this.dxGantt1.Update();

			this.dxGantt1.Options.tasks.dataSource = Wisej.Core.WisejSerializer.Parse(File.ReadAllText(Application.MapPath("Data/Gantt/tasks.json")));
			this.dxGantt1.Options.dependencies.dataSource = Wisej.Core.WisejSerializer.Parse(File.ReadAllText(Application.MapPath("Data/Gantt/dependencies.json")));
			this.dxGantt1.Options.resources.dataSource = Wisej.Core.WisejSerializer.Parse(File.ReadAllText(Application.MapPath("Data/Gantt/resources.json")));
			this.dxGantt1.Options.resourceAssignments.dataSource = Wisej.Core.WisejSerializer.Parse(File.ReadAllText(Application.MapPath("Data/Gantt/resourceAssignments.json")));


			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 4;

		}

    }
}
