﻿using Rectify11.COM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectify11
{
    public class ShellNamespacePage : UserControl
    {
        public IShellBrowser Browser;
        public virtual void Display() { }
    }
}
