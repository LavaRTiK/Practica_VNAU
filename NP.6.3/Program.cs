using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть N");
            int n = Convert.ToInt32(Console.ReadLine());
            Ex1(n);
            Ex2(n);
            Console.ReadLine();
        }
        static void printMass(int[] mass) { 
        foreach (int i in mass)
            {
                Console.WriteLine(i);
            }
        }
        static void Ex1(int n)
        {
            Console.WriteLine("Завдання 1");
            for (int i = 1; i <= n; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    Console.WriteLine($"Корінь {i} == {Math.Sqrt(i)}, ");
                }
            }
        }
        static void Ex2(int n)
        {
            Console.WriteLine("Завдання 2");
            int cookie = 0;
            int resutl = 0;
            Console.WriteLine($"Всього кількість чисел {n}");
            for (int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    cookie++;
                    resutl = resutl + i;
                }
            }
            Console.WriteLine($"Кількість праних числе {cookie}");
            Console.WriteLine($"Сума парних чисел {resutl}");
        }
        static void Ex3(int n)
        {
            Console.WriteLine("Завдання 3");
            int cookie = 0;
            int resutl = 0;
            Console.WriteLine($"Всього кільскість чисел{n}");
            for (int i = 0; i <= n; i++)
            {
                if(i % 2 != 0)
                {
                    cookie++;
                    resutl = resutl + i;
                }
            }
            Console.WriteLine($"Кількість не парних чисел {cookie}");
            Console.WriteLine($"Сума не праних чисел {resutl}");
        }
        static void Ex4(int n)
        {

        }
    }
}
