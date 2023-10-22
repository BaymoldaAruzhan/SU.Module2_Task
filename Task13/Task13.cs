//23.	Известны объем и масса тела. Определить плотность материала этого тела.
using System;

class Task13
{
    static void Main()
    {
        Console.Write("Введите массу тела (в килограммах): ");
        double mass = double.Parse(Console.ReadLine());

        Console.Write("Введите объем тела (в кубических метрах): ");
        double volume = double.Parse(Console.ReadLine());

        double density = mass / volume;

        Console.WriteLine("Плотность материала тела: " + density + " килограммов на кубический метр.");
    }
}
