using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejLinearGauge : TestBase
	{
		public ejLinearGauge()
		{
			InitializeComponent();

			this.ejLinearGauge1.Instance.onMouseClick += new WidgetEventHandler(ejLinearGauge1_WidgetEvent);
			this.ejLinearGauge1.Instance.onRightClick += new WidgetEventHandler(ejLinearGauge1_WidgetEvent);
			this.ejLinearGauge1.Instance.onDoubleClick += new WidgetEventHandler(ejLinearGauge1_WidgetEvent);
		}

		private void ejLinearGauge_Load(object sender, EventArgs e)
		{
			this.ejLinearGauge1.Options.enableAnimation = false;
			this.ejLinearGauge1.Options.labelColor = "#8c8c8c";
			this.ejLinearGauge1.Options.isResponsive = true;
			this.ejLinearGauge1.Options.scales = new object[]
			{
				new
				{
					width = 4, border = new
					{
						color = "transparent",
						width = 0
					},
					showBarPointers = false, showRanges = true, length = 310, position = new
					{
						x = 52,
						y = 50
					},
					markerPointers = new object[]
					{
						new
						{
							value = 50, length = 10, width = 10, backgroundColor = "#4D4D4D",
							border = new
							{
								color = "#4D4D4D"
							}
						}
					},
					labels = new object[]
					{
						new
						{
							font = new
							{
								size = "11px",
								fontFamily = "Segoe UI",
								fontStyle = "bold"
							},
							distanceFromScale = new
							{
								x = -13
							}
						}
					},
					ticks = new object[]
					{
						new
						{
							type = "majorinterval",
							width = 1, color = "#8c8c8c"
						}
					},
					ranges = new object[]
					{
						new
						{
							endValue = 60, startValue = 0, backgroundColor = "#F6B53F",
							border = new
							{
								color = "#F6B53F"
							},
							startWidth = 4, endWidth = 4
						},
						new
						{
							endValue = 100, startValue = 60, backgroundColor = "#E94649",
							border = new
							{
								color = "#E94649"
							},
							startWidth = 4, endWidth = 4
						}
					}
				}
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejLinearGauge1.Options.value = this.numericUpDownVal.Value;
			this.ejLinearGauge1.Options.orientation = this.comboBoxOrientation.Text;
			this.ejLinearGauge1.Options.outerCustomLabelPosition = this.comboBoxLabelPosition.Text;

			this.ejLinearGauge1.Update();
		}

		private void ejLinearGauge1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			this.ejLinearGauge1.Instance.exportImage("ejLinearGauge", "jpeg");
		}
	}
}