using System;
using Wisej.Web;
using Wisej.DemoBrowser.Common;
namespace Wisej.DemoBrowser.Shape
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void Features_Load(object sender, EventArgs e)
        {

            //Fill Style ComboBoxes
            cmbBorderTopStyle.DataSource = Enum.GetNames(typeof(LineStyle));
            cmbBorderRightStyle.DataSource = Enum.GetNames(typeof(LineStyle));
            cmbBorderBottomStyle.DataSource = Enum.GetNames(typeof(LineStyle));
            cmbBorderLeftStyle.DataSource = Enum.GetNames(typeof(LineStyle));

            cmbBorderTopStyle.SelectedIndex = 1;
            cmbBorderRightStyle.SelectedIndex = 1;
            cmbBorderBottomStyle.SelectedIndex = 1;
            cmbBorderLeftStyle.SelectedIndex = 1;

            //Size NumericUpDowns
            nudBorderTopSize.Value = this.shape1.BorderStyleTop.Size;
            nudBorderRightSize.Value = this.shape1.BorderStyleRight.Size;
            nudBorderBottomSize.Value = this.shape1.BorderStyleBottom.Size;
            nudBorderLeftSize.Value = this.shape1.BorderStyleLeft.Size;

            //Radius NumericUpDowns
            nudBorderTopRadius.Value = this.shape1.BorderStyleTop.Radius;
            nudBorderRightRadius.Value = this.shape1.BorderStyleRight.Radius;
            nudBorderBottomRadius.Value = this.shape1.BorderStyleBottom.Radius;
            nudBorderLeftRadius.Value = this.shape1.BorderStyleLeft.Radius;

            //Buttons BackColors
            btnBorderTopColor.BackColor = this.shape1.BorderStyleTop.Color;
            btnBorderRightColor.BackColor = this.shape1.BorderStyleRight.Color;
            btnBorderBottomColor.BackColor = this.shape1.BorderStyleBottom.Color;
            btnBorderLeftColor.BackColor = this.shape1.BorderStyleLeft.Color;
        }

        private void ApplySize(NumericUpDown control)
        {
            switch (control.Name)
            {
                case "nudBorderTopSize":
                    {
                        this.shape1.BorderStyleTop.Size = (int)control.Value;
                        break;
                    }
                case "nudBorderRightSize":
                    {
                        this.shape1.BorderStyleRight.Size = (int)control.Value;
                        break;
                    }
                case "nudBorderBottomSize":
                    {
                        this.shape1.BorderStyleBottom.Size = (int)control.Value;
                        break;
                    }
                case "nudBorderLeftSize":
                    {
                        this.shape1.BorderStyleLeft.Size = (int)control.Value;
                        break;
                    }
                default: break;
            }
        }

        private void ApplyRadius(NumericUpDown control)
        {
            switch (control.Name)
            {
                case "nudBorderTopRadius":
                    {
                        this.shape1.BorderStyleTop.Radius = (int)control.Value;
                        break;
                    }
                case "nudBorderRightRadius":
                    {
                        this.shape1.BorderStyleRight.Radius = (int)control.Value;
                        break;
                    }
                case "nudBorderBottomRadius":
                    {
                        this.shape1.BorderStyleBottom.Radius = (int)control.Value;
                        break;
                    }
                case "nudBorderLeftRadius":
                    {
                        this.shape1.BorderStyleLeft.Radius = (int)control.Value;
                        break;
                    }
                default: break;
            }
        }

        private void ApplyStyle(ComboBox control)
        {
            switch (control.Name)
            {
                case "cmbBorderTopStyle":
                    {
                        this.shape1.BorderStyleTop.Style = (LineStyle)Enum.Parse(typeof(LineStyle),control.SelectedIndex.ToString());
                        break;
                    }
                case "cmbBorderRightStyle":
                    {
                        this.shape1.BorderStyleRight.Style = (LineStyle)Enum.Parse(typeof(LineStyle), control.SelectedIndex.ToString());
                        break;
                    }
                case "cmbBorderBottomStyle":
                    {
                        this.shape1.BorderStyleBottom.Style = (LineStyle)Enum.Parse(typeof(LineStyle), control.SelectedIndex.ToString());
                        break;
                    }
                case "cmbBorderLeftStyle":
                    {
                        this.shape1.BorderStyleLeft.Style = (LineStyle)Enum.Parse(typeof(LineStyle), control.SelectedIndex.ToString());
                        break;
                    }
                default: break;
            }
        }

        private void ApplyColor(Button control)
        {
            using(ColorDialog colorDialog = new ColorDialog())
            {
                if(colorDialog.ShowDialog() == DialogResult.OK)
                {

                    switch (control.Name)
                    {
                        case "btnBorderTopColor":
                            {
                                this.shape1.BorderStyleTop.Color = colorDialog.Color;
                                control.BackColor = colorDialog.Color;
                                break;
                            }
                        case "btnBorderRightColor":
                            {
                                this.shape1.BorderStyleRight.Color = colorDialog.Color;
                                control.BackColor = colorDialog.Color;
                                break;
                            }
                        case "btnBorderBottomColor":
                            {
                                this.shape1.BorderStyleBottom.Color = colorDialog.Color;
                                control.BackColor = colorDialog.Color;
                                break;
                            }
                        case "btnBorderLeftColor":
                            {
                                this.shape1.BorderStyleLeft.Color = colorDialog.Color;
                                control.BackColor = colorDialog.Color;
                                break;
                            }
                        default: break;
                    }

                }
                

            }
        }

        private void Style_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyStyle((ComboBox)sender);
        }

        private void Size_ValueChanged(object sender, EventArgs e)
        {
            ApplySize((NumericUpDown)sender);
        }

        private void Radius_ValueChanged(object sender, EventArgs e)
        {
            ApplyRadius((NumericUpDown)sender);
        }

        private void ChangeColor_Clicked(object sender, EventArgs e)
        {
            ApplyColor((Button)sender);
        }
    }
}
