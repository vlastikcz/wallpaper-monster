﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallpaperChangerApplication
{
    class ScreenResolution
    {
        public static Rectangle findScreenResolution(Form myForm) {
            return Screen.FromControl(myForm).WorkingArea;
        }
    }
}