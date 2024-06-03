using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace NP5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Vvedit 4islo a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedit 4islo b:");
            double b = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < 7; i++)
            {
                form(a, b, i);
            }
            Console.ReadLine();
        }
        static void form(double a, double b,int choice)
        {
            switch(choice)
            {
                case 1:
                    if(a == b)
                    {
                        Console.WriteLine($"Число {a} і {b} однакові");
                    }
                    else if (a > b)
                    {
                        Console.WriteLine($"Число {a} більше за число {b}");
                    }
                    else
                    {
                        Console.WriteLine($"Число {b} більше за число {a}");
                    }
                    break;
                case 2:
                    if (a == b)
                    {
                        Console.WriteLine($"Число {a} і {b} однакові");
                    }
                    else if (a > b)
                    {
                        Console.WriteLine($"Число {a} більше за число {b}");
                    }
                    else
                    {
                        Console.WriteLine($"Число {b} більше за число {a}");
                    }
                    break;

                case 3:
                    if( a % 2 == 0 &&  b % 2 == 0)
                    {
                        Console.WriteLine($"Число {a} і {b} парні");
                    }
                    else if(a % 2 == 0 && b % 2 != 0){
                        Console.WriteLine($"Число {a} парне");
                    }
                    else if(a% 2 != 0 && b % 2 == 0)
                    {
                        Console.WriteLine($"Число{b} парне");
                    }
                    else
                    {
                        Console.WriteLine($"Число {a} і {b} не парні");
                    }
                    break;

                case 4:
                    if (a % 2 == 0 && b % 2 == 0)
                    {
                        Console.WriteLine($"Число {a} і {b} парні");
                    }
                    else if (a % 2 == 0 && b % 2 != 0)
                    {
                        Console.WriteLine($"Число {a} парне");
                    }
                    else if (a % 2 != 0 && b % 2 == 0)
                    {
                        Console.WriteLine($"Число{b} парне");
                    }
                    else
                    {
                        Console.WriteLine($"Число {a} і {b} не парні");
                    }
                    break;
                case 5:
                    if( a % 1 == 0 && b % 1 == 0)
                    {
                        Console.WriteLine($"Число {a} і {b} цілі числа");
                    }
                    else if (a % 1 == 0 && b % 1 != 0)
                    {
                        Console.WriteLine($"Число {a} ціле число");
                    }
                    else if (a % 1 != 0 && b % 1 == 0)
                    {
                        Console.WriteLine($"Число {b} ціле число");
                    }
                    else
                    {
                        Console.WriteLine("Цілих чисел немає");
                    }
                    break;
                case 6:
                    if (a % 1 == 0 && b % 1 == 0)
                    {
                        Console.WriteLine($"Число {a} і {b} цілі числа");
                    }
                    else if (a % 1 == 0 && b % 1 != 0)
                    {
                        Console.WriteLine($"Число {a} ціле число");
                    }
                    else if (a % 1 != 0 && b % 1 == 0)
                    {
                        Console.WriteLine($"Число {b} ціле число");
                    }
                    else
                    {
                        Console.WriteLine("Цілих чисел немає");
                    }
                    break;
            }
        }
    }
}
