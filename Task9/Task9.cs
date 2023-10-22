//17.вычисления значения функции x= 12a2+7a-16 при любом значении а.
using System;

class Task8
{
    static void Main()
    {
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());

        double x = 12 * Math.Pow(a, 2) +7 * a - 16;

        Console.WriteLine("Значение функции x= 12a2+7a-16 при a = " + a + " равно " + x);
    }
}
