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
        /// Color.DarkKhaki sets the form Aero trigger due to a bug in VS2010 where other colors allow click through
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
                    this.BackColor = Color.DarkKhaki;
                }
            }
            catch (System.Exception)
            {
                /// Here we default back to the original color if Aero cannot be enabled.
                /// Such as if the user is running Windows XP or Vista Basic
                this.BackColor = DefaultBackColor;
                navPanel.BackColor = DefaultBackColor;
            }

            this.Load += new EventHandler(MainForm_Load);
            this.browser.Navigated +=
                new WebBrowserNavigatedEventHandler(browser_Navigated);
        }
        
        /// <summary>
        /// Navigate to requested webpage when enter is pressed
        /// We handle the keypress so no sound 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                browser.Navigate(addressBox.Text);
            }
        }

        /// <summary>
        /// This updates the actual webpage location in the addressBox while we navigate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            addressBox.Text = browser.Url.ToString();
        }

        /// <summary>
        /// Updates the title of MainForm to display the webpage name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void browser_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = "ExpressoBrowser - " + browser.DocumentTitle;
        }
    }
}
