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
         private DateTime data;

        public DateClass()
        {
            data = DateTime.Now;
        }

        public DateClass(int year, int month, int day)
        {
            data = new DateTime(year, month, day);
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public DateTime GetPreviousDay()
        {
            return data.AddDays(-1);
        }

        public DateTime GetNextDay()
        {
            return data.AddDays(1);
        }

        public int GetDaysUntilEndOfMonth()
        {
            DateTime endOfMonth = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));
            return (endOfMonth - data).Days;
        }

    }
}
