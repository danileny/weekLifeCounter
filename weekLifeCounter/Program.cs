using System;
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
            Console.WriteLine("Введите год рождения");
            int birthYear = int.Parse(Console.ReadLine());

            DateTime thisDay = DateTime.Now;
            int thisYear = Convert.ToInt32(thisDay.ToString("yyyy"));

            Console.WriteLine("Год рождения: " + birthYear);
            Console.WriteLine("Текущий год: " + thisYear);
            Console.WriteLine("Тебе сейчас " + (thisYear - birthYear));           

            Console.WriteLine();

            
            Console.ReadKey();

            //    System.Threading.Thread.Sleep(300);



        }
    }
}
