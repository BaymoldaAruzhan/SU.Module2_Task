
using System;

class Task7
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 10 && number <= 99) 
        {
            int tens = number / 10; 
            int units = number % 10; 
            int sum = tens + units;   
            int product = tens * units; 

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
