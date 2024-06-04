using System;
using System.Linq;
using System.Text;

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
            Ex9();
            Ex10();
            Ex11();
            Ex12();
            Ex13();
            Ex14();
            Ex15();
            Ex16();
            Ex17();
            Ex18();
            Ex19();
            Ex20();
            Console.ReadLine();
        }
        static void printMass(int[] mass) { 
        foreach (int i in mass)
            {
                Console.Write(i + ",");
            }
        }
        static void printMass(double[] mass)
        {
            foreach (double i in mass)
            {
                Console.Write(Math.Round(i,2)+",");
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
            Console.WriteLine("Завдання 7");
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
            Console.WriteLine("Завдання 8");
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
            Console.WriteLine("Завдання 9");
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
            Console.WriteLine("Завдання 10");
            Random rnd = new Random();
            int[] massRandom = new int[15];
            for (int i = 0; i < massRandom.Length; i++)
            {
                massRandom[i] = rnd.Next(0,3);
            }
            printMass(massRandom);
            int result = massRandom.Where(x => x < 1).Sum();
            Console.WriteLine($"Сума тих що менше 1 {result}");
        }
        static void Ex11()
        {
            Console.WriteLine("Завдання 11");
            Random rnd = new Random();
            int[] coinFlips = new int[10];
            for (int i = 0; i < coinFlips.Length; i++)
            {
                coinFlips[i] = rnd.Next(2);
            }
            foreach (var flip in coinFlips)
            {
                Console.WriteLine(flip == 1 ? "орел" : "решка");
            }
            int headsCount = coinFlips.Count(x => x == 1);
            int tailsCount = coinFlips.Count(x => x == 0);
            Console.WriteLine($"Кількість орлів: {headsCount}, кількість решек: {tailsCount}\n");
        }
        static void Ex12()
        {
            Console.WriteLine("Завдання 12");
            Random rnd = new Random();
            double[] randomMass = new double[10];
            for (int i = 0; i < randomMass.Length; i++)
            {
                randomMass[i] = rnd.NextDouble() * 20 - 10;
            }
            printMass(randomMass);
            int negative = randomMass.Count(x => x < 0);
            Console.WriteLine($"Кількість негативних чисел: {negative}\n");
        }
        static void Ex13()
        {
            bool foundOf7 = false;
            Random rnd = new Random();
            Console.WriteLine("Завдання 13");
            for (int i = 0; i < 20; i++)
            {
                int num = rnd.Next(-100, 101);
                Console.WriteLine(num);
                if (num % 7 == 0)
                {
                    foundOf7 = true;
                    Console.WriteLine($"Знайдено число, кратне 7: {num}\n");
                    break;
                }
            }
            if (!foundOf7)
            {
                Console.WriteLine("Число, кратне 7, не знайдено.\n");
            }
        }
        static void Ex14()
        {
            Console.WriteLine("Завдання 14");
            Random rnd = new Random();
            double[] massRandom = new double[10];
            for (int i = 0; i < massRandom.Length; i++)
            {
                massRandom[i] = rnd.NextDouble() * 100 - 50;
            }
            printMass(massRandom);
            double max = massRandom.Max();
            Console.WriteLine($"Найбільше число: {max}\n");
        }
        static void Ex15()
        {
            Console.WriteLine("Завдання 15");
            Random rnd = new Random();
            double[] randomMass = new double[15];
            for (int i = 0; i < randomMass.Length; i++)
            {
                randomMass[i] = rnd.NextDouble() * 100 - 50;
            }
            printMass(randomMass);
            int Pair = randomMass.Count(x => (int)x % 2 == 0);
            int NonPair = randomMass.Count(x => (int)x % 2 != 0);
            Console.WriteLine($"Кількість парних чисел: {Pair}, кількість непарних чисел: {NonPair}\n");
        }
        static void Ex16()
        {
            Console.WriteLine("Завдання 16");
            Random rnd = new Random();
            double[] randomMass = new double[15];
            for (int i = 0; i < randomMass.Length; i++)
            {
                randomMass[i] = rnd.NextDouble() * 100 - 50;
            }
            printMass(randomMass);
            int positive = randomMass.Count(x => x > 0);
            int negative = randomMass.Count(x => x < 0);
            Console.WriteLine($"Кількість позитивних чисел: {positive}, кількість негативних чисел: {negative}\n");
        }
        static void Ex17()
        {
            Console.WriteLine("Завдання 17");
            Random rnd = new Random();
            double[] randomMass = new double[15];
            for (int i = 0; i < randomMass.Length; i++)
            {
                randomMass[i] = rnd.NextDouble() * 100 - 50;
            }
            printMass(randomMass);
            int positive = randomMass.Count(x => x > 0 && (int)x % 2 == 0);
            Console.WriteLine($"Кількість парних позитивних чисел: {positive}\n");
        }
        static void Ex18()
        {
            Console.WriteLine("Завдання 17");
            Random rnd = new Random();
            double[] randomMass = new double[15];
            for (int i = 0; i < randomMass.Length; i++)
            {
                randomMass[i] = rnd.NextDouble() * 100 - 50;
            }
            printMass(randomMass);
            int negative = randomMass.Count(x => x < 0 && Convert.ToInt32(x) % 2 == 0);
            Console.WriteLine($"Кількість парних негативних чисел: {negative}\n");

        }
        static void Ex19() {
            Console.WriteLine("Завдання 19");
            Random rnd = new Random();
            double[] randomMass = new double[15];
            for (int i = 0; i < randomMass.Length; i++)
            {
                randomMass[i] = rnd.NextDouble() * 100 - 50;
            }
            printMass(randomMass);
            int positive = randomMass.Count(x => x > 0 && Convert.ToInt32(x) % 2 != 0);
            Console.WriteLine($"Кількість непарних позитивних чисел: {positive}\n");
        }
        static void Ex20()
        {
            Console.WriteLine("Завдання 20");
            Random rnd = new Random();
            double[] randomMass = new double[15];
            for (int i = 0; i < randomMass.Length; i++)
            {
                randomMass[i] = rnd.NextDouble() * 100 - 50;
            }
            printMass(randomMass);
            int negative = randomMass.Count(x => x < 0 && (int)x % 2 != 0);
            Console.WriteLine($"Кількість непарних негативних чисел: {negative}\n");
        }
    }
}
