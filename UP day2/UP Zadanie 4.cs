using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int x = int.Parse(Console.ReadLine());

        if (x > 10)
        {
            x *= 2;
        }

        Console.WriteLine("Результат: " + x);
    }
}
