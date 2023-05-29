using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите три разных числа:");

        Console.Write("Число 1: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Число 2: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.Write("Число 3: ");
        double number3 = double.Parse(Console.ReadLine());

        double sum = 0;

        if (number1 > 0)
        {
            sum += number1;
        }

        if (number2 > 0)
        {
            sum += number2;
        }

        if (number3 > 0)
        {
            sum += number3;
        }

        Console.WriteLine("Сумма положительных чисел: " + sum);
    }
}
