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
            this.nudShapeRadius.Value = this.shape1.BorderStyle.Radius;
            this.nudShapeRotation.Value = this.shape1.Rotation;
            this.nudShapeSize.Value = this.shape1.BorderStyle.Size;
            this.btnShapeColor.BackColor = this.shape1.BorderStyle.Color;

            this.cmbShapeStyle.DataSource = Enum.GetNames(typeof(LineStyle));
            this.cmbShapeStyle.SelectedIndex = 1;
        }

        private void nudShapeRotation_ValueChanged(object sender, EventArgs e)
        {
            this.shape1.Rotation = (int)nudShapeRotation.Value;
        }

        private void nudShapeSize_ValueChanged(object sender, EventArgs e)
        {
            this.shape1.BorderStyle.Size = (int)nudShapeSize.Value;
        }

        private void nudShapeRadius_ValueChanged(object sender, EventArgs e)
        {
            this.shape1.BorderStyle.Radius = (int)nudShapeRadius.Value;
        }

        private void cmbShapeStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.shape1.BorderStyle.Style = (LineStyle)Enum.Parse(typeof(LineStyle),cmbShapeStyle.Text);
        }

        private void btnShapeColor_Click(object sender, EventArgs e)
        {
            using(ColorDialog colorDialog = new ColorDialog())
            {
                
                if(colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.btnShapeColor.BackColor = colorDialog.Color;
                    this.shape1.BorderStyle.Color = colorDialog.Color;
                }
            }
        }

        private void btnShapeBackColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.btnShapeBackColor.BackColor = colorDialog.Color;
                    this.shape1.BackColor = colorDialog.Color;
                }
            }
        }
    }
}
