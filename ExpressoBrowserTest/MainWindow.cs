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
            webKitBrowser1.UserAgent = ExpressoAgent.GetUserAgent();

            linkLabel1.Text = ExpressoAgent.GetUserAgent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webKitBrowser1.Navigate("http://www.whatsmybrowser.com/");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("https://github.com/ExpressoBrowser/ExpressoBrowser/wiki");
        }

        private void sunSpiderBenchmarkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("http://www.webkit.org/perf/sunspider-0.9.1/sunspider-0.9.1/driver.html");
        }

        private void krakenBenchmarkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("http://krakenbenchmark.mozilla.org/kraken-1.0/driver.html");
        }

        private void v8BenchmarkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("http://v8.googlecode.com/svn/data/benchmarks/v6/run.html");
        }

        private void acid3TestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("http://acid3.acidtests.org/");
        }

        private void hTML5SpeedReadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("http://ie.microsoft.com/testdrive/Performance/SpeedReading/Default.html");
        }

        private void hardwareAccelerationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("http://ie.microsoft.com/testdrive/Graphics/GraphicsAccelebration/Default.html");
        }
    }
}
