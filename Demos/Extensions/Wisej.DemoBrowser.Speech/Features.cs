using System;
using System.Drawing;
using System.Net.Mime;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.Speech;

namespace Wisej.DemoBrowser.Speech
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			speechSynthesis.Language = this.comboBoxLanguage.Text;
			speechSynthesis.Speak(this.textBox1.Text);
		}

		private void speechRecognition_SpeechStart(object sender, EventArgs e)
		{
			AlertBox.Show("Speech Recognition started");
		}

		private void speechRecognition_SpeechEnd(object sender, EventArgs e)
		{
			AlertBox.Show("Speech Recognition ended");
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			speechRecognition.Stop();
			speechRecognition.Enabled = false;
			btnStop.Enabled = false;
			btnRecord.Enabled = true;
			btnPlay.Enabled = true;
		}

		private void speechRecognition_Result(object sender, SpeechRecognitionEventArgs e)
		{
			foreach (var item in e.Results)
			{
				textBox1.Text += item.Transcript;
			}
		}

		private void btnRecord_Click(object sender, EventArgs e)
		{
			speechRecognition.Start();
			speechRecognition.Enabled = true;

			btnPlay.Enabled = false;
			btnRecord.Enabled = false;
			btnStop.Enabled = true;
		}
	}
}
