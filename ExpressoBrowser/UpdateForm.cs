﻿/*
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
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace ExpressoBrowser
{
    public partial class UpdateForm : Form
    {
        string versionURL = "https://github.com/ExpressoBrowser/ExpressoBrowser/raw/master/update/version.txt";
        string result = null;

        public UpdateForm()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;
            this.Hide();
        }

        public void UpdateForm_Load(object sender, EventArgs e)
        {
            updateThread.RunWorkerAsync();
        }

        /// <summary>
        /// Here the update check is performed
        /// Simply reads from a text file over the web and compaires the result
        /// If results match nothing happens, if results differ it prompts user to download the update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateThread_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                result = client.DownloadString(versionURL);

                if (result.Contains("ExpressoBrowser_v1.0"))
                {
                    // Do nothing
                    this.Close();
                }
                else
                {
                    DialogResult updateResult = MessageBox.Show("A update for ExpressoBrowser is avaliable! Would you like to downlo ad the latest version?", "Update Avaliable!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (updateResult == DialogResult.Yes)
                    {
                        Application.Exit();
                        Process.Start("https://github.com/ExpressoBrowser/ExpressoBrowser/raw/master/update/update.exe");
                    }
                    else if (updateResult == DialogResult.No)
                    {
                        // Do nothing
                        this.Close();
                    }
                }
            }
            catch
            {
                // Do nothing
                // Stops any errors is user is not connected to the internet
                this.Close();
            }
        }
    }
}
