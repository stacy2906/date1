using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    internal class DateClass
    {
        DateTime date;

        public DateClass()
        {
        }

        public DateClass(int year, int month, int day)
        {
            date = new DateTime(year, month, day);
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public DateTime PrevDay()
        {
            return date.AddDays(-1);
        }

        public DateTime NextDay()
        {
            return date.Add(TimeSpan.FromDays(1));
        }

        public int DaysLeft()
        {
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }
       

    }
}
