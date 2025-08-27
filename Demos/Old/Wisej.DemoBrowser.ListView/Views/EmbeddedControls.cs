using System;
using Wisej.Web;
using Wisej.DemoBrowser.Common;
using Wisej.DemoBrowser.Common.Views;
using Wisej.DemoBrowser.ListView.Components;
using System.Drawing;
using System.ComponentModel;

namespace Wisej.DemoBrowser.ListView.Views
{
	[AddToTreeView(true)]
	[CustomName("Embedded Controls")]
	[ImageSource("resource.wx/Wisej.Ext.VisualStudioIcons/ItemListView.svg")]
	[Description("ListViews in Wisej allows you to embed variety of controls into in a ListViewItem")]
	public partial class EmbeddedControls : DemoView
    {
        public EmbeddedControls()
        {
            InitializeComponent();
        }

        private void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you!");
        }

        private void EmbeddedControls_Load(object sender, EventArgs e)
        {
			// First, a button:
			Button b = new Button();
			b.Text = "ClickMe";
			b.BackColor = SystemColors.Control;
			b.Font = this.Font;
			b.Dock = DockStyle.Fill;
			b.Click += new EventHandler(b_Click);

			// Put it in the first column of the fourth row
			listView1.Items[3].SubItems[0].Control = b;

			// Second, a RichTextBox (slightly modified to make it non-selectable)
			ReadOnlyRichTextBox rtb = new ReadOnlyRichTextBox();

			rtb.ScrollBars = ScrollBars.None;

			rtb.BorderStyle = BorderStyle.None;
			rtb.WordWrap = false;
			rtb.BackColor = Color.White;
			rtb.Cursor = Cursors.Default;

			// Third, a number of ProcessBars that will be updated by a timer
			Random r = new Random();
			foreach (ListViewItem i in listView1.Items)
			{
				int cnt = r.Next(100);
				i.SubItems.Add(cnt.ToString());

				ProgressBar pb = new ProgressBar();
				pb.Value = cnt;
				pb.Dock = DockStyle.Fill;


				// Embed the ProgressBar in Column 2
				i.SubItems[1].Control = pb;
			}

			// Fill the View ComboBox
			Array a = Enum.GetValues(typeof(View));
			foreach (View v in a)
			{
				comboBox1.Items.Add(v.ToString());
			}

			// Default view is Details
			comboBox1.Text = View.Details.ToString();
		}

		// Update embedded ProgressBars
		private Random rnd = new Random();
		private void timer1_Tick(object sender, EventArgs e)
		{
			int row = rnd.Next(listView1.Items.Count);

			ProgressBar pb = listView1.Items[row].SubItems[1].Control as ProgressBar;
			if (pb == null)
			{
				int val = int.Parse(listView1.Items[row].SubItems[1].Text);
				val += 5;
				if (val > 100)
					val = 0;

				listView1.Items[row].SubItems[1].Text = val.ToString();
				return;
			}

			if (pb.Value >= pb.Maximum - 5)
				pb.Value = pb.Minimum;
			else
				pb.Value += 5;

			if (listView1.View == View.Details)
			{
				pb.Text = pb.Value.ToString();
			}
			else
			{
				listView1.Items[row].SubItems[1].Text = pb.Value.ToString();
			}


		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			View v = (View)Enum.Parse(typeof(View), comboBox1.Text, true);
			listView1.View = v;
		}
    }

    
}
