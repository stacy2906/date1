using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateClass dateClass = new DateClass();

            dateClass.PrevDay();
            dateClass.NextDay();
            dateClass.DaysLeft();

            Console.ReadKey();
        }
    }
}
