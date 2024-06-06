using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*Народ, з восьмого блоку де 60 завдань, робите: 8,10,14,15,16,17,18,20,21,22,31,35,36,45,47,50,51,55,56,57,58,59,60 */
            //Ex8();
            //Ex10();
            Console.ReadLine();



        }
        #region Методи
        //---------------------------------------------------------------//
        static void maxElementMassW<T>(T[] mass)
        {
            Console.WriteLine($"Мксимальний елемент масиву{mass.Max()}");
        }
        static T maxElementMassR<T>(T[] mass)
        {
            return mass.Max();
        }
        //--------------------------------------------------//
        static void minElementMassW<T>(T[] mass)
        {
            Console.WriteLine($"Мінімальний елемент масиву{mass.Min()}");
        }
        static T minElementMassR<T>(T[] mass)
        {
            return mass.Min();
        }
        static void randomNubmersMatrixInsert(int min,int max, int[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(min, max);
                }
            }

        }
        static void randomNumbersMassInsert(int min , int max , int [] mass)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
               mass[i]= rnd.Next(min, max);
            }
        }
        static void printMass<T>(T[] mass)
        {
            Console.WriteLine(string.Join(",", mass));
        }
        static void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Swap<T>(T element1 , T element2, T[] mass)
        {
            int posElement1 = mass.ToList().IndexOf(element1);
            int posElement2 = mass.ToList().IndexOf(element2);
            T temp = mass[posElement1];
            mass[posElement1] = mass[posElement2];
            mass[posElement2] = temp;
        }
        static int EnterValue(string text)
        {
            Console.WriteLine((string.IsNullOrWhiteSpace(text) ? "Введіть:" : text));
            int value = Convert.ToInt32(Console.ReadLine());
            return value;
        }
        static int[] insideOut<T>(T[] mass)
        {
            int [] insidemass = new int[mass.Length];
            insidemass = (int[])Convert.ChangeType(mass, typeof(int[]));
            return insidemass.Select(n => -n).ToArray();
        }
        static void findPairsWithSum(int[] mass, int N)
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
        #endregion
        static void Ex8()
        {
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int sizeMass = EnterValue("Введіть розмір масива:");
            int[] mass = new int[sizeMass];
            randomNumbersMassInsert(randomMin, randomMax, mass);
            printMass(mass);
            maxElementMassW(mass);
            minElementMassW(mass);
            Swap(maxElementMassR(mass),minElementMassR(mass),mass);
            printMass(mass);

        }
        static void Ex10()
        {
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int sizeMass = EnterValue("Введіть розмір масива:");
            int[] mass = new int[sizeMass];
            randomNumbersMassInsert(randomMin, randomMax, mass);
            printMass(mass);
            printMass(insideOut(mass));
        }
        static void Ex14()
        {
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int sizeMass = EnterValue("Введіть розмір масива:");
            int[] mass = new int[sizeMass];
            randomNumbersMassInsert(randomMin, randomMax, mass);
            printMass(mass);
            var result = mass.Where((n, i) => i > 0 && n > mass[i - 1]).ToArray();
            printMass(result);
        }
        static void Ex15()
        {
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int sizeMass = EnterValue("Введіть розмір масива:");
            int N = EnterValue("Вимоги задачі:");
            int[] mass = new int[sizeMass];
            randomNumbersMassInsert(randomMin, randomMax, mass);
            printMass(mass);
            findPairsWithSum(mass, N);
        }
        static void Ex16()
        {
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int sizeMass = EnterValue("Введіть розмір масива:");
            int N = EnterValue("Вимоги задачі:");
            int[] mass = new int[sizeMass];
            randomNumbersMassInsert(randomMin, randomMax, mass);
            printMass(mass);
            printMass(mass.SelectMany((x, i) => mass.Skip(i + 1), (x, y) => new { x, y }).Where(pair => pair.x * pair.y == N).ToArray());
        }
        static void Ex17()
        {
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int sizeMass = EnterValue("Введіть розмір масива:");
            int N = EnterValue("Вимоги задачі:");
            int[] mass = new int[sizeMass];
            randomNumbersMassInsert(randomMin, randomMax, mass);
            printMass(mass);
            printMass(mass.Where(n => Math.Pow(n, 2) == N).ToArray());

        }
        static void Ex18()
        {
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int sizeMass = EnterValue("Введіть розмір масива:");
            int N = EnterValue("Вимоги задачі:");
            int[] mass = new int[sizeMass];
            randomNumbersMassInsert(randomMin, randomMax, mass);
            printMass(mass);
            printMass(mass.Where(n => n != 0 && n / n == N).ToArray());
        }
        static void Ex19()
        {
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int sizeMatrixX = EnterValue("Введіть розмір масива X:");
            int sizeMatrixY = EnterValue("Введіть розмір масива Y:");
            int[,] matrix = new int[sizeMatrixX, sizeMatrixY];
            randomNubmersMatrixInsert(randomMin,randomMax,matrix);
            printMatrix(matrix);
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int countEven = 0;
                for (int i = 0; i < matrix.GetLength(1); i++)
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
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int sizeMatrixX = EnterValue("Введіть розмір масива X:");
            int sizeMatrixY = EnterValue("Введіть розмір масива Y:");
            int[,] matrix = new int[sizeMatrixX, sizeMatrixY];
            randomNubmersMatrixInsert(randomMin, randomMax, matrix);
            printMatrix(matrix);
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int sumEven = 0;
                for (int i = 0; i < matrix.GetLength(1); i++)
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
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int sizeMatrixX = EnterValue("Введіть розмір масива X:");
            int sizeMatrixY = EnterValue("Введіть розмір масива Y:");
            int[,] matrix = new int[sizeMatrixX, sizeMatrixY];
            randomNubmersMatrixInsert(randomMin, randomMax, matrix);
            printMatrix(matrix);
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int countOdd = 0;
                for (int i = 0; i < matrix.GetLength(1); i++)
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
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int sizeMatrixX = EnterValue("Введіть розмір масива X:");
            int sizeMatrixY = EnterValue("Введіть розмір масива Y:");
            int[,] matrix = new int[sizeMatrixX, sizeMatrixY];
            randomNubmersMatrixInsert(randomMin, randomMax, matrix);
            printMatrix(matrix);
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int sumOdd = 0;
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        sumOdd += matrix[i, j];
                    }
                }
                Console.WriteLine("Стовбець " + j + " сума не парних: " + sumOdd);
            }
        }
        static void Ex31()
        {
            while (true)
            {
                int cookie = 0;
                Console.WriteLine("Дайте відповідь");
                Random random = new Random();
                int coutEx = EnterValue("Кількість прикладів X:");
                int[] massX = new int[coutEx];
                int [] massY = new int[coutEx];
                randomNumbersMassInsert(1, 11, massX);
                randomNumbersMassInsert(1, 11, massY);

                for (int i = 0; i < coutEx; i++)
                {
                    Console.WriteLine($"Питання {cookie} із {coutEx}");
                    Console.Write($"{massX[i]}*{massY[i]}=");
                    int current = Convert.ToInt32(Console.ReadLine());
                    if (current != massX[i] * massY[i])
                    {
                        Console.Clear();
                        break;
                    }
                    cookie++;
                    Console.Clear();

                }
                if (cookie == coutEx)
                {
                    Console.WriteLine("Ви відповіли на всі запитання ");
                }
            }
        }
        static void Ex35()
        {
            int size = EnterValue("Прогресія до X:");
            int lize = EnterValue("обрахунку добутку перших скількох цілих чисел");
            int result = 0;
            for (int i = 1; i < lize; i++)
            {
                result = result * i;
            }
            Console.WriteLine("result="+ result);
        }
        static void Ex36()
        {
            int n = EnterValue("Введіть n:");
            for (int i = 1; i <= n; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    Console.WriteLine($"Корінь {i} == {Math.Sqrt(i)}, ");
                }
            }
        }
        static void Ex45()
        {
            int size = EnterValue("Розмір:");
            int[] coinFlips = new int[size];
            randomNumbersMassInsert(0,2,coinFlips);
            foreach (var flip in coinFlips)
            {
                Console.WriteLine(flip == 1 ? "орел" : "решка");
            }
            int headsCount = coinFlips.Count(x => x == 1);
            int tailsCount = coinFlips.Count(x => x == 0);
            Console.WriteLine($"Кількість орлів: {headsCount}, кількість решек: {tailsCount}\n");
        }
        static void Ex47()
        {
            int size = EnterValue("Розмір масива:");
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int[] mass = new int[size];
            randomNumbersMassInsert(randomMin, randomMax, mass);
            printMass(mass);
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 7 == 0)
                {
                    Console.WriteLine("найшов:" + mass[i] + "індекс:" + i);
                }
            }
        }
        static void Ex50() {
            int size = EnterValue("Розмір масива:");
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int[] mass = new int[size];
            randomNumbersMassInsert(randomMin, randomMax, mass);
            printMass(mass);
            int positive = 0;
            int negative = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }
            Console.WriteLine("Позитив " + positive + " Негатив " + negative);

        }
        static void Ex51()
        {
            int size = EnterValue("Розмір масива:");
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int[] mass = new int[size];
            randomNumbersMassInsert(randomMin, randomMax, mass);
            printMass(mass);
            int positive = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                {
                    if (mass[i] % 2 == 0)
                    {
                        positive++;
                    }
                }
            }
            Console.WriteLine("Позитив парних" + positive );

        }
        static void Ex55()
        {
            Console.WriteLine("--Перевірка віднімання--");
            int size = EnterValue("Кількість прикладів:");
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int[] massX = new int[size];
            int[] massY = new int[size];
            randomNumbersMassInsert(randomMin, randomMax, massX);
            randomNumbersMassInsert(randomMin, randomMax, massY);
            int cookie = 0;
            for (int i = 0; i < massX.Length; i++)
            {

                Console.Write($"{massX[i]}-{massY[i]}=");
                int anwer = Convert.ToInt32(Console.ReadLine());
                if (anwer == massX[i] - massY[i])
                {
                    Console.WriteLine("Правильна відповіль");
                    cookie++;
                }
                else
                {
                    Console.WriteLine("Неправильна відповідь");
                }
            }
            double percentage = (double)cookie / size * 100;

            if (percentage == 100)
            {
                Console.WriteLine("Завершено ви отримали 5 балів");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Завершено ви отримали 4 балів");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Завершено ви отримали 3 балів");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Завершено ви отримали 2 бала");
            }
            else
            {
                Console.WriteLine("Завершено ви отримали 1 бал");
            }
        }
        static void Ex56()
        {
            Console.WriteLine("--Перевірка дадавання--");
            int size = EnterValue("Кількість прикладів:");
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int[] massX = new int[size];
            int[] massY = new int[size];
            randomNumbersMassInsert(randomMin, randomMax, massX);
            randomNumbersMassInsert(randomMin, randomMax, massY);
            int cookie = 0;
            for (int i = 0; i < massX.Length; i++)
            {

                Console.Write($"{massX[i]}+{massY[i]}=");
                int anwer = Convert.ToInt32(Console.ReadLine());
                if (anwer == massX[i] + massY[i])
                {
                    Console.WriteLine("Правильна відповіль");
                    cookie++;
                }
                else
                {
                    Console.WriteLine("Неправильна відповідь");
                }
            }
            double percentage = (double)cookie / size * 100;

            if (percentage == 100)
            {
                Console.WriteLine("Завершено ви отримали 5 балів");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Завершено ви отримали 4 балів");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Завершено ви отримали 3 балів");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Завершено ви отримали 2 бала");
            }
            else
            {
                Console.WriteLine("Завершено ви отримали 1 бал");
            }
        }
        static void Ex57()
        {
            Console.WriteLine("--Перевірка діленя--");
            int size = EnterValue("Кількість прикладів:");
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int[] massX = new int[size];
            int[] massY = new int[size];
            randomNumbersMassInsert(randomMin, randomMax, massX);
            randomNumbersMassInsert(randomMin, randomMax, massY);
            int cookie = 0;
            for (int i = 0; i < massX.Length; i++)
            {

                Console.Write($"{massX[i]}/{massY[i]}=");
                int anwer = Convert.ToInt32(Console.ReadLine());
                if (anwer == massX[i] / massY[i])
                {
                    Console.WriteLine("Правильна відповіль");
                    cookie++;
                }
                else
                {
                    Console.WriteLine("Неправильна відповідь");
                }
            }
            double percentage = (double)cookie / size * 100;

            if (percentage == 100)
            {
                Console.WriteLine("Завершено ви отримали 5 балів");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Завершено ви отримали 4 балів");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Завершено ви отримали 3 балів");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Завершено ви отримали 2 бала");
            }
            else
            {
                Console.WriteLine("Завершено ви отримали 1 бал");
            }

        }
        static void Ex58()
        {
            Console.WriteLine("--Перевірка множення--");
            int size = EnterValue("Кількість прикладів:");
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int[] massX = new int[size];
            randomNumbersMassInsert(randomMin, randomMax, massX);
            int cookie = 0;
            for (int i = 0; i < massX.Length; i++)
            {

                Console.Write($"{massX[i] * massX[i]}=");
                int anwer = Convert.ToInt32(Console.ReadLine());
                if (anwer == massX[i])
                {
                    Console.WriteLine("Правильна відповіль");
                    cookie++;
                }
                else
                {
                    Console.WriteLine("Неправильна відповідь");
                }
            }
            double percentage = (double)cookie / size * 100;

            if (percentage == 100)
            {
                Console.WriteLine("Завершено ви отримали 5 балів");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Завершено ви отримали 4 балів");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Завершено ви отримали 3 балів");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Завершено ви отримали 2 бала");
            }
            else
            {
                Console.WriteLine("Завершено ви отримали 1 бал");
            }

        }
        static void Ex59()
        {
            Console.WriteLine("--Перевірка підносити до степеня--");
            int size = EnterValue("Кількість прикладів:");
            int randomMin = EnterValue("Мінімальне значення:");
            int randomMax = EnterValue("Максимальне значення:");
            int[] massX = new int[size];
            randomNumbersMassInsert(randomMin, randomMax, massX);
            int cookie = 0;

            for (int i = 0; i < massX.Length; i++)
            {
                Console.Write($"{massX[i]} * {massX[i]} = ");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == massX[i] * massX[i])
                {
                    Console.WriteLine("Правильна відповідь");
                    cookie++;
                }
                else
                {
                    Console.WriteLine("Неправильна відповідь");
                }
            }

            double percentage = (double)cookie / size * 100;

            if (percentage == 100)
            {
                Console.WriteLine("Завершено, ви отримали 5 балів");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Завершено, ви отримали 4 бали");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Завершено, ви отримали 3 бали");
            }
            else if (percentage >= 40)
            {
                Console.WriteLine("Завершено, ви отримали 2 бали");
            }
            else
            {
                Console.WriteLine("Завершено, ви отримали 1 бал");
            }
        }
        static void Ex60()
        {
            decimal usdb = 41.25M;
            decimal usds = 40.25M;
            Console.WriteLine("Введіть дію яку ви хочете виконати");
            Console.WriteLine("0.Долар до гривні");
            Console.WriteLine("1.гривні до долара");
            int watDO = Convert.ToInt32(Console.ReadLine());
            if (watDO == 0)
            {
                Console.WriteLine("Продажа:" + " 1$ = " + usds + "грн");
                Console.Write("Введіть кільскіть доларів(продажа) =>");
                decimal dollar = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"В кількості:{dollar}$ до гривні:{Math.Round(dollar * usds, 2)}грн");
            }
            else if (watDO == 1)
            {
                Console.WriteLine("Купвіля:" + usdb + "= 1$");
                Console.Write("Введіть кільскіть гривнів(купівля) =>");
                decimal uah = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"В кількості:{uah}грн  до долара :{Math.Round(uah / usdb, 2)}$");
            }
            else
            {
                Console.WriteLine("Такої дії немає");
            }
        }

    }
}
