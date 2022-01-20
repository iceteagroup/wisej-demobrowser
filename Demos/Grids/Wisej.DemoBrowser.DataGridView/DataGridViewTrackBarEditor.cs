using System;
using Wisej.Web;

namespace Wisej.DemoBrowser.DataGridView
{
	public class DataGridViewTrackBarEditor : TrackBar, IDataGridViewEditingControl
	{
		public Wisej.Web.DataGridView DataGridView { get; set; }

		public bool Invalid
		{
			get { return false; }
		}

		public void ApplyCellStyleToEditingControl(DataGridViewCellStyle style)
		{
		}

		public string GetEditingControlFormattedValue()
		{
			return this.Value.ToString();
		}

		public void PrepareEditingControlForEdit(bool selectAll)
		{
			this.Value = Convert.ToInt32(this.DataGridView.CurrentCell.Value);
		}
	}
}