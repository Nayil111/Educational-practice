using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1

            string a = "Hello";
            string b = " World";
            string c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();

            //Задание 2
            int J = 10;
            int B = 10;
            int A = 7;
            Console.WriteLine(J + B);
            Console.WriteLine(B - A);
            Console.ReadKey();
            
            //Задания 3
            Console.WriteLine("Введите свое ФИО");
            string[] fio = Console.ReadLine().Split(' ');
            Console.WriteLine(fio[0] + " " + fio[1][0] + " " + fio[2][0]); //Вот, фамилия и инициалы

            //Задание 4
            Console.WriteLine("Введите здоровье, атаку и защиту героя: ");
            int HPplayer = Convert.ToInt32(Console.ReadLine());
            int DamagePlayer = Convert.ToInt32(Console.ReadLine());
            int Shield = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите здоровье, атаку и защиту противника: ");
            int HPEnemy = Convert.ToInt32(Console.ReadLine());
            int DamageEnemy = Convert.ToInt32(Console.ReadLine());
            int ShieldEnemy = Convert.ToInt32(Console.ReadLine());

            HPplayer = DamageEnemy / Shield;
            HPEnemy = DamagePlayer / ShieldEnemy;

            int damageDealHero = DamagePlayer - ShieldEnemy;
            int damageDealEnemy = DamageEnemy - Shield;

            Console.WriteLine("У игрока осталось: " + HPplayer + " здоровья.");
            Console.WriteLine("У противника осталось: " + HPEnemy + " здоровья.");
            Console.WriteLine("Игрок нанес: " + damageDealHero + " урона.");
            Console.WriteLine("Противник нанес: " + damageDealEnemy + " урона.");

            Console.ReadKey();
        }



        }

    }



 

