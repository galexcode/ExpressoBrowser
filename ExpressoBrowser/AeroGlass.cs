/*
 * Copyright (C) 2011 ExpressoBrowser <https://github.com/ExpressoBrowser/>
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
 */

using System;
using System.Runtime.InteropServices;

namespace ExpressoBrowser
{
    public class AeroGlass
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

        [DllImport("dwmapi.dll", PreserveSig = false)]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref WindowsAero pMarinset);

        [DllImport("dwmapi.dll", PreserveSig = false)]
        public static extern bool DwmIsCompositionEnabled();
    }
}
