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
            Ex3(n);
            Ex4();
            Ex5();
            Ex6();
            Ex7();
            Ex8();
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
        static void Ex4()
        {
            Console.WriteLine("Завдання 4");
            Random rnd = new Random();
            int[] mass = new int[20];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10,11);
            }
            printMass(mass);
            int result = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= 1)
                {
                    Console.WriteLine("Позитивне число:" + mass[i]);
                    result = result + mass[i];
                }
            }
        }
        static void Ex5()
        {
            Console.WriteLine("Завдання 5");
            Random rnd = new Random();
            int[] mass = new int[20];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10, 11);
            }
            printMass(mass);
            int result = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    Console.WriteLine("Відємне число число:" + mass[i]);
                    result = result + mass[i];
                }
            }
        }
        static void Ex6()
        {
            Console.WriteLine("Завдання 6");
            Random rnd = new Random();
            int[] massRandom = new int[10];
            for (int i = 0; i < massRandom.Length; i++)
            {
                massRandom[i] = rnd.Next(1, 21);
            }
            printMass(massRandom);
            Console.WriteLine($"Кількість чисел більше 5 | {massRandom.Count(x => x > 5)}");
        }
        static void Ex7()
        {
            Console.WriteLine("Завдання 6");
            Random rnd = new Random();
            int[] massRandom = new int[10];
            for (int i = 0; i < massRandom.Length; i++)
            {
                massRandom[i] = rnd.Next(1, 21);
            }
            printMass(massRandom);
            Console.WriteLine($"Кількість чисел більше 5 | {massRandom.Count(x => x < 5)}");
        }
        static void Ex8()
        {
            Console.WriteLine("Завдання 6");
            Random rnd = new Random();
            int[] massRandom = new int[10];
            for (int i = 0; i < massRandom.Length; i++)
            {
                massRandom[i] = rnd.Next(1, 21);
            }
            printMass(massRandom);
            Console.WriteLine($"Кількість чисел більше 5 | {massRandom.Count(x=> x > massRandom.Sum()/10)}");
        }
        static void Ex9()
        {
            int cookie = 0;
            Console.Write("Число кратне 3:");
            for (int i = 100; i < 200; i++)
            {
                if(i % 3 == 0)
                {
                    cookie++;
                    Console.WriteLine($" {i},");
                }
            }
        }
        static void Ex10()
        {

        }
    }
}
