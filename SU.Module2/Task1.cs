using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа должна сосчитать количество введенных пользователем пробелов. 
namespace SU.Module2
{
     public class Task1
    {
        static void Main(string[] args)
        {
            int spaceCount = 0;

            Console.WriteLine("Введите символы. Для завершения введите точку.");

            while (true)
            {
                char inputChar = Console.ReadKey().KeyChar;

                if (inputChar == '.')
                {
                    break; // Если введена точка, завершаем ввод.
                }
                else if (inputChar == ' ')
                {
                    spaceCount++; // Если введен пробел, увеличиваем счетчик.
                }
            }

            Console.WriteLine("\nКоличество введенных пробелов: " + spaceCount);
        }
    }

}
}
