﻿using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using DataGridViewCellStyle = Wisej.Web.DataGridViewCellStyle;
using DataGridViewContentAlignment = Wisej.Web.DataGridViewContentAlignment;
using DataGridViewRow = Wisej.Web.DataGridViewRow;
using Padding = Wisej.Web.Padding;

namespace Wisej.DemoBrowser.DataGridView
{
    public partial class SummaryRows : DemoView
    {
        public SummaryRows()
        {
            InitializeComponent();
        }

        private void SummaryRows_Load(object sender, EventArgs e)
        {
			FillGroupSummaryGrid();
		}

        private void FillGroupSummaryGrid()
        {
			FillData(1);
			FillData(2);
			FillData(3);
			FillData(4);
			AddAggregations();

			this.dataGridView1.Columns[0].Visible = false;
		}


		private void FillData(int year)
		{
			var grid = this.dataGridView1;

			// add data for year.
			for (var i = 0; i < Items.Length; i++)
			{
				var index = grid.Rows.Add();
				grid[0, index].Value = $"Year {year}";
				grid[1, index].Value = Items[i];

				for (int m = 0; m < 12; m++)
				{
					grid[m + 2, index].Value = Values[m][i];
					grid[m + 2, index].Style = AmountStyle;
				}
			}
		}

		private static string[] Items = { "General Supplies", "Printer Ink", "Paper", "Postage" };

		private static int[][] Values = {
			new []{ 17, 20, 43, 42 },
			new[] { 39, 21, 44, 30 },
			new []{ 55, 8, 9, 65 },
			new[] { 79, 43, 14, 20 },
			new []{ 17, 20, 43, 42 },
			new[] { 39, 21, 44, 30 },
			new []{ 55, 8, 9, 65 },
			new[] { 79, 43, 14, 20 },
			new []{ 17, 20, 43, 42 },
			new[] { 39, 21, 44, 30 },
			new []{ 55, 8, 9, 65 },
			new[] { 79, 43, 14, 20 }
		};

		private void AddAggregations()
		{
			// sum all expenses grouped by quarter (column 0)
			DataGridViewRow[] totals = null;
			var grid = this.dataGridView1;
			for (var m = 0; m < 12; m++)
				totals = grid.AddSummaryRows(SummaryType.Sum, SummaryRowPosition.Above, grid.Columns[0], grid.Columns[m + 2], TotalStyle);

			// add total label and group headers
			foreach (var t in totals)
			{
				t[1].Value = "Office Supplies";
				t[1].Style = TotalTitleStyle;

				grid.Rows.Insert(t.Index);
				grid.Rows.Insert(t.Index);
				grid.Rows.Insert(t.Index);

				// Year label.
				var quarter = grid.Rows[t.Index - 3];
				quarter[2].Value = t[0].Value;
				quarter[2].Style = YearStyle;
				t[0].Value = null;

				// Quarter label
				var quarters = grid.Rows[t.Index - 2];
				for (var q = 0; q < 4; q++)
				{
					quarters[(q * 3) + 2].Value = $"Quarter {q + 1}";
					quarters[(q * 3) + 2].Style = q % 2 == 0 ? QuarterStyle1 : QuarterStyle2;
				}

				// Month label
				var months = grid.Rows[t.Index - 1];
				var monthNames = DateTimeFormatInfo.CurrentInfo.AbbreviatedMonthNames;
				for (var m = 0; m < 12; m++)
				{
					months[m + 2].Value = monthNames[m].ToUpper();
					months[m + 2].Style = MonthStyle;
				}
			}
		}

		private static DataGridViewCellStyle AmountStyle = new DataGridViewCellStyle()
		{
			Format = "C0",
			Alignment = DataGridViewContentAlignment.MiddleRight
		};

		private static DataGridViewCellStyle TotalStyle = new DataGridViewCellStyle()
		{
			Font = new Font("Helvetica", 12, FontStyle.Bold, GraphicsUnit.Point),
			Alignment = DataGridViewContentAlignment.MiddleRight
		};

		private static DataGridViewCellStyle TotalTitleStyle = new DataGridViewCellStyle()
		{
			Font = new Font("Helvetica", 12, FontStyle.Bold, GraphicsUnit.Point),
			Alignment = DataGridViewContentAlignment.MiddleLeft
		};

		private static DataGridViewCellStyle YearStyle = new DataGridViewCellStyle()
		{
			ColSpan = 12,
			BackColor = Color.FromArgb(241, 166, 0),
			ForeColor = Color.White,
			Padding = new Padding(40, 0, 0, 0),
			CssStyle = "border: 1px solid white"
		};

		private static DataGridViewCellStyle QuarterStyle1 = new DataGridViewCellStyle()
		{
			ColSpan = 3,
			BackColor = Color.FromArgb(244, 178, 30),
			ForeColor = Color.White,
			Padding = new Padding(40, 0, 0, 0),
			CssStyle = "border: 1px solid white"
		};

		private static DataGridViewCellStyle QuarterStyle2 = new DataGridViewCellStyle()
		{
			ColSpan = 3,
			BackColor = Color.FromArgb(247, 191, 59),
			ForeColor = Color.White,
			Padding = new Padding(40, 0, 0, 0),
			CssStyle = "border: 1px solid white"
		};

		private static DataGridViewCellStyle MonthStyle = new DataGridViewCellStyle()
		{
			ForeColor = Color.White,
			BackColor = Color.FromArgb(250, 203, 89),
			Alignment = DataGridViewContentAlignment.MiddleCenter,
			CssStyle = "border: 1px solid white"
		};
	}
}
