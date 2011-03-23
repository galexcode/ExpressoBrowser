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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ExpressoBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Code to apply the Aero effect to the Window.
        /// Set all the four value -1 to apply glass effect to the whole window
        /// Set custom value to make specific part of the window glassy
        /// Catch is a workaround for now until a proper system has been put in place
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                {
                    AeroGlass.WindowsAero margins = new AeroGlass.WindowsAero();
                    margins.cxLeftWidth = -1;
                    margins.cxRightWidth = -1;
                    margins.cyTopHeight = -1;
                    margins.cyButtomheight = -1;

                    IntPtr hwnd = this.Handle;
                    int result = AeroGlass.DwmExtendFrameIntoClientArea(hwnd, ref margins);
                    this.BackColor = System.Drawing.Color.WhiteSmoke;
                }
            }
            catch (System.Exception)
            {
                // Do Nothing
            }
        }
    }
}
