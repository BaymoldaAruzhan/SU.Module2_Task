//31.	Известны два расстояния: одно в километрах, другое — в футах ( 1 фут 0,305 м ). Какое из расстояний меньше?
using System;

class Task16
{
    static void Main()
    {
        Console.Write("Введите расстояние в километрах: ");
        double kilometers = double.Parse(Console.ReadLine());

        Console.Write("Введите расстояние в футах: ");
        double feet = double.Parse(Console.ReadLine());

        // Преобразование расстояния в футах в километры
        double feetInKilometers = feet * 0.305;

        if (kilometers < feetInKilometers)
        {
            Console.WriteLine("Расстояние в километрах меньше.");
        }
        else if (kilometers > feetInKilometers)
        {
            Console.WriteLine("Расстояние в футах меньше.");
        }
        else
        {
            Console.WriteLine("Расстояния равны.");
        }
    }
}

