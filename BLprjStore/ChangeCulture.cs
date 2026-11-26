using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection;


namespace BLprjStore
{
    public  class ChangeCulture
    {
        public static void ChangeCulture1()
        {
            CultureInfo c = new CultureInfo("fa-Ir");
            var info = c.DateTimeFormat;

            var p = info.GetType().GetField("calendar", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            p.SetValue(c.DateTimeFormat, new PersianCalendar());

            info.AbbreviatedDayNames = new string[] { "ی", "د", "س", "چ", "پ", "ج", "ش" };
            info.DayNames = new string[] { "یکشنبه", "دوشنبه", "ﺳﻪشنبه", "چهارشنبه", "پنجشنبه", "جمعه", "شنبه" };
            info.AbbreviatedMonthNames = new string[] { "فروردین", "ارديبهشت", "خرداد", "تير", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };
            info.MonthNames = new string[] { "فروردین", "ارديبهشت", "خرداد", "تير", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };
            info.AMDesignator = "ق.ظ";
            info.PMDesignator = "ب.ظ";
            info.ShortDatePattern = "yyyy/MM/dd";
            info.FirstDayOfWeek = DayOfWeek.Saturday;
            info.ShortestDayNames = new string[] { "ی", "د", "س", "چ", "پ", "ج", "ش" };

            System.Threading.Thread.CurrentThread.CurrentCulture = c;
            System.Threading.Thread.CurrentThread.CurrentUICulture = c;
        }
    }
}
