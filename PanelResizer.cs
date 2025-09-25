using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaParcial2OctavioGonzalez
{
    internal class PanelResizer
    {
        private Panel panel;
        private int gripSize;

        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        private const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public PanelResizer(Panel panel, int gripSize = 10)
        {
            this.panel = panel;
            this.gripSize = gripSize;

            panel.MouseMove += Panel_MouseMove;
            panel.MouseDown += Panel_MouseDown;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            int w = panel.Width;
            int h = panel.Height;

            if (e.X <= gripSize && e.Y <= gripSize)
                panel.Cursor = Cursors.SizeNWSE;
            else if (e.X >= w - gripSize && e.Y <= gripSize)
                panel.Cursor = Cursors.SizeNESW;
            else if (e.X <= gripSize && e.Y >= h - gripSize)
                panel.Cursor = Cursors.SizeNESW;
            else if (e.X >= w - gripSize && e.Y >= h - gripSize)
                panel.Cursor = Cursors.SizeNWSE;
            else if (e.X <= gripSize || e.X >= w - gripSize)
                panel.Cursor = Cursors.SizeWE;
            else if (e.Y <= gripSize || e.Y >= h - gripSize)
                panel.Cursor = Cursors.SizeNS;
            else
                panel.Cursor = Cursors.Default;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Form form = panel.FindForm();
            if (form == null) return;

            int w = panel.Width;
            int h = panel.Height;
            int ht = 0;

            if (e.X <= gripSize && e.Y <= gripSize)
                ht = HTTOPLEFT;
            else if (e.X >= w - gripSize && e.Y <= gripSize)
                ht = HTTOPRIGHT;
            else if (e.X <= gripSize && e.Y >= h - gripSize)
                ht = HTBOTTOMLEFT;
            else if (e.X >= w - gripSize && e.Y >= h - gripSize)
                ht = HTBOTTOMRIGHT;
            else if (e.X <= gripSize)
                ht = HTLEFT;
            else if (e.X >= w - gripSize)
                ht = HTRIGHT;
            else if (e.Y <= gripSize)
                ht = HTTOP;
            else if (e.Y >= h - gripSize)
                ht = HTBOTTOM;

            if (ht != 0)
            {
                ReleaseCapture();
                SendMessage(form.Handle, WM_NCLBUTTONDOWN, ht, 0);
            }
        }
    }
}