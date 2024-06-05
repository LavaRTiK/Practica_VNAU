using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Exchange();
            Console.ReadLine();
        }
        public static void Ex1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--Перевірка віднімання--");
            Random rnd = new Random();
            int[] massX = new int[10];
            int[] massY = new int[10];
            for (int i = 0; i < massX.Length; i++)
            {
                massX[i] = rnd.Next(1, 99);
                massY[i] = rnd.Next(1, 99);
            }
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

            if (cookie == 10)
            {
                Console.WriteLine("Завершено ви отримали 5 балів");
            }
            else if (cookie > 7 || cookie < 9)
            {
                Console.WriteLine("Завершено ви отримали 4 балів");
            }
            else if (cookie > 4 || cookie < 6)
            {
                Console.WriteLine("Завершено ви отримали 3 балів");
            }
            else if (cookie > 3 || cookie < 5)
            {
                Console.WriteLine("Завершено ви отримали 2 бала");
            }
            else
            {
                Console.WriteLine("Завершено ви отримали 1 бал");
            }
        }
        public static void Ex2() {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--Перевірка додавання--");
            Random rnd = new Random();
            int[] massX = new int[10];
            int[] massY = new int[10];
            for (int i = 0; i < massX.Length; i++)
            {
                massX[i] = rnd.Next(-99, 99);
                massY[i] = rnd.Next(-99, 99);
            }
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

            if (cookie == 10)
            {
                Console.WriteLine("Завершено ви отримали 5 балів");
            }
            else if (cookie > 7 || cookie < 9)
            {
                Console.WriteLine("Завершено ви отримали 4 балів");
            }
            else if (cookie > 4 || cookie < 6)
            {
                Console.WriteLine("Завершено ви отримали 3 балів");
            }
            else if (cookie > 3 || cookie < 5)
            {
                Console.WriteLine("Завершено ви отримали 2 бала");
            }
            else
            {
                Console.WriteLine("Завершено ви отримали 1 бал");
            }
        }
        public static void Ex3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--Перевірка Ділення--");
            Random rnd = new Random();
            int[] massX = new int[10];
            int[] massY = new int[10];
            for (int i = 0; i < massX.Length; i++)
            {
                massX[i] = rnd.Next(-10, 10);
                massY[i] = rnd.Next(-10, 10);
            }
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

            if (cookie == 10)
            {
                Console.WriteLine("Завершено ви отримали 5 балів");
            }
            else if (cookie > 7 || cookie < 9)
            {
                Console.WriteLine("Завершено ви отримали 4 балів");
            }
            else if (cookie > 4 || cookie < 6)
            {
                Console.WriteLine("Завершено ви отримали 3 балів");
            }
            else if (cookie > 3 || cookie < 5)
            {
                Console.WriteLine("Завершено ви отримали 2 бала");
            }
            else
            {
                Console.WriteLine("Завершено ви отримали 1 бал");
            }
        }
        public static void Ex4()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--Перевірка квадратний корінь --");
            Console.WriteLine("Відповідь потрібно округляти до 2 знаків після коми");
            Random rnd = new Random();
            int[] massX = new int[10];
            int[] massY = new int[10];
            for (int i = 0; i < massX.Length; i++)
            {
                massX[i] = rnd.Next(1, 100);
            }
            int cookie = 0;
            for (int i = 0; i < massX.Length; i++)
            {

                Console.Write($"{massX[i]}=");
                double anwer = Convert.ToDouble(Console.ReadLine());
                if (anwer == Math.Round(Math.Sqrt(massX[i]),2))
                {

                    Console.WriteLine("Правильна відповіль");
                    cookie++;
                }
                else
                {
                    Console.WriteLine("Неправильна відповідь");
                }
            }

            if (cookie == 10)
            {
                Console.WriteLine("Завершено ви отримали 5 балів");
            }
            else if (cookie > 7 || cookie < 9)
            {
                Console.WriteLine("Завершено ви отримали 4 балів");
            }
            else if (cookie > 4 || cookie < 6)
            {
                Console.WriteLine("Завершено ви отримали 3 балів");
            }
            else if (cookie > 3 || cookie < 5)
            {
                Console.WriteLine("Завершено ви отримали 2 бала");
            }
            else
            {
                Console.WriteLine("Завершено ви отримали 1 бал");
            }
        }
        static void Ex5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--Перевірка Множення --");
            Random rnd = new Random();
            int[] massX = new int[10];
            int[] massY = new int[10];
            for (int i = 0; i < massX.Length; i++)
            {
                massX[i] = rnd.Next(-10, 10);
                massY[i] = rnd.Next(-10, 10);
            }
            int cookie = 0;
            for (int i = 0; i < massX.Length; i++)
            {

                Console.Write($"{massX[i]}*{massY[i]}=");
                int anwer = Convert.ToInt32(Console.ReadLine());
                if (anwer == massX[i] * massY[i])
                {
                    Console.WriteLine("Правильна відповіль");
                    cookie++;
                }
                else
                {
                    Console.WriteLine("Неправильна відповідь");
                }
            }

            if (cookie == 10)
            {
                Console.WriteLine("Завершено ви отримали 5 балів");
            }
            else if (cookie > 7 || cookie < 9)
            {
                Console.WriteLine("Завершено ви отримали 4 балів");
            }
            else if (cookie > 4 || cookie < 6)
            {
                Console.WriteLine("Завершено ви отримали 3 балів");
            }
            else if (cookie > 3 || cookie < 5)
            {
                Console.WriteLine("Завершено ви отримали 2 бала");
            }
            else
            {
                Console.WriteLine("Завершено ви отримали 1 бал");
            }
        }
        static void Exchange()
        {
            decimal usdb = 41.25M;
            decimal usds = 40.25M;
            Console.WriteLine("Введіть дію яку ви хочете виконати");
            Console.WriteLine("0.Долар до гривні");
            Console.WriteLine("1.гривні до долара");
            int watDO = Convert.ToInt32(Console.ReadLine());
            if(watDO == 0)
            {
                Console.WriteLine("Продажа:" + " 1$ = " + usds+"грн" );
                Console.Write("Введіть кільскіть доларів(продажа) =>");
                decimal dollar = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"В кількості:{dollar}$ до гривні:{Math.Round(dollar*usds,2)}грн");
            }
            else if (watDO == 1) {
                Console.WriteLine("Купвіля:"+ usdb + "= 1$");
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
