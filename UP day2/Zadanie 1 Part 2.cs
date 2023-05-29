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
        int number = 200;
        while (number % 17 != 0)
        {
            number++;
        }

        Console.WriteLine("Минимальное число, большее 200 и делющееся нацело на 17: " + number);
    }
}
