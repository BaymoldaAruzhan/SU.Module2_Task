//16.	вычисления значения функции y= 7x2-3x+6 при любом значении x;
using System;

class Task8
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());

        double y = 7 * Math.Pow(x, 2) - 3 * x + 6;

        Console.WriteLine("Значение функции y = 7x^2 - 3x + 6 при x = " + x + " равно " + y);
    }
}
