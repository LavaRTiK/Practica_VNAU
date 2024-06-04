using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                int cookie = 0;
                Console.WriteLine("Дайте відповідь");
                Random random = new Random();
                int[] massX = new int [5]{random.Next(0,11), random.Next(0, 11), random.Next(0, 11), random.Next(0, 11), random.Next(0, 11) };
                int[] massY = new int[5] { random.Next(0, 11), random.Next(0, 11), random.Next(0, 11), random.Next(0, 11), random.Next(0, 11)};

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Кількість правильни {cookie} із 5");
                    Console.Write($"{massX[i]}*{massY[i]}=");
                    int current = Convert.ToInt32(Console.ReadLine());
                    if(current != massX[i] * massY[i]) {
                        Console.Clear();
                        break;
                    }
                    cookie++;
                    Console.Clear();

                }
                if(cookie == 5)
                {
                    Console.WriteLine("Ви відповіли на всі запитання ");
                }
            }
        }
    }
}
