//1.Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов. 
using System;

class Program
{
    static void Main()
    {
        char inputChar;
        int spaceCount = 0;

        Console.WriteLine("Введите текст. Для завершения введите точку (.)");

        do
        {
            inputChar = Console.ReadKey().KeyChar;
            if (inputChar == ' ')
            {
                spaceCount++;
            }
        } while (inputChar != '.');

        Console.WriteLine("\nКоличество пробелов: " + spaceCount);
    }
}
