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
