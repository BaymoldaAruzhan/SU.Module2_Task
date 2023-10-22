//9.С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
using System;

class Task6
{
    static void Main()
    {
        int days = 234;
        int weeks = days / 7;

        Console.WriteLine("За " + days + " дней прошло " + weeks + " полных недель.");
    }
}
