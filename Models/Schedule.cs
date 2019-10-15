﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gride.Models
{
    public class Schedule
    {
        //public static DateTime now = DateTime.Now;
        //public static int delta = DayOfWeek.Monday - now.DayOfWeek;
        //public DateTime monday = now.AddDays(delta);

        //@Html.IdFor(m => m.User.Surname) handig voor later om id van html te bepalen
        public string monday;
        public string tuesday;
        public string wednesday;
        public string thursday;
        public string friday;
        public string saturday;
        public string sunday;
        public static DateTime now = DateTime.Now;
        public int showingWeekNumber = now.DayOfYear / 7 + 1;
        public Shift[][] week = new Shift[7][];
        public int weekNumber = now.DayOfYear / 7 + 1;



        public void setWeek(int weeks)
        {

            int x = (weeks - weekNumber) * 7;
            DateTime now = DateTime.Now;
            int delta = DayOfWeek.Monday - now.DayOfWeek + x;
            monday = now.AddDays(delta).ToString("dd");
            tuesday = now.AddDays(delta + 1).ToString("dd");
            wednesday = now.AddDays(delta + 2).ToString("dd");
            thursday = now.AddDays(delta + 3).ToString("dd");
            friday = now.AddDays(delta + 4).ToString("dd");
            saturday = now.AddDays(delta + 5).ToString("dd");
            sunday = now.AddDays(delta + 6).ToString("dd");
            

        }
     
    public void setShifts()
        {
            week[0] = new Shift[24];
            week[1] = new Shift[24];
            week[2] = new Shift[24];
            week[3] = new Shift[24];
            week[4] = new Shift[24];
            week[5] = new Shift[24];
            week[6] = new Shift[24];
        }


    }
}
