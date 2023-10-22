//25.	Дано двузначное число. Найти: a.число десятков в нем;b.число единиц в нем;c.сумму его цифр;d.произведение его цифр
using System;

class Task15
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 10 && number <= 99) // Проверка, что число двузначное
        {
            int tens = number / 10;  // Находим число десятков
            int units = number % 10; // Находим число единиц
            int sum = tens + units;   // Находим сумму цифр
            int product = tens * units; // Находим произведение цифр

            Console.WriteLine("Число десятков: " + tens);
            Console.WriteLine("Число единиц: " + units);
            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + product);
        }
        else
        {
            Console.WriteLine("Введите двузначное число.");
        }
    }
}
