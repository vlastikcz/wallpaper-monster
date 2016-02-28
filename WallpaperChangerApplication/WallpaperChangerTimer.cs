﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WallpaperMonsterApplication
{
    class WallpaperChangerTimer
    {
        private const Double MILLISECONDS_IN_A_HOUR = 3600000;

        private WallpaperChangerService wallpaperChangerService;
        private Timer timer;

        public WallpaperChangerTimer(WallpaperChangerService wallpaperChangerService) {
            this.wallpaperChangerService = wallpaperChangerService;
            timer = new Timer();
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        }

        public void ChangeTimerPeriod(Double period) {
            timer.Enabled = period > 0;
            if (timer.Enabled) { 
                timer.Interval = period * MILLISECONDS_IN_A_HOUR;
            }
        }        

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            wallpaperChangerService.DoChange();
        }
    }
}
