//18.	Дана сторона квадрата. Найти его периметр.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину стороны квадрата: ");
        double sideLength = double.Parse(Console.ReadLine());

        double perimeter = 4 * sideLength;

        Console.WriteLine("Периметр квадрата равен: " + perimeter);
    }
}
