using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string name = "Ярошенко Павло Павлович ";
            string datanarojena = "27.07.2003 ";
            string old = "20 ";
            string unversityData = "30.09.2023 ";
            string group = "KH22-1 ";
            string dataNow = "03.06.2024 8:43:00 ";
            string teather = "Чіков Ілля Анатолівич "; 

            string all = name + old + group+ unversityData + dataNow + teather;
            Console.WriteLine(all);
            Console.WriteLine($"{name},{datanarojena},{unversityData},{group}");
            Console.ReadLine();//Тут чекаємо ввід даних 

        }
    }
}
