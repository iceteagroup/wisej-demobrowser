using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejAutocomplete : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejAutocomplete()
		{
			InitializeComponent();

			this.ejAutocomplete1.Instance.onChange += new WidgetEventHandler(ejAutocomplete1_WidgetEvent);
		}

		private void ejAutocomplete_Load(object sender, EventArgs e)
		{
			this.ejAutocomplete1.Options.watermarkText = "Select a car";
			this.ejAutocomplete1.Options.dataSource = new object[]
			{"Audi S6","Austin-Healey","Alfa Romeo","Aston Martin","BMW 7","Bentley Mulsanne","Bugatti Veyron","Chevrolet Camaro","Cadillac","Duesenberg J","Dodge Sprinter","Elantra","Excavator","Ford Boss 302","Ferrari 360","Ford Thunderbird","GAZ Siber","Honda S2000","Hyundai Santro","Isuzu Swift","Infiniti Skyline","Jaguar XJS","Kia Sedona EX","Koenigsegg Agera","Lotus Esprit","Lamborghini Diablo","Mercedes-Benz","Mercury Coupe","Maruti Alto 800","Nissan Qashqai","Oldsmobile S98","Opel Superboss","Porsche 356","Pontiac Sunbird","Scion SRS/SC/SD","Saab Sportcombi","Subaru Sambar","Suzuki Swift","Triumph Spitfire","Toyota 2000GT","Volvo P1800","Volkswagen Shirako",
			};
			this.ejAutocomplete1.Options.value = "ejAutocomplete1";
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var selectedVal = await this.ejAutocomplete1.Instance.getValueAsync();

			AlertBox.Show(selectedVal);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejAutocomplete1.Options.autoFocus = this.checkBox1.Checked;
			this.ejAutocomplete1.Options.caseSensitiveSearch = this.checkBox2.Checked;
			this.ejAutocomplete1.Options.highlightSearch = this.checkBox3.Checked;
			this.ejAutocomplete1.Options.showEmptyResultText = this.checkBox4.Checked;
			this.ejAutocomplete1.Options.showResetIcon = this.checkBox5.Checked;
			this.ejAutocomplete1.Options.showPopupButton = this.checkBox6.Checked;

			this.ejAutocomplete1.Update();
		}

		private void ejAutocomplete1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
		
	}
}
