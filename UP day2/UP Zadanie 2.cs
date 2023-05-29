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

        double maxNumber = number1;

        if (number2 > maxNumber)
        {
            maxNumber = number2;
        }

        if (number3 > maxNumber)
        {
            maxNumber = number3;
        }

        Console.WriteLine("Наибольшее число: " + maxNumber);
    }
}
