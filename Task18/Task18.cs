//11.Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
//a.А или В;
//b.А и В;
//c.В или С

using System;

class Task18
{
    static void Main()
    {
        bool A = true;
        bool B = false;
        bool C = false;

        // a. А или В
        bool resultA = A || B;
        Console.WriteLine("Значение А или В: " + resultA);

        // b. А и В
        bool resultB = A && B;
        Console.WriteLine("Значение А и В: " + resultB);

        // c. В или С
        bool resultC = B || C;
        Console.WriteLine("Значение В или С: " + resultC);
    }
}
