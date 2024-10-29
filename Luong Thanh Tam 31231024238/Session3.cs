using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Session3
    {
        public static void Main3()
        {
            //Ex2();
            //Ex3();
            Ex5();


            Console.ReadKey();
        }
        public static void Ex2()
        {
            Console.WriteLine("y\t x = y^2 + 2y + 1");
            Console.WriteLine("----------------------");

            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine("{0}\t {1}", y, x);
            }
        }
        public static void Ex3()
        {
            Console.WriteLine("Enter distance (Km): ");
            double distanceKm = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter time (Hours): ");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time (minutes): ");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time (seconds): ");
            int seconds = int.Parse(Console.ReadLine());

            double time = hours + (minutes / 60.0) + (seconds / 3600.0);

            double SpeedKmPerHour = distanceKm / time;
            double SpeedMilesPerHour = distanceKm * 0.621371 / time;
            Console.WriteLine("\nSpeed: ");
            Console.WriteLine($"SpeedKmPerHour: {SpeedKmPerHour}");
            Console.WriteLine($"SpeedMilesPerHour: {SpeedMilesPerHour}");
        }
        public static void Ex5()
        {
            Console.Write("Enter a character: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if ("AEIOUaeiou".IndexOf(input) >= 0)
            {
                Console.WriteLine($"{input} is a vowel.");
            }
            else if (char.IsDigit(input))
            {
                Console.WriteLine($"{input} is a digit.");
            }
            else if (char.IsLetter(input))
            {
                Console.WriteLine($"{input} is a consonant.");
            }
            else
            {
                Console.WriteLine($"{input} is a symbol.");
            }
        }
    }
}
