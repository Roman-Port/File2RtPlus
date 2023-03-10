using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File2RtPlus.Gui
{
    class RichTextLabel : RichTextBox
    {
        //https://stackoverflow.com/questions/582312/how-to-hide-the-caret-in-a-richtextbox
        public RichTextLabel()
        {
            base.ReadOnly = true;
            base.TabStop = false;
            base.SetStyle(ControlStyles.Selectable, false);
            base.SetStyle(ControlStyles.UserMouse, true);
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            base.MouseEnter += delegate (object sender, EventArgs e)
            {
                this.Cursor = Cursors.Default;
            };
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x204) return; // WM_RBUTTONDOWN
            if (m.Msg == 0x205) return; // WM_RBUTTONUP
            base.WndProc(ref m);
        }
    }
}
