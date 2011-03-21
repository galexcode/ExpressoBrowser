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

namespace ExpressoBrowser
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            this.browser.Navigated +=
                new WebBrowserNavigatedEventHandler(browser_Navigated);

            this.urlTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
        }

        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed
                e.Handled = true;
                browser.Navigate(urlTextBox.Text);
            }
        }

        void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlTextBox.Text = browser.Url.ToString();
        }
    }
}
