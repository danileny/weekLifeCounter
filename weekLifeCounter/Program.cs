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
            Console.Write("Введите год рождения: ");
            int birthYear = int.Parse(Console.ReadLine());

            DateTime thisDay = DateTime.Now;
            int thisYear = Convert.ToInt32(thisDay.ToString("yyyy"));

            for (int i = birthYear; i < thisYear; i++)
            {
                Console.Write($"{i} Год\t");
                for (int k = 1; k <= 52; k++)
                {
                    Console.Write($"#{k} ");                    
                }
                Console.WriteLine();
                
            }



            Console.WriteLine("Год рождения: " + birthYear);
            Console.WriteLine("Текущий год: " + thisYear);
            Console.WriteLine("Тебе сейчас " + (thisYear - birthYear));
            
            

            Console.ReadKey();

            //System.Threading.Thread.Sleep(300);



        }
    }
}



