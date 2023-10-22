//19.Дан радиус окружности. Найти ее диаметр.
using System;

class Task11
{
    static void Main()
    {
        Console.Write("Введите радиус окружности: ");
        double radius = double.Parse(Console.ReadLine());

        double diameter = 2 * radius;

        Console.WriteLine("Диаметр окружности с заданным радиусом равен: " + diameter);
    }
}
