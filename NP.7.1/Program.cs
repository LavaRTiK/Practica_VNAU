using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Ex10();
            Console.ReadLine();
        }
        static void printmass(int[] mass)
        {
            foreach (var item in mass)
            {
                Console.WriteLine(""+ item +",");
            }
        }
        static void Ex1()
        {
            Console.WriteLine("Завдання 1");
            Random ran = new Random();
            int[] mass = new int[5];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = ran.Next(-10,10);
            }
            printmass(mass);
        }
        static void Ex2()
        {

            Console.WriteLine("Завдання 2");
            Random ran = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = ran.Next(1, 21);
            }
            printmass(mass);
            Console.WriteLine($"Чисел більше 5 {mass.Count(x=> x > 5)}");
        }
        static void Ex3()
        {

            Console.WriteLine("Завдання 3");
            Random ran = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = ran.Next(-10, 21);
            }
            printmass(mass);
            Console.WriteLine($"Число що ділиться на 3 (максимальне) {mass.Where(x => x % 3 == 0).Max()}");
        }
        static void Ex4()
        {

            Console.WriteLine("Завдання 4");
            Random ran = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = ran.Next(-10, 21);
            }
            printmass(mass);
            Console.WriteLine($"Число що ділиться на 3  {mass.Count(x => x % 3 == 0)} їх сума {mass.Where(x => x % 3 == 0).Sum()}");
        }
        static void Ex5()
        {

            Console.WriteLine("Завдання 5");
            Random ran = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = ran.Next(-10, 21);
            }
            printmass(mass);
            Console.WriteLine($"Число що ділиться на 3 (максимальне) {mass.Where(x => x % 3 == 0).Max()} їх добуток{mass.Aggregate(1, (acc, n) => acc * n)}");
        }
        static void Ex6()
        {

            Console.WriteLine("Завдання 6");
            Random ran = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = ran.Next(-10, 10);
            }
            printmass(mass);
            Console.WriteLine($"Максималий{mass.Max()}, мінімальний{mass.Min()}");
        }
        static void Ex7()
        {

            Console.WriteLine("Завдання 7");
            Random ran = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = ran.Next(-10, 10);
            }
            printmass(mass);
            Console.WriteLine($"Індекс Максималий{mass.ToList().FindIndex(x => x == mass.Max())}, мінімальний {mass.ToList().FindIndex(x => x == mass.Min ())}");
        }
        static void Ex8()
        {

            Console.WriteLine("Завдання 8");
            Random ran = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = ran.Next(-10, 10);
            }
            printmass(mass);
            Console.WriteLine($"Індекс Максималий {mass.Max()},{mass.ToList().FindIndex(x => x == mass.Max())}, мінімальний {mass.Min()} , {mass.ToList().FindIndex(x => x == mass.Min())}");
            int temp = mass[mass.ToList().FindIndex(x => x == mass.Max())];
            mass[mass.ToList().FindIndex(x => x == mass.Max())] = mass[mass.ToList().FindIndex(x => x == mass.Min())];
            mass[mass.ToList().FindIndex(x => x == mass.Min())] = temp;
            printmass(mass);
        }
        static void Ex9()
        {

            Console.WriteLine("Завдання 9");
            Random ran = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = ran.Next(-10, 10);
            }
            printmass(mass);
            Console.WriteLine($"Максималий{mass.Max()}, мінімальний{mass.Min()} різниця {mass.Max() - mass.Min()}");
        }
        static void Ex10()
        {
            Console.WriteLine("Завдання 10");
            Random rnd = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10, 11);
            }
            int[] oppositeArray = mass.Select(n => -n).ToArray();
            printmass(mass);
            Console.WriteLine("Обернуний масив:");
            printmass(oppositeArray);
        }
        static void Ex11()
        {
            Console.WriteLine("Завдання 11");
            Random rnd = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10, 11);
            }
            printmass(mass);
            Console.WriteLine("Перше негативние число: " + mass.First(n => n < 0) + ", Індекс : " + Array.IndexOf(mass, mass.First(n => n < 0)));
        }

        static void Ex12()
        {
            Console.WriteLine("Завдання 12");
            Random rnd = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10, 11);
            }
            printmass(mass);
            Console.WriteLine("Перший позитивний елемент: " + mass.First(n => n > 0) + ", Індекс: " + Array.IndexOf(mass, mass.First(n => n > 0)));
        }

        static void Ex13()
        {
            Console.WriteLine("Завдання 13");
            Random rnd = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10, 11);
            }
            var negativeNumbers = mass.Where(n => n < 0);
            var positiveNumbers = mass.Where(n => n > 0);
            printmass(mass);
            Console.WriteLine("Негативні: " + string.Join(", ", negativeNumbers));
            Console.WriteLine("Позитивні: " + string.Join(", ", positiveNumbers));
        }

        static void Ex14()
        {
            Console.WriteLine("Завдання 14");
            Random rnd = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10, 11);
            }
            var result = mass.Where((n, i) => i > 0 && n > mass[i - 1]);
            printmass(mass);
            Console.WriteLine("елементи числового масиву, які більші, ніж елементи, що стоять перед ними: " + string.Join(", ", result));
        }

        static void Ex15()
        {
            Console.WriteLine("Завдання 15");
            Random rnd = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10, 11);
            }
            Console.Write("Введіть N: ");
            int N = int.Parse(Console.ReadLine());
            printmass(mass);
            //Console.WriteLine("Елемент рівний " + N + ": " + string.Join(", ", mass.Where(n => n == N)));
            findPairsWithSumLinq(mass,N);
        }
        static void findPairsWithSumLinq(int[] mass, int N)
        {
            var pairs = mass
                .SelectMany((x, i) => mass.Skip(i + 1), (x, y) => new { x, y })
                .Where(pair => pair.x + pair.y == N)
                .ToList();

            if (pairs.Count > 0)
            {
                Console.WriteLine($"Пари елементів, які в сумі дають {N}:");
                foreach (var pair in pairs)
                {
                    Console.WriteLine($"({pair.x}, {pair.y})");
                }
            }
            else
            {
                Console.WriteLine("Пари не знайдено.");
            }
        }
        static void Ex16()
        {
            Console.WriteLine("Завдання 16");
            Random rnd = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10, 11);
            }
            Console.Write("Введіть N: ");
            int N = int.Parse(Console.ReadLine());
            printmass(mass);
            Console.WriteLine("Елементи які при добудку дають " + N + ": " + string.Join(", ", mass.SelectMany((x, i) => mass.Skip(i + 1), (x, y) => new { x, y }).Where(pair => pair.x * pair.y == N).ToList()));
        }

        static void Ex17()
        {
            Console.WriteLine("Завдання 17");
            Random rnd = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10, 11);
            }
            Console.Write("Введіть N: ");
            int N = int.Parse(Console.ReadLine());
            printmass(mass);
            Console.WriteLine("Елементи які при піднесенні одного число до іншого дають " + N + ": " + string.Join(", ", mass.Where(n => Math.Pow(n, 2) == N)));
        }

        static void Ex18()
        {
            Console.WriteLine("Завдання 18");
            Random rnd = new Random();
            int[] mass = new int[10];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(-10, 11);
            }
            Console.Write("Введіть N: ");
            int N = int.Parse(Console.ReadLine());
            printmass(mass);
            Console.WriteLine("елементи які при діленні першого на другий елемент дають " + N +  string.Join(", ", mass.Where(n => n != 0 && n / n == N)));
        }

        static void Ex19()
        {
            Console.WriteLine("Завдання 19");
            Random rnd = new Random();
            int[,] matrix = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rnd.Next(10, 21);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 4; j++)
            {
                int countEven = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        countEven++;
                    }
                }
                Console.WriteLine("Столбець " + j + " парних номерів: " + countEven);
            }
        }

        static void Ex20()
        {
            Console.WriteLine("Завдання 20");
            Random rnd = new Random();
            int[,] matrix = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rnd.Next(10, 21);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 4; j++)
            {
                int sumEven = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sumEven += matrix[i, j];
                    }
                }
                Console.WriteLine("Столбець " + j + " сума парних чисел: " + sumEven);
            }
        }
        static void Ex21()
        {
            Console.WriteLine("Завдання 21");
            Random rnd = new Random();
            int[,] matrix = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rnd.Next(10, 21);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 4; j++)
            {
                int countOdd = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        countOdd++;
                    }
                }
                Console.WriteLine("Стовбець " + j + " кількість не праних чисел: " + countOdd);
            }
        }

        static void Ex22()
        {
            Console.WriteLine("Завдання 22");
            Random rnd = new Random();
            int[,] matrix = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rnd.Next(10, 21);
                }
            };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 4; j++)
            {
                int sumOdd = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        sumOdd += matrix[i, j];
                    }
                }
                Console.WriteLine("Стовбець " + j + " сума не парних: " + sumOdd);
            }
        }

        static void Ex23()
        {
            Console.WriteLine("Завдання 23");
            Random rnd = new Random();
            int[,] matrix = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rnd.Next(10, 21);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 4; j++)
            {
                int sumPositive = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sumPositive += matrix[i, j];
                    }
                }
                Console.WriteLine("Стовбець " + j + " сума позитивних " + sumPositive);
            }
        }

        static void Ex24()
        {
            Console.WriteLine("Завдання 24");
            Random rnd = new Random();
            int[,] matrix = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rnd.Next(-20, 21);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 4; j++)
            {
                int sumNegative = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        sumNegative += matrix[i, j];
                    }
                }
                Console.WriteLine("Стовпець " + j + " Сума негативниг чисел: " + sumNegative);
            }
        }

        static void Ex25()
        {
            Random rnd = new Random();
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(10, 51);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 5; j++)
            {
                int countDivisibleBy3 = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] % 3 == 0)
                    {
                        countDivisibleBy3++;
                    }
                }
                Console.WriteLine("Стовпець " + j + " числа які кратні 3: " + countDivisibleBy3);
            }
        }
        static void Ex26()
        {
            Console.WriteLine("Завдання 26");
            Random random = new Random();
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(10, 51);
                }
            };
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 5; j++)
            {
                Console.Write("стовбець " + j + " цифра яка закінчюется 1: ");
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] % 10 == 1)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Ex27()
        {
            Console.WriteLine("Завдання 27");
            Random random = new Random();
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(10, 51);
                }
            }
            int max = matrix[0, 0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Максимальне число: " + max);
        }

        static void Ex28()
        {
            Console.WriteLine("Завдання 28");
            Random random = new Random();
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(10, 51);
                }
            }
            int min = matrix[0, 0];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Мінімальне число: " + min);
        }

        static void Ex29()
        {
            Console.WriteLine("Завдання 29");
            Random random = new Random();
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-50, 51);
                }
            }
            int count = 0;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    if (matrix[i, j] >= -9 && matrix[i, j] <= 9 && matrix[i, j] != 0)
                    {
                        count++;
                        sum += matrix[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Однозначні число : кількість = " + count + ", сум = " + sum);
        }

        static void Ex30()
        {
            Console.WriteLine("Завдання 30");
            Random random = new Random();
            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-50, 51);
                }
            }
            int count = 0;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    if ((matrix[i, j] >= 10 && matrix[i, j] <= 99) || (matrix[i, j] <= -10 && matrix[i, j] >= -99))
                    {
                        count++;
                        sum += matrix[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Двох значні число : кількість = " + count + ", сума = " + sum);
        }
    }
}
    