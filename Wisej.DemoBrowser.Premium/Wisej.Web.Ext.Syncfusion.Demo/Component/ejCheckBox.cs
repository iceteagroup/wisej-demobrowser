using System;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejCheckBox : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejCheckBox()
		{
			InitializeComponent();

			this.ejCheckBox1.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox2.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox3.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox4.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox5.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox6.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox7.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox8.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
			this.ejCheckBox9.Instance.onChange += new WidgetEventHandler(ejCheckBoxes_WidgetEvent);
		}

		private void ejCheckBox_Load(object sender, EventArgs e)
		{
			//ejCheckBox1
			this.ejCheckBox1.Options.text = "Music";
			this.ejCheckBox1.Options.value = "ejCheckBox1";

			//ejCheckBox2
			this.ejCheckBox2.Options.text = "Sports";
			this.ejCheckBox2.Options.value = "ejCheckBox2";

			//ejCheckBox3
			this.ejCheckBox3.Options.text = "Bing";
			this.ejCheckBox3.Options.value = "ejCheckBox3";


			//ejCheckBox4
			this.ejCheckBox4.Options.text = "Google";
			this.ejCheckBox4.Options.value = "ejCheckBox4";

			//ejCheckBox5
			this.ejCheckBox5.Options.text = "Yahoo";
			this.ejCheckBox5.Options.value = "ejCheckBox5";

			//ejCheckBox6
			this.ejCheckBox6.Options.text = "Bike Riding";
			this.ejCheckBox6.Options.value = "ejCheckBox6";

			//ejCheckBox7
			this.ejCheckBox7.Options.size = "medium";
			this.ejCheckBox7.Options.text = "Instagram";
			this.ejCheckBox7.Options.enableTriState = true;
			this.ejCheckBox7.Options.value = "ejCheckBox7";


			//ejCheckBox8
			this.ejCheckBox8.Options.size = "medium";
			this.ejCheckBox8.Options.text = "Facebook";
			this.ejCheckBox8.Options.enableTriState = true;
			this.ejCheckBox8.Options.value = "ejCheckBox8";

			//ejCheckBox9
			this.ejCheckBox9.Options.size = "medium";
			this.ejCheckBox9.Options.text = "Twitter";
			this.ejCheckBox9.Options.enableTriState = true;
			this.ejCheckBox9.Options.value = "ejCheckBox9";

		}

		private void ejCheckBoxes_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejCheckBox1.Options.enableTriState = this.checkBox2.Checked;
			this.ejCheckBox1.Options.showRoundedCorner = this.checkBox1.Checked;

			this.ejCheckBox1.Update();
		}
	}
}
