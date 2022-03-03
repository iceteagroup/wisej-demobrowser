using System;
using System.Collections.Generic;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using System.Linq;
using Wisej.Web.Ext.Bubbles;

namespace Wisej.DemoBrowser.Bubbles
{
    public partial class Features : DemoView
    {
        private List<Employee> data = Employee.GetEmployees();
        public Features()
        {
            InitializeComponent();
        }

        private void Features_Load(object sender, EventArgs e)
        {
            var data = Employee.GetEmployees();
            dataGridView1.DataSource = data;
            CalculateAverageLeads();

            this.cmbBubblesAlignment.DataSource = Enum.GetNames(typeof(System.Drawing.ContentAlignment));

            this.cmbBubbleStyle.DataSource = Enum.GetNames(typeof(BubbleStyle));

            this.cmbBubblesAlignment.SelectedIndex = 0;
            this.cmbBubbleStyle.SelectedIndex = 0;
        }

        void CalculateAverageLeads()
        {
            int avg = (int)dataGridView1.Rows.Average(r=>(int)r.Cells["Sales"].Value);
            bubbleNotification1.SetBubbleValue(dataGridView1,avg);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateAverageLeads();
        }

        private void cmbBubblesAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.ContentAlignment option;
            Enum.TryParse<System.Drawing.ContentAlignment>(cmbBubblesAlignment.SelectedValue.ToString(), out option);
            bubbleNotification1.Alignment = option;
        }

        private void cmbBubbleStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            BubbleStyle option;
            Enum.TryParse<BubbleStyle>(cmbBubbleStyle.SelectedValue.ToString(), out option);
            bubbleNotification1.SetBubbleStyle(dataGridView1, option);
        }
    }
}
