using System.ComponentModel;
using System.Drawing;
using Wisej.Base;
using Wisej.Web;

namespace Wisej.DemoBrowser.DataGridView
{
	public class DataGridViewProgressBarColumn : DataGridViewColumn
	{
		public DataGridViewProgressBarColumn()
			: base(new DataGridViewProgressBarCell())
		{
			this.Editor = new DataGridViewTrackBarEditor()
			{
				Maximum = 100
			};
		}
	}
}