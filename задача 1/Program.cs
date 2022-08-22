using System;
class Task_1
{
    static void Main()
    {
        int a, b, count;

        Console.Write("A: ");
        a = Int32.Parse(Console.ReadLine());
        Console.Write("B: ");
        b = Int32.Parse(Console.ReadLine());

        if (a >= b)
        {
            Console.Write("you enter a >= b");
            return;
        }

        for (int i = a; i <= b; i++)
        {
            Console.Write("{0} ", i);
        }

        count = b - a + 1;
        Console.Write("\ncount: {0} ", count);
    }
}