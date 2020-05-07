using System;

namespace DellRainInventorySystem.Classes.Utility
{
    public class Dates
    {
        public static string MondayDate { get; set; }
        public static string SundayDate { get; set; }

        public static void WeekDates()
        {
            DayOfWeek Day = DateTime.Now.DayOfWeek;

            //Week Start Day
            int Days = Day - DayOfWeek.Monday;

            //this is the date of monday of the current week
            DateTime weekStartDate = DateTime.Now.AddDays(-Days);

            //this is the date of sunday of the current week
            DateTime weekEndDate6 = weekStartDate.AddDays(6);

            MondayDate = weekStartDate.ToShortDateString();
            SundayDate = weekEndDate6.ToShortDateString();
        }
    }
}