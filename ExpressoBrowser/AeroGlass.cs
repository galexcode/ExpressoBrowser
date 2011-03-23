using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ExpressoBrowser
{
    class AeroGlass
    {
        /// <summary>
        /// Code for Windows Aero effects on the Window
        /// Need to change the Aero tigger colour so black items arn't affected
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]

        public struct WindowsAero
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyButtomheight;
        }

        [DllImport("dwmapi.dll")]

        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref WindowsAero pMarinset);
    }
}
