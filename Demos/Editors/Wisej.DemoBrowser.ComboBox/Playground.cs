using System;
using Wisej.Web;
using Wisej.DemoBrowser.Common;
using System.ComponentModel;

namespace Wisej.DemoBrowser.ComboBox.Views
{
    [CustomName("Playground")]
    [AddToTreeView(true)]
    [Description("Explore the capabilities that Wisej controls offer, by trying out different things in real time")]
    [ImageSource("resource.wx/Wisej.Ext.VisualStudioIcons/3DScene.svg")]
    public partial class Playground : DemoView
    {
        public Playground()
        {
            InitializeComponent();
        }

        private void FillComboBoxes()
        {
            var dropDownStyles = Enum.GetNames(typeof(ComboBoxStyle));
            var autoCompleteMode = Enum.GetNames(typeof(AutoCompleteMode));

            this.cmbDropDownStyle.DataSource = dropDownStyles;
            this.cmbAutoCompleteMode.DataSource = autoCompleteMode;

            for (int i = 0; i < 25; i++)
            {
                this.comboBox1.Items.Add($"Item N°{i}");
            }
        }
        private void Playground_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
            this.comboBox1.DropDownStyle = (ComboBoxStyle)this.cmbDropDownStyle.SelectedIndex;
            this.comboBox1.AutoCompleteMode = (AutoCompleteMode)this.cmbAutoCompleteMode.SelectedIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.comboBox1.DropDownStyle = (ComboBoxStyle)this.cmbDropDownStyle.SelectedIndex;
            this.comboBox1.AutoCompleteMode = (AutoCompleteMode)this.cmbAutoCompleteMode.SelectedIndex;
            this.comboBox1.Sorted = this.chkSorting.Checked;
            this.comboBox1.VirtualScroll = this.chkVirtualMode.Checked;
            this.comboBox1.IncrementalSelection = this.chkIncrementalSearch.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add($"Item N°{this.comboBox1.Items.Count + 1}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
        }
    }
}
