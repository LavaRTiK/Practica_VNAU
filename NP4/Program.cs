using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Vvedit a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedit b:");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 19; i++)
            {
                Console.WriteLine("Відповідь для формули " + i + " " + "Відповідь:" + Formula(a, b, i).ToString());
            }
            Console.ReadLine();

        }
        static double Formula(int a, int b, int formulaChoice)
        {
            double y = 0;
            switch (formulaChoice)
            {
                case 1:
                    y = (3 * a + 3 * b) / (2 * a - 2 * b); //+
                    break;
                case 2:
                    y = a * a % 2 * b; //+
                    break;
                case 3:
                    y = a * a - 2 * b;
                    break;
                case 4:
                    y = (1 * 1 / a) % (b / 2);
                    break;
                case 5:
                    y = 3 / b - 2 * (a * a);
                    break;
                case 6:
                    y = 1 / b + b / a - a / b + a % b;
                    break;
                case 7:
                    y = a * a * a + (-2 * b);
                    break;
                case 8:
                    y = a * a * a % 2 * a;
                    break;
                case 9:
                    y = 3 * a * a + 2 / b;
                    break;
                case 10:
                    y = 1 / a % b;
                    break;
                case 11:
                    y = (-11 * a + 11 * b) / (a * a) + (b * b);
                    break;
                case 12:
                    y = a % b / 2 * a * b;
                    break;
                case 13:
                    y = a / b + b / a - a * b / 2;
                    break;
                case 14:
                    y = a % b + 1 / (2 * a * b);
                    break;
                case 15:
                    y = a / b + b / a + a * b / 2;
                    break;
                case 16:
                    y = a % b - 1 / (2 * a * a);
                    break;
                case 17:
                    y = 2 * a * a + 2 * b * b;
                    break;
                case 18:
                    y = a % b - a * b / 2 * (a * a) * (b * b);
                    break;
                default:
                    Console.WriteLine("Неправильний вибір формули.");
                    break;
            }
            return y;
        }
    }
}
