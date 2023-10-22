// 26.	Дано четырехзначное число. Найти:  a.сумму его цифр; b.произведение его цифр
using System;

class Task14
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 1000 && number <= 9999) 
        {
            int digit1 = number % 10;          // Получаем первую цифру
            int digit2 = (number / 10) % 10;   
            int digit3 = (number / 100) % 10;  
            int digit4 = number / 1000;        

            int sum = digit1 + digit2 + digit3 + digit4;       // Сумма цифр
            int product = digit1 * digit2 * digit3 * digit4;  // Произведение цифр

            Console.WriteLine("Сумма цифр: " + sum);
            Console.WriteLine("Произведение цифр: " + product);
        }
        else
        {
            Console.WriteLine("Введите четырехзначное число.");
        }
    }
}

