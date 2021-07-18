using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VatsimATCHelper
{
    public partial class Main : Form
    {
        #region Aero Shadow
        private bool aeroEnabled;

        protected override CreateParams CreateParams
        {
            get
            {
                CheckAeroEnabled();
                var cp = base.CreateParams;

                if (!aeroEnabled)
                {
                    cp.ClassStyle = cp.ClassStyle | WIN32APIConstants.CS_DROPSHADOW;
                    return cp;
                }
                else
                {
                    return cp;
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WIN32APIConstants.WM_NCPAINT:
                    if (aeroEnabled)
                    {
                        var var = 2;
                        WIN32APIMethods.DwmSetWindowAttribute(Handle, 2, ref var, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        WIN32APIMethods.DwmExtendFrameIntoClientArea(Handle, ref margins);
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                int response = WIN32APIMethods.DwmIsCompositionEnabled(ref enabled);
                aeroEnabled = (enabled == 1) ? true : false;
            }
            else
            {
                aeroEnabled = false;
            }
        }
        #endregion

        public Main(object data)
        {
            InitializeComponent();
        }


        #region Label Move
        private Point mousePoint;
        private void upperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void upperPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
        #endregion
    }

    #region Aero Shadow Classes
    public class WIN32APIConstants
    {
        public const int CS_DROPSHADOW = 0x00020000;
        public const int WM_NCPAINT = 0x0085;
    }
    public class WIN32APIMethods
    {
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
    }
    public struct MARGINS
    {
        public int leftWidth;
        public int rightWidth;
        public int topHeight;
        public int bottomHeight;
    }
    #endregion

}

