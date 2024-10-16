using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Session2
    {
        private static void Main2()
        {
            //Ex1();
            //Ex2();
            Ex3();

            Console.ReadKey();
        }

        private static void Ex1()
        {
            Console.WriteLine("Enter your Celius: ");
            double Celius = double.Parse(Console.ReadLine());
            double K = Celius + 273;
            double F = Celius * 1.8 + 32;
            Console.WriteLine($"Your Celius is {Celius}. Convert to K = {K} and F = {F}");

            Console.ReadKey();
        }
        private static void Ex2()
        {
            Console.WriteLine("Enter your radius:");
            double radius = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Sqrt(radius);
            double volume = 4 / 3 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Your radius = {radius} . Result: Surface = {surface} , Volume = {volume}");
        }
        private static void Ex3()
        {
            Console.WriteLine("Enter your first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second value: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} mod {b} = {a % b}");
        }
    }
}
