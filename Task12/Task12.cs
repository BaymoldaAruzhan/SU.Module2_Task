//22.	Даны два целых числа. Найти: a.их среднее арифметическое; b.их среднее геометрическое.
using System;

class Task12
{
    static void Main()
    {
        Console.Write("Введите первое целое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе целое число: ");
        int num2 = int.Parse(Console.ReadLine());

        // Среднее арифметическое
        double averageArithmetic = (num1 + num2) / 2.0;

        // Среднее геометрическое
        double averageGeometric = Math.Sqrt(num1 * num2);

        Console.WriteLine("Среднее арифметическое: " + averageArithmetic);
        Console.WriteLine("Среднее геометрическое: " + averageGeometric);
    }
}

