using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekLifeCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год рождения: ");
            int birthYear = int.Parse(Console.ReadLine());

            DateTime thisDay = DateTime.Now;
            int thisYear = Convert.ToInt32(thisDay.ToString("yyyy"));

            int lifeEndYear = birthYear + 80;

            // Get week num
            CultureInfo myCI = new CultureInfo("ru-RU");
            Calendar myCal = myCI.Calendar;

            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            int weekNum = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW);

            for (int i = birthYear; i < lifeEndYear; i++)
            {
                Console.Write($"{i} Год\t");
                for (int k = 1; k <= 52; k++)
                {
                    
                    if (i < thisYear || k > weekNum )
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("O ");
                    }
                }
                Console.WriteLine();
                
            }



            Console.WriteLine("Год рождения:\t " + birthYear);
            Console.WriteLine("Текущий год:\t " + thisYear);
            Console.WriteLine("Тебе сейчас:\t " + (thisYear - birthYear));
            Console.WriteLine("Дата смерти:\t " + lifeEndYear);
            Console.WriteLine("Неделя в году:\t " + weekNum);



            Console.ReadKey();

            //System.Threading.Thread.Sleep(300);



        }
    }
}



