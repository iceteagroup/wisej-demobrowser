using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTile : TestBase
	{
		public ejTile()
		{
			InitializeComponent();

			this.ejTile1.Instance.onMouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			this.ejTile2.Instance.onMouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			this.ejTile3.Instance.onMouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			this.ejTile4.Instance.onMouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			this.ejTile5.Instance.onMouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
			this.ejTile6.Instance.onMouseDown += new WidgetEventHandler(ejTile_WidgetEvent);
		}

		private void ejTile_Load(object sender, EventArgs e)
		{
			//ejTile1
			this.ejTile1.Options.imageUrl = "Images/Tile/people_1.png";
			this.ejTile1.Options.imagePosition = "fill";
			this.ejTile1.Options.tileSize = "medium";
			this.ejTile1.Options.text = "People";
			this.ejTile1.Options.liveTile = new
			{
				updateInterval = 5000,
				enabled = true,
				type = "slide",
				imageUrl = new object[]
				{
					"images/tile/people_1.png", "images/tile/people_2.png"
				}
			};

			//ejTile2
			this.ejTile2.Options.imageUrl = "Images/Tile/alerts.png";
			this.ejTile2.Options.tileSize = "small";
			this.ejTile2.Options.text = "ejTile2";

			//ejTile3
			this.ejTile3.Options.imageUrl = "Images/Tile/bing.png";
			this.ejTile3.Options.text = "ejTile3";

			//ejTile4
			this.ejTile4.Options.imageUrl = "Images/Tile/camera.png";
			this.ejTile4.Options.text = "ejTile4";

			//ejTile5
			this.ejTile5.Options.imageUrl = "Images/Tile/messages.png";
			this.ejTile5.Options.text = "ejTile5";

			//ejTile6
			this.ejTile6.Options.tileSize = "wide";
			this.ejTile6.Options.imagePosition = "center";
			this.ejTile6.Options.text = "Weather";
			this.ejTile6.Options.imageUrl = "Images/Tile/weather.png";
			this.ejTile6.Options.liveTile = new
			{
				updateInterval = 5000,
				enabled = true,
				type = "carousel",
				imageUrl = new object[]
				{
					"images/tile/weather.png", "images/tile/weather_1.png", "images/tile/weather_2.png"
				}
			};

			//ejTile7
			this.ejTile7.Options.imageUrl = "Images/Tile/people_2.png";
			this.ejTile7.Options.imagePosition = "fill";
			this.ejTile7.Options.tileSize = "medium";
			this.ejTile7.Options.text = "Contacts";

			//ejTile8
			this.ejTile8.Options.imageUrl = "Images/Tile/games.png";
			this.ejTile8.Options.tileSize = "medium";
			this.ejTile8.Options.text = "Games";

			//ejTile9
			this.ejTile9.Options.imageUrl = "Images/Tile/pictures.png";
			this.ejTile9.Options.tileSize = "medium";
			this.ejTile9.Options.text = "Photos";

			//ejTile10
			this.ejTile10.Options.imageUrl = "Images/Tile/camera.png";
			this.ejTile10.Options.tileSize = "medium";
			this.ejTile10.Options.text = "Camera";

			//ejTile11
			this.ejTile11.Options.imageUrl = "Images/Tile/sports.png";
			this.ejTile11.Options.tileSize = "wide";
			this.ejTile11.Options.imagePosition = "fill";
			this.ejTile11.Options.text = "Sports";

			//ejTile12
			this.ejTile12.Options.imageUrl = "Images/Tile/music.png";
			this.ejTile12.Options.tileSize = "medium";
			this.ejTile12.Options.imagePosition = "center";
			this.ejTile12.Options.text = "Music";

			//ejTile13
			this.ejTile13.Options.imageUrl = "Images/Tile/alerts.png";
			this.ejTile13.Options.tileSize = "medium";
			this.ejTile13.Options.imagePosition = "center";
			this.ejTile13.Options.text = "Notifications";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTile8.Options.allowSelection = this.checkBox2.Checked;
			this.ejTile8.Options.showRoundedCorner = this.checkBox3.Checked;
			this.ejTile8.Options.imagePosition = this.comboBox1.SelectedItem;
			this.ejTile8.Update();

			this.ejTile5.Options.badge = new
			{
				enabled = true,
				value = (int) this.numericUpDown1.Value
			};

			this.ejTile5.Update();


			this.ejTile1.Options.liveTile.enabled = this.checkBox1.Checked;
			this.ejTile6.Options.liveTile.enabled = this.checkBox1.Checked;
			this.ejTile1.Update();
			this.ejTile6.Update();
		}

		private void ejTile_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}