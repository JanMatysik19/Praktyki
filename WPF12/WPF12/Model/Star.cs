﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF12.Model
{
    internal class Star
    {
        public Point Location { get; set; }

        public Star(Point location)
        {
            Location = location;
        }
    }
}
