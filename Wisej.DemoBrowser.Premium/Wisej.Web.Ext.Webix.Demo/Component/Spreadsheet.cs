using System;
using System.Runtime.CompilerServices;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
    public partial class Spreadsheet : ViewBase
    {
        public Spreadsheet()
        {
            InitializeComponent();
        }

        private void Spreadsheet_Load(object sender, EventArgs e)
        {
            this.spreadsheet1.Options.data = new
            {
                styles = new dynamic[]
                {
                    new[]
                    {
                        new[]{ "top", "#FFEFEF;#6E6EFF;center;'PT Sans', Tahoma;17px;" },
                        new[]{ "subtop", "#818181;#EAEAEA;center;'PT Sans', Tahoma;15px;;;bold;;;"},
                        new[]{ "sales", "#818181;;center;'PT Sans', Tahoma;15px;;;bold;;;" },
                        new[]{ "total", "#818181;;right;'PT Sans', Tahoma;15px;;;bold;;;"},
                        new[]{ "count", "#818181;#EAEAEA;center;'PT Sans', Tahoma;15px;;;;;;"},
                        new[]{ "calc-top", "#818181;#EAEAEA;;'PT Sans', Tahoma;15px;;;bold;;;"},
                        new[]{ "calc-other", "#818181;#EAEAEA;;'PT Sans', Tahoma;15px;;;bold;;;"},
                        new[]{ "values", "#000;#fff;right;'PT Sans', Tahoma;15px;;;;;;;price"},
                    }
                },
                sizes = new dynamic[]
                {
                    new[]
                    {
                        new[]{ 0, 1, 125 },
                        new[]{ 0, 3, 137 },
                        new[]{ 0, 4, 137 },
                        new[]{ 0, 5, 137 },
                    }
                },
                data = new dynamic[]
                {
                    new dynamic[]
                    {
                        new dynamic[]{ 1, 1, "Report - July 2016", "top" },
                        new dynamic[]{ 2, 1, "Region", "subtop"},
                        new dynamic[]{ 2, 2, "Country", "subtop" },
                        new dynamic[]{ 2, 3, "Sales - Group A", "sales"},
                        new dynamic[]{ 2, 4, "Sales - Group B", "sales"},
                        new dynamic[]{ 2, 5, "Total", "total"},
                        new dynamic[]{ 3, 1, "Europe", "count"},
                        new dynamic[]{ 3, 2, "Germany", "count"},
                        new dynamic[]{ 3, 3, "188400", "values"},
                        new dynamic[]{ 3, 4, "52000", "values"},
                        new dynamic[]{ 3, 5, "=C3+D3", "values"},
                        new dynamic[]{ 4, 1, "Europe", "count"},
                        new dynamic[]{ 4, 2, "France", "count"},
                        new dynamic[]{4, 3, "192200", "values"},
                        new dynamic[]{4, 4, "12000", "values"},
                        new dynamic[]{4, 5, "=C4+D4", "values"},
                        new dynamic[]{5, 1, "Europe", "count"},
                        new dynamic[]{5, 2, "Poland", "count"},
                        new dynamic[]{5, 3, "68900", "values"},
                        new dynamic[]{5, 4, "8000", "values"},
                        new dynamic[]{5, 5, "=C5+D5", "values"},
                        new dynamic[]{6, 1, "Asia", "count"},
                        new dynamic[]{6, 2, "Japan", "count"},
                        new dynamic[]{6, 3, "140000", "values"},
                        new dynamic[]{6, 4, "14000", "values"},
                        new dynamic[]{6, 5, "=C6+D6", "values"},
                        new dynamic[]{7, 1, "Asia", "count"},
                        new dynamic[]{7, 2, "China", "count"},
                        new dynamic[]{7, 3, "50000", "values"},
                        new dynamic[]{7, 4, "4800", "values"},
                        new dynamic[]{7, 5, "=C7+D7", "values"},
                    }
                    
                },
                span = new[]
                {
                    new[]{1,1,5,1}
                }
            };
        }
    }
}
