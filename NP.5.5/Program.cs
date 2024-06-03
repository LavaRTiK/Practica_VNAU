using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть c");
            double c = Convert.ToDouble(Console.ReadLine());

            Exp1(x, b, a);
            Exp2(x, b, a, c);
            Exp3(x, b, a);
        }
        static void Exp1(double x,double b, double a)
        {
            Console.WriteLine("Exp1");
            double y;
            if(x <= 0)
            {
                y = Math.Pow(x, 2) - Math.Sin(b / 2);
                Console.WriteLine("Ввідповідь:" + y + " x=<0");
            }
            else
            {
                y = Math.Sqrt(x / 2) + Math.Cos(Math.Pow(Math.E, a));
                Console.WriteLine("Ввідповідь:"+y+" x>0");
            }
        }
        static void Exp2(double x, double b, double a,double c)
        {
            Console.WriteLine("Exp2");
            double y;
            if(x>= 0)
            {
                y = 2 * Math.Pow(x, 2) + 2 * Math.Pow(a, 2);
                Console.WriteLine("Ввідповідь:" + y + " x>=0");
            }
            else
            {
                y = 2 / 3 * (a - c / 2);
                Console.WriteLine("Ввідповідь:" + y + " x<0");
            }
        }
        static void Exp3(double x, double b, double a)
        {
            Console.WriteLine("Exp3");
            double y;
            if(x>=2 || x <=4)
            {
                y = Math.Pow(x, 2) / Math.Sqrt(a) - 1 / 2;
                Console.WriteLine("Ввідповідь:" + y + " Діапазон 2-4");
            }
            else if (x>= 0)
            {
                y = Math.Pow((Math.Pow(x, 2) + a / b), 2);
                Console.WriteLine("Ввідповідь:" + y + " x>=0");
            }
            else
            {
                y = Math.Sqrt(Math.Pow(Math.Sin(Math.Pow(x, 2)), 2)) - Math.Pow(x,-Math.E)/a*b;
                Console.WriteLine("Ввідповідь:" + y + " x<0");
            }
        }
    }
}
