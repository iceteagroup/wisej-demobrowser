﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igFunnelChart : TestBase
	{
		public igFunnelChart()
		{
			InitializeComponent();

			this.igFunnelChart1.Instance.onSliceClicked += new WidgetEventHandler(igFunnelChart1_WidgetEvent);
		}

		private void igFunnelChart_Load(object sender, EventArgs e)
		{
			this.igFunnelChart1.Options.tooltipTemplate = "<span>Budget: $${Budget}<br>Dept: ${Department}</span>";
			this.igFunnelChart1.Options.transitionDuration = 250;
			this.igFunnelChart1.Options.valueMemberPath = "Budget";
			this.igFunnelChart1.Options.innerLabelMemberPath = "Budget";
			this.igFunnelChart1.Options.innerLabelVisibility = "visible";
			this.igFunnelChart1.Options.outerLabelMemberPath = "Department";
			this.igFunnelChart1.Options.outerLabelVisibility = "visible";
			this.igFunnelChart1.Options.dataSource = new dynamic[]{new {Budget = 30, Department="Administration", },
				new {Budget = 50, Department="Sales", },
				new {Budget = 60, Department="IT", },
				new {Budget = 50, Department="Marketing", },
				new {Budget = 100, Department="Development", },
				new {Budget = 20, Department="Support", },
			};
		}

		private void igFunnelChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igFunnelChart1.Options.transitionDuration = this.numericUpDown1.Value;
			this.igFunnelChart1.Options.useBezierCurve = this.checkBox2.Checked;
			this.igFunnelChart1.Options.funnelSliceDisplay = this.comboBox1.SelectedItem;
			this.igFunnelChart1.Options.isInverted = this.checkBox3.Checked;
			this.igFunnelChart1.Options.bottomEdgeWidth = this.numericUpDown2.Value;

			this.igFunnelChart1.Update();
		}
	}
}
