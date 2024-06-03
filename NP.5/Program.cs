using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Vvedit 4islo a:");
            double a = Convert.ToDouble(Console.ReadLine());
            One(a);
            Two(a);
            Three(a);
            Foru(a);
            Five(a);
            Six(a);
            Console.ReadLine();
            
        }
        static void One(double a)
        {
            if (a > 1)
            {
                Console.WriteLine("Число позитивне");
            }
            else if ( a == 0)
            {
                Console.WriteLine("Число 0");
            }
            else
            {
                Console.WriteLine("Число негативне");
            }
        }
        static void Two(double a)
        {
            string str = " ";
            if(a % 2 == 0)
            {
                Console.WriteLine("Число парне");
            }
            else
            {
                Console.WriteLine("Число не парне");
            }
        }
        static void Three(double a)
        {
            string str = "";
            if ( a < 2)
            {
                Console.WriteLine("Число менше 2");
            }
            else
            {
                Console.WriteLine("Число більше 2");
            }
        }
        static void Foru(double a)
        {
            if ( a > 3)
            {
                Console.WriteLine("Число більше 3");
            }
            else
            {
                Console.WriteLine("Число менше 3 ");
            }
        }
        static void Five(double a)
        {
            if (a % 1 == 0)
            {
                Console.WriteLine($"Число {a} ціле");
            }
        }
        static void Six(double a)
        {
            string str = "";
            if (a % 1 != 0)
            {
                Console.WriteLine($"Число {a} не ціле");
            }
        }
    }
}
