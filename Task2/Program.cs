//2.Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым). 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер трамвайного билета (6-значное число): ");
        string ticketNumberString = Console.ReadLine();

        if (ticketNumberString.Length == 6 && int.TryParse(ticketNumberString, out int ticketNumber))
        {
            int firstHalf = ticketNumber / 1000; // Первые три цифры
            int secondHalf = ticketNumber % 1000; // Последние три цифры

            int sumFirstHalf = SumOfDigits(firstHalf);
            int sumSecondHalf = SumOfDigits(secondHalf);

            if (sumFirstHalf == sumSecondHalf)
            {
                Console.WriteLine("Этот билет счастливый!");
            }
            else
            {
                Console.WriteLine("Этот билет не счастливый.");
            }
        }
        else
        {
            Console.WriteLine("Введите корректное 6-значное число.");
        }
    }

    // Метод для вычисления суммы цифр в числе
    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
