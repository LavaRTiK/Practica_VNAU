using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Таблиця try");
                Random random = new Random();
                int[] massX = new int [5]{random.Next(0,11), random.Next(0, 11), random.Next(0, 11), random.Next(0, 11), random.Next(0, 11) };
                int[] massY = new int[5] { random.Next(0, 11), random.Next(0, 11), random.Next(0, 11), random.Next(0, 11), random.Next(0, 11)};

            }
        }
        static void DrawTable(int[] massX,int[] massY)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(massX[i] + "*" + massY[i]);
            }        }
    }
}
