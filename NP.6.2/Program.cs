using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перше");
            Ex1();
            Console.WriteLine("Друге");
            Ex2();
            Console.WriteLine("Третье");
            Ex3();
            Console.WriteLine("Четверте");
            Ex4();
            Console.ReadLine();

        }
        static void printMass(int[] mass)
        {
            foreach (int i in mass)
            {
                Console.WriteLine(i);
            }
        }
        static void Ex1()
        {
            Random rnd = new Random();
            int[] mass = new int[50];
            for (int i = 0; i < mass.Length; i++)
            {

                mass[i] = rnd.Next(0, 101);
            }
            printMass(mass);
            //int braker = 10;
            int result = 0;
            int cookie = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (cookie == 10)
                {
                    break;
                }
                if (mass[i] % 1 == 0)
                {
                    result = result + mass[i];
                    cookie++;
                }
            }
            Console.WriteLine("-----------------");
            Console.WriteLine($"Сума перший 10 цілих чисел{result} із масива ");
        }
        static void Ex2()
        {
            Random rnd = new Random();
            int[] mass = new int[50];
            for (int i = 0; i < mass.Length; i++)
            {

                mass[i] = rnd.Next(0, 101);
            }
            printMass(mass);
            //int braker = 10;
            int result = 0;
            int cookie = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (cookie == 5)
                {
                    break;
                }
                if (mass[i] % 1 == 0)
                {
                    result = result * mass[i];
                    cookie++;
                }
            }
            Console.WriteLine("-----------------");
            Console.WriteLine($"Добуток перший 5 цілих чисел{result} із масива ");
        }
        static void Ex3()
        {
            int[] mass = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            printMass(mass);
            Console.WriteLine("---------------");
            int cookie = 0;
            int result = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (cookie == 5)
                {
                    break;
                }
                if (mass[i] % 1 == 0)
                    result = result + mass[i];

            }
            Console.WriteLine($"Сума перший цілих чисел{result} із масива арифметичної прогресії");
        }
        static void Ex4()
        {
            int[] mass = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            printMass(mass);
            Console.WriteLine("---------------");
            int cookie = 0;
            int result = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (cookie == 5)
                {
                    break;
                }
                if (mass[i] % 1 == 0)
                    result = result * mass[i];

            }
            Console.WriteLine($"Добуток перший цілих чисел{result} із масива арифметичної прогресії");
        }
        
    }
}
