/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main(string[] args)
    {
        int initialDistance = 10; // Начальное расстояние
        double distance = initialDistance; // Текущее расстояние
        int dayCount = 1; // Счетчик дней

        // Определяем день, когда человек пробежит 20 км
        while (distance < 20)
        {
            distance += distance * 0.05;
            dayCount++;
        }

        Console.WriteLine("Человек пробежит 20 км на " + dayCount + " день");

        // Сбрасываем значения
        distance = initialDistance;
        dayCount = 1;

        // Определяем день, когда суммарный пробег достигнет 100 км
        while (distance < 100)
        {
            distance += distance * 0.05;
            dayCount++;
        }

        Console.WriteLine("Суммарный пробег будет 100 км на " + dayCount + " день");
    }
}