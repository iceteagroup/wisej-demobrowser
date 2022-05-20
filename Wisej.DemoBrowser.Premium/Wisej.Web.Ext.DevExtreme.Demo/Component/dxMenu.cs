using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxMenu : TestBase
	{
		public dxMenu()
		{
			InitializeComponent();

			this.dxMenu1.Instance.onItemClick += new WidgetEventHandler(dxMenu1_WidgetEvent);
		}

		private void dxMenu1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxMenu1.Options.adaptivityEnabled = this.checkBox1.Checked;
			this.dxMenu1.Options.hideSubmenuOnMouseLeave = this.checkBox2.Checked;
			this.dxMenu1.Options.selectByClick = this.checkBox3.Checked;
			this.dxMenu1.Options.rtlEnabled = this.checkBox4.Checked;
			this.dxMenu1.Options.selectionMode = this.comboBox1.SelectedItem;
			this.dxMenu1.Options.submenuDirection = this.comboBox2.SelectedItem;

			this.dxMenu1.Update();
		}

        private void dxMenu_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 0;

			this.dxMenu1.Options = new
			{
				hideSubmenuOnMouseLeave =false,
				displayExpr = "name",
				dataSource = new object[]
                {
					new
                    {
						id = 1,
						name = "Video Players",
						items = new object[]
                        {
							new
                            {
								id = "1_1",
								name = "HD Video Player",
								price = 220,
								icon = "Images/Menu/1.png",
							},
							new
							{
								id = "1_2",
								name = "SuperHD Video Player",
								price = 270,
								icon = "Images/Menu/2.png",
							}
						}
                    },
					new
                    {
						id = 2,
						name = "Televisions",
						items = new object[]
						{
							new
							{
								id = "2_1",
								name = "SuperLCD 42",
								price = 1200,
								icon = "Images/Menu/7.png",
							},
							new
							{
								id = "2_2",
								name = "SuperLCD 42",
								price = 1450,
								icon = "Images/Menu/2.png",
							},
							new
							{
								id = "2_3",
								name = "SuperLCD 50",
								price = 1600,
								icon = "Images/Menu/4.png",
							},
							new
							{
								id = "2_4",
								name = "SuperLCD 55 (Not availaable)",
								price = 1350,
								icon = "Images/Menu/6.png",
								diabled = true
							},
							new
							{
								id = "2_5",
								name = "SuperLCD 70",
								price = 4000,
								icon = "Images/Menu/9.png",
							}
						}
					},
					new
					{
						id = 3,
						name = "Monitors",
						items = new object[]
						{
							new
							{
								id = "3_1",
								name = "19\"",
								items = new object[]
                                {
									new
									{
										id = "3_1_1",
										name = "DesktopLCD 19",
										price = 160,
										icon = "Images/Menu/10.png",
									}
								}

							},
							new
							{
								id = "3_2",
								name = "21\"",
								items = new object[]
								{
									new
									{
										id = "3_2_1",
										name = "DesktopLCD 21",
										price = 170,
										icon = "Images/Menu/12.png",
									},
									new
									{
										id = "3_2_2",
										name = "DesktopLCD 21",
										price = 175,
										icon = "Images/Menu/13.png",
									}
								}

							},
						}
					},
					new
					{
						id = 4,
						name = "Projectors",
						items = new object[]
						{
							new
							{
								id = "4_1",
								name = "Projector Plus",
								price = 550,
								icon = "Images/Menu/14.png",
							},
							new
							{
								id = "4_2",
								name = "Projector PlusHD",
								price = 750,
								icon = "Images/Menu/2.png",
							}
						}
					},
				}
			};

			this.dxMenu1.Update();
		}
	}
}
