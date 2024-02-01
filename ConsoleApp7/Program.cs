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
           Console.WriteLine("Введите год, месяц и день (через пробел):");

            string[] input = Console.ReadLine().Split(' ');
            int year = int.Parse(input[0]);
            int month = int.Parse(input[1]);
            int day = int.Parse(input[2]);

            DateClass date = new DateClass();

            Console.WriteLine("Предыдущий день: " + date.GetPreviousDay());
            Console.WriteLine("Следующий день: " + date.GetNextDay());
            Console.WriteLine("Дней до конца месяца: " + date.GetDaysUntilEndOfMonth());

            //Задание 2
            Console.WriteLine("Введите первую дату (год, месяц, день через пробел):");

            input = Console.ReadLine().Split(' ');
            DateTime firstDate = new DateTime(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]));

            Console.WriteLine("Введите вторую дату (год, месяц, день через пробел):");
            input = Console.ReadLine().Split(' ');
            DateTime secondDate = new DateTime(int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]));

            TimeSpan difference = secondDate - firstDate;
            Console.WriteLine("Количество дней между датами: " + difference.Days);

            //Задание 3
            Console.WriteLine("Введите время начала первой процедуры (часы и минуты через пробел):");
            input = Console.ReadLine().Split(' ');
            int startHour = int.Parse(input[0]);
            int startMinute = int.Parse(input[1]);

            Console.WriteLine("Введите время начала следующей процедуры (часы и минуты через пробел):");
            input = Console.ReadLine().Split(' ');
            int nextStartHour = int.Parse(input[0]);
            int nextStartMinute = int.Parse(input[1]);

            Console.WriteLine("Введите общее количество назначенных процедур:");
            int totalCount = int.Parse(Console.ReadLine());

            TimeSpan timeBetweenProcedures = new TimeSpan(0, nextStartHour - startHour, nextStartMinute - startMinute);

            DateTime currentTime = new DateTime(2024, 02, 01, startHour, startMinute, 0);
            Console.WriteLine("Время проведения процедур:");
            for (int i = 0; i < totalCount; i++)
            {
                Console.WriteLine(currentTime);
                currentTime += timeBetweenProcedures;
            }
            Console.ReadKey();

        }
    }
}
