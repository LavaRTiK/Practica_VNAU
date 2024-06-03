using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP._5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DrawMenu();
            int commandmenu = Convert.ToInt32(Console.ReadLine());
            switch (commandmenu)
            {
                case 1:
                    {
                        Ex1(1);
                        Ex2(1);
                        Ex3(1);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Примітка в 3 рівняні не використовується C але вона обовязкова для інших рівннянь");
                        double x, c, b, a;
                        Console.Write("Введіть x:");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть c:");
                        c = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть b:");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть a:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Ex1(x,c,b,a);
                        Ex2(x,c,b,a);
                        Ex3(x,b,a);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Із базовими змінами? \n 1.Так \n 2.Ні");
                        int yesNo = Convert.ToInt32(Console.ReadLine());
                        if (yesNo == 1)
                        {
                            Ex1(1);
                        }
                        else
                        {
                            double x, c, b, a;
                            Console.Write("Введіть x:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введіть c:");
                            c = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введіть b:");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введіть a:");
                            a = Convert.ToDouble(Console.ReadLine());
                            Ex1(x, c, b, a);
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Із базовими змінами? \n 1.Так \n 2.Ні");
                        int yesNo = Convert.ToInt32(Console.ReadLine());
                        if (yesNo == 1)
                        {
                            Ex2(1);
                        }
                        else
                        {
                            double x, c, b, a;
                            Console.Write("Введіть x:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введіть c:");
                            c = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введіть b:");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введіть a:");
                            a = Convert.ToDouble(Console.ReadLine());
                            Ex1(x, c, b, a);
                        }
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Із базовими змінами? \n 1.Так \n 2.Ні");
                        int yesNo = Convert.ToInt32(Console.ReadLine());
                        if (yesNo == 1)
                        {
                            Ex3(1);
                        }
                        else
                        {
                            double x,b, a;
                            Console.Write("Введіть x:");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введіть b:");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введіть a:");
                            a = Convert.ToDouble(Console.ReadLine());
                            Ex3(x,b, a);
                        }
                        break;
                    }
            }
            //double y1,y2,y3;
            Console.ReadLine();
        }
        static void Ex1(double x , double c ,double b , double a)
        {
            double y = Math.Sqrt(Math.Pow(x, 3) + Math.Pow(a * x, 2) - b * x + c);
            Console.WriteLine("Відповідь:"+ y);
        }
        static void Ex1(int command)
        {
            double x,c,b,a;
            if (command == 1)
            {
                 x = 0.35;
                 c = 0.8;
                 b = c * x;
                 a = x + 0.5 * b;
                 double y = Math.Sqrt(Math.Pow(x, 3) + Math.Pow(a * x, 2) - b * x + c);
                Console.WriteLine("Завдання 1");
                Console.WriteLine("Відповідь: "+ y);
            }
            else
            {
                Console.WriteLine("Упс...");
            }
        }
        static void Ex2(double x, double c, double b, double a)
        {
            double? y = Math.Sqrt(Math.Pow(x, 2) + Math.Sin(x - a * b)) / 3 * c;
            Console.WriteLine("Відповідь:" + y);
        }
        static void Ex2(int command)
        {
            double x, c, b, a;
            if (command == 1)
            {
                x = 0.1;
                a = 0.2;
                b = x - 2 * a;
                c = 2 * b;
                double y = Math.Sqrt(Math.Pow(x, 2) + Math.Sin(x - a * b)) / 3 * c;
                Console.WriteLine("Завдання 2");
                Console.WriteLine("Відповідь: " + y);
            }
            else
            {
                Console.WriteLine("Упс...");
            }
        }
        static void Ex3(double x,double b, double a)
        {
            double? y = Math.Exp(a * x) - 2 * Math.Pow(Math.Pow(x, b) / 3, 1.0 / 3.0);
            Console.WriteLine("Відповідь:" + y);
        }
        static void Ex3(int command)
        {
            double x,b,a;
            if (command == 1)
            {
                x = 6.5;
                a = Math.Sin(x);
                b = a * x - 1;
                double y = Math.Exp(a * x) - 2 * Math.Pow(Math.Pow(x, b) / 3, 1.0 / 3.0);
                Console.WriteLine("Завдання 3");
                Console.WriteLine("Відповідь: " + y);
            }
            else
            {
                Console.WriteLine("Упс...");
            }
        }
        static void DrawMenu()
        {
            Console.WriteLine("Оберіть якую дію виконати");
            Console.WriteLine("1.Вивід всіх завдань із базою");
            Console.WriteLine("2.Вивід всіх завдань із завданням x,c,b,a");
            Console.WriteLine("3.Вар1");
            Console.WriteLine("4.Вар2");
            Console.WriteLine("5.Вар3");
            //Console.WriteLine("6.Stop");
        }
    }
}
