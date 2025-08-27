using System;
using System.Drawing;
using System.ComponentModel;
using Wisej.Web;
using Wisej.DemoBrowser.Common;

namespace Wisej.DemoBrowser.ListView.Components
{
	/// <summary>
	/// Zusammenfassung für ReadOnlyRichTextBox.
	/// </summary>
	[AddToTreeView(false)]
	public class ReadOnlyRichTextBox : TextBox   // TextBox  RichTextBox
	{
		
		public ReadOnlyRichTextBox()
		{
			ReadOnly=true;
			TabStop=false;

			SetStyle(ControlStyles.Selectable, false);
		}

		// Font is overridden because assigning the RichTextBox to a new parent sets
		// its Font to the parent's Font and thus loses all formatting of existing RTF content.
		protected Font _font = new Font("Arial", 10);
		public override Font Font
		{
			get 
			{
				return _font;
			}
			set 
			{
				_font = value;
			}
		}

		[ Browsable(false) ]
		public new bool ReadOnly
		{
			get { return true; }
			set { }
		}
		
		[ Browsable(false) ]
		public new bool TabStop
		{
			get { return false; }
			set {  }
		}

		const int WM_SETFOCUS = 0x0007;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case WM_SETFOCUS:
                    // We don't want the RichTextBox to be able to receive focus, so just
                    // pass the focus back to the control it came from.
                    IntPtr prevCtl = m.WParam;
                    Control c = Control.FromHandle(prevCtl);
                    c.Select();
                    return;
            }
            base.WndProc(ref m);
        }
    }
}
