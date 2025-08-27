using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSignature : TestBase
	{
		public ejSignature()
		{
			InitializeComponent();

			this.ejSignature1.Instance.onChange += new WidgetEventHandler(ejSignature1_WidgetEvent);
		}

		private void ejSignature_Load(object sender, EventArgs e)
		{
			this.ejSignature1.Options.isResponsive = true;
			this.ejSignature1.Options.strokeWidth = 3;
		}

		private void ejSignature1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			this.ejSignature1.Instance.save("UserSignature");
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.ejSignature1.Instance.clear();
		}

		private void buttonRedo_Click(object sender, EventArgs e)
		{
			this.ejSignature1.Instance.redo();
		}

		private void buttonUndo_Click(object sender, EventArgs e)
		{
			this.ejSignature1.Instance.undo();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSignature1.Options.saveWithBackground = this.checkBox1.Checked;
			this.ejSignature1.Options.showRoundedCorner = this.checkBox2.Checked;

			this.ejSignature1.Update();
		}
	}
}