using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using Wisej.Web;
using PaintValueEventArgs = Wisej.Web.PaintValueEventArgs;
using UITypeEditor = Wisej.Web.UITypeEditor;
using UITypeEditorEditStyle = Wisej.Web.UITypeEditorEditStyle;

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
