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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace ExpressoBrowser
{
    static class ExpressoAgent
    {
        public static string GetUserAgent()
        {
            Version BuildVersion = new Version(Application.ProductVersion);

            // Just for testing purposes - This will change in future
            return "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US) Expresso/" + BuildVersion.Major + "." + BuildVersion.Minor + "." + BuildVersion.MinorRevision + "." + BuildVersion.Revision + " AppleWebKit/533+ (KHTML, like Gecko)";
        }
    }
}
