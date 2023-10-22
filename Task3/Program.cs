//3.	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        string convertedString = ConvertCase(inputString);

        Console.WriteLine("Конвертированная строка: " + convertedString);
    }

    static string ConvertCase(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = (char)(charArray[i] + 32); // Конвертируем верхний регистр в нижний
            }
            else if (char.IsLower(charArray[i]))
            {
                charArray[i] = (char)(charArray[i] - 32); // Конвертируем нижний регистр в верхний
            }
        }

        return new string(charArray);
    }
}
