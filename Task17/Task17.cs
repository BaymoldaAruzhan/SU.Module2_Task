//21.	вычисления значения функции z=x3-2.5xy+1.78x2-2.5y+1 при любых значениях х и y;
using System;

class Task17
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите значение y: ");
        double y = double.Parse(Console.ReadLine());

        double z = x * x * x - 2.5 * x * y + 1.78 * x * x - 2.5 * y + 1;

        Console.WriteLine("Значение функции z = x^3 - 2.5xy + 1.78x^2 - 2.5y + 1 при x = " + x + " и y = " + y + " равно " + z);
    }
}

