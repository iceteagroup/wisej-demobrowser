using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisej.Web;

namespace Wisej.DemoBrowser.PropertyGrid
{
    public class ColorPicker : UITypeEditor
    {
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = (System.Drawing.Color)value;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    value = dlg.Color;
                }
            }
            return value;
        }
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override bool GetPaintValueSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override void PaintValue(PaintValueEventArgs e)
        {
            if (e.Value is Color color)
            {
                using (var brush = new SolidBrush(color))
                    e.Graphics.FillRectangle(brush, e.Bounds);
            }
        }
    }
}
