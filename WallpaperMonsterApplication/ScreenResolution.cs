﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallpaperMonsterApplication
{
    class ScreenResolution
    {
        public static Rectangle findScreenResolution(Form settingsForm) {
            return Screen.FromControl(settingsForm).WorkingArea;
        }
    }
}
