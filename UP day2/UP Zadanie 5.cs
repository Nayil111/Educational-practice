using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число от 1 до 7: ");
        int number = int.Parse(Console.ReadLine());

        string dayOfWeek;

        switch (number)
        {
            case 1:
                dayOfWeek = "Понедельник";
                break;
            case 2:
                dayOfWeek = "Вторник";
                break;
            case 3:
                dayOfWeek = "Среда";
                break;
            case 4:
                dayOfWeek = "Четверг";
                break;
            case 5:
                dayOfWeek = "Пятница";
                break;
            case 6:
                dayOfWeek = "Суббота";
                break;
            case 7:
                dayOfWeek = "Воскресенье";
                break;
            default:
                dayOfWeek = "Неверный день недели";
                break;
        }

        Console.WriteLine("День недели: " + dayOfWeek);
    }
}
