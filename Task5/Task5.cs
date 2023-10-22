//5.Дано расстояние в сантиметрах. Найти число полных метров в нем.
using System;

class Task5
{
    static void Main()
    {
        Console.Write("Введите расстояние в сантиметрах: ");
        int distanceInCentimeters = int.Parse(Console.ReadLine());

        int fullMeters = distanceInCentimeters / 100;

        Console.WriteLine("Число полных метров: " + fullMeters);
    }
}
