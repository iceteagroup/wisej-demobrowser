using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxTileView : TestBase
	{
		public dxTileView()
		{
			InitializeComponent();

			this.dxTileView1.Instance.onItemClick += new WidgetEventHandler(dxTileView1_WidgetEvent);
		}

		private void dxTileView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxTileView1.Options.itemMargin = this.numericUpDownItemMargin.Value;
			this.dxTileView1.Options.baseItemWidth = this.numericUpDownBaseItemWidth.Value;
			this.dxTileView1.Options.baseItemHeight = this.numericUpDownBaseItemHeight.Value;

			this.dxTileView1.Update();
		}

        private void dxTileView_Load(object sender, EventArgs e)
        {
			this.dxTileView1.Options = new
			{
				direction = "vertical",
				baseItemHeight = 75,
				baseItemWidth = 75,
				items = new object[]
                {
                    new 
                    {
                        ID =  "1",
                        Address =  "652 Avonwick Gate",
                        City =  "Toronto",
                        State =  "ON",
                        Price =  780000,
                        ImageSrc =  "Images/TileView/1.jpg"
                    },
                    new 
                    {
                        ID =  "2",
                        Address =  "328 S Kerema Ave",
                        City =  "Milford",
                        State =  "CT",
                        Price =  350000,
                        ImageSrc =  "Images/TileView/3.jpg"
                    },
                    new 
                    {
                        ID =  "3",
                        Address =  "8512 Tanglewood Cir",
                        City =  "Reform",
                        State =  "AL",
                        Price =  250000,
                        ImageSrc =  "Images/TileView/6.jpg",
                        widthRatio = 2
                    },
                    new  
                    {
                        ID =  "4",
                        Address =  "6351 Forrest St",
                        City =  "Jersey City",
                        State =  "NJ",
                        Price =  320000,
                        ImageSrc =  "Images/TileView/14.jpg"
                    },
                    new  
                    {
                        ID =  "5",
                        Address =  "61207 16th St N",
                        City =  "Moorhead",
                        State =  "MN",
                        Price =  1700000,
                        ImageSrc =  "Images/TileView/5.jpg",
                        heightRatio = 2,
                        widthRatio = 2
                    },
                    new 
                    {
                        ID =  "6",
                        Address =  "5119 Beryl Dr",
                        City =  "San Antonio",
                        State =  "TX",
                        Price =  455000,
                        ImageSrc =  "Images/TileView/4.jpg"
                    },
                    new 
                    {
                        ID =  "7",
                        Address =  "7121 Bailey St",
                        City =  "Worcester",
                        State =  "MA",
                        Price =  555000,
                        ImageSrc =  "Images/TileView/7.jpg"
                    },
                    new 
                    {
                        ID =  "8",
                        Address =  "82649 Topeka St",
                        City =  "Riverbank",
                        State =  "CA",
                        Price =  1750000,
                        ImageSrc =  "Images/TileView/2.jpg",
                        heightRatio = 2
                    },
                    new 
                    {
                        ID =  "14",
                        Address =  "114840 Interlake Ave N",
                        City =  "Seattle",
                        State =  "WA",
                        Price =  400000,
                        ImageSrc =  "images/TileView/22.jpg"
                    },
                    new 
                    {
                        ID =  "15",
                        Address =  "13673 Pearl Dr #7",
                        City =  "Monroe",
                        State =  "MI",
                        Price =  399000,
                        ImageSrc =  "images/TileView/20.jpg"
                    },
                    new {
                        ID =  "16",
                        Address =  "15447 Via Viento",
                        City =  "Atascadero",
                        State =  "CA",
                        Price =  1100000,
                        ImageSrc =  "images/TileView/21.jpg"
                    }
                }
			};

			this.dxTileView1.Update();
        }
    }
}
