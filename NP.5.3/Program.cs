using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть номер завдання (1-9):");
        int task = int.Parse(Console.ReadLine());
        //доробити окремий медот свич и виконувати все через for
        switch (task)
        {
            case 1:
                {
                    Console.WriteLine("Введіть два цілих числа:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int sum = a + b;
                    Console.WriteLine($"Сума чисел: {sum}");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Введіть два цілих числа:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int product = a * b;
                    Console.WriteLine($"Добуток чисел: {product}");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Введіть два цілих числа:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    double average = (a + b) / 2.0;
                    Console.WriteLine($"Середнє значення чисел: {average}");
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Введіть два цілих числа:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int difference = a - b;
                    Console.WriteLine($"Різниця чисел (a - b): {difference}");
                    break;
                }
            case 5:
                {
                    Console.WriteLine("Введіть два цілих числа:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int difference = b - a;
                    Console.WriteLine($"Різниця чисел (b - a): {difference}");
                    break;
                }
            case 6:
                {
                    Console.WriteLine("Введіть ціле число:");
                    int a = int.Parse(Console.ReadLine());
                    if (a % 2 == 0)
                    {
                        int result = a / 2;
                        Console.WriteLine($"Число {a} кратне 2. Результат ділення на 2: {result}");
                    }
                    else
                    {
                        int result = a + 1;
                        Console.WriteLine($"Число {a} не кратне 2. Результат додавання 1: {result}");
                    }
                    break;
                }
            case 7:
                {
                    Console.WriteLine("Введіть два цілих числа:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    if (a < 0 && b > 0)
                    {
                        a += 5;
                        b += 1;
                        Console.WriteLine($"Оновлені числа: {a}, {b}. Їх сума: {a + b}");
                    }
                    else if (a > 0 && b < 0)
                    {
                        a += 1;
                        b += 5;
                        Console.WriteLine($"Оновлені числа: {a}, {b}. Їх сума: {a + b}");
                    }
                    else if (a < 0 && b < 0)
                    {
                        int product = a * b;
                        Console.WriteLine($"Добуток чисел: {product}");
                    }
                    else
                    {
                        int difference = a - b;
                        Console.WriteLine($"Різниця чисел: {difference}");
                    }
                    break;
                }
            case 8:
                {
                    Console.WriteLine("Введіть два цілих числа:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    if (a % 2 == 0 && b % 2 != 0)
                    {
                        b += 1;
                        a += 2;
                        Console.WriteLine($"Початкові числа: a={a - 2}, b={b - 1}. Оновлені числа: a={a}, b={b}");
                    }
                    else if (a % 2 != 0 && b % 2 == 0)
                    {
                        a += 1;
                        b += 2;
                        Console.WriteLine($"Початкові числа: a={a - 1}, b={b - 2}. Оновлені числа: a={a}, b={b}");
                    }
                    else if (a % 2 == 0 && b % 2 == 0)
                    {
                        int sum = a + b;
                        Console.WriteLine($"Сума чисел: {sum}");
                    }
                    else
                    {
                        Console.WriteLine($"Число {a} і {b} непарні.");
                    }
                    break;
                }
            case 9:
                {
                    Console.WriteLine("Введіть три цілих числа:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int c = int.Parse(Console.ReadLine());

                    if (a != b && b != c && a != c)
                    {
                        int min = Math.Min(a, Math.Min(b, c));
                        int max = Math.Max(a, Math.Max(b, c));
                        int mid = a + b + c - min - max;
                        Console.WriteLine($"Мінімальне число: {min}, середнє число: {mid}, найбільше число: {max}");
                    }
                    else if (a == b && b == c)
                    {
                        int product = a * b * c;
                        Console.WriteLine($"Всі числа однакові. Їх добуток: {product}");
                    }
                    else
                    {
                        int min = Math.Min(a, Math.Min(b, c));
                        int sumOfSame = (a == b || a == c) ? a + a : b + b;
                        int productOfSame = (a == b || a == c) ? a * a : b * b;
                        Console.WriteLine($"Найменше число: {min}, сума однакових: {sumOfSame}, добуток однакових: {productOfSame}");
                    }
                    break;
                }
            default:
                {
                    Console.WriteLine("Невірний номер завдання. Введіть число від 1 до 9.");
                    break;
                }
        }
    }
}
