using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Session2
    {
        public static void Main2()
        {
            EX1();
            EX2();
            EX3();
            Console.ReadKey();
        }
        public static void EX1()
        {
            bool exit = false;
            double celius;
            do
            {
                Console.WriteLine("Enter your Celius: ");
                while (!double.TryParse(Console.ReadLine(), out celius))
                {
                    Console.WriteLine("Enter value of celius again!!!");
                }
                double K = celius + 273;
                double F = celius * 1.8 + 32;
                Console.WriteLine($"{celius} C. Convert to {K} K or {F} F");
                exit = true;
            } while (!exit);
        }
        public static void EX2()
        {
            bool exit = false;
            double radius;
            do
            {
                Console.WriteLine("Enter value of radius: ");
                while (!double.TryParse(Console.ReadLine(), out radius))
                {
                    Console.WriteLine("Enter your radius again!!!");
                }
                double surface, volume;
                surface = 4 * Math.PI * Math.Pow(radius, 2);
                volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);

                Console.WriteLine($"surface: {Math.Round(surface, 2)}\nvolumne: {Math.Round(volume, 2)}");

                exit = true;
            } while (!exit);
        }
        public static void EX3()
        {
            bool exit = false;
            double a, b;
            do
            {
                Console.WriteLine("Enter value of a: ");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Enter your a again!!!");
                }
                Console.WriteLine("Enter value of b: ");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Enter your radius again!!!");
                }
                Console.WriteLine($"{a} - {b} = {a - b}");
                Console.WriteLine($"{a} + {b} = {a + b}");
                Console.WriteLine($"{a} * {b} = {a * b}");
                Console.WriteLine($"{a} / {b} = {a / b}");
                Console.WriteLine($"{a} mod {b} = {a % b}");

                exit = true;
            } while (!exit);
        }
    }
}


