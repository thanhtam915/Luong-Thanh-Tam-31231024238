using System.Formats.Asn1;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

internal class Session1
{
    private static void Main1(string[] args)
    {
        bool exit = false;
        int choice;
        do
        {
            Console.WriteLine(
            "0. Exit\n" +
            "1. To Add/ Sum 2 numbers\n" +
            "2. Swap values of two variables\n" +
            "3. to Multiply two Floating Point Numbers\n" +
            "4. to convert feet to meter\n" +
            "5. to convert Celsius to Fahrenheit and vice versa\n" +
            "6. to find the Size of data type\n" +
            "7. to Print ASCII Value (tip: read character, print number of this char)\n" +
            "8. to Calculate Area of Circle\n" +
            "9. to Calculate Area of Square\n" +
            "10.to convert days to years, weeks and days\n");

            Console.WriteLine("Enter number your choice: ");

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Enter your requirement again!!!......");
            }
            switch (choice)
            {
                case 1:
                    EX1();
                    break;
                case 2:
                    EX2();
                    break;
                case 3:
                    EX3();
                    break;
                case 4:
                    EX4();
                    break;
                case 5:
                    EX5();
                    break;
                case 6:
                    EX6();
                    break;
                case 7:
                    EX7();
                    break;
                case 8:
                    EX8();
                    break;
                case 9:
                    EX9();
                    break;
                case 10:
                    EX10();
                    break;
                case 0:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Value of choice belong to (0,10)");
                    break;
            }

        } while (!exit);

        Console.WriteLine("Programming is ending...");

        Console.ReadKey();

    }
    public static void EX1()
    {
        bool exit = false;
        double a, b;
        do
        {
            Console.WriteLine("Enter value a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Enter your value a again!!!......");
            }
            Console.WriteLine("Enter value b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Enter your value b again!!!.....");
            }
            Console.WriteLine($"{a} + {b} = {a + b}");
            exit = true;
        } while (!exit);
    }
    public static void EX2()
    {
        bool exit = false;
        double a, b;
        do
        {
            Console.WriteLine("Enter value a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Enter a again!!!");
            }
            Console.WriteLine("Enter value b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Enter b again!!!");
            }
            double temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a after: {a}");
            Console.WriteLine($"b after: {b}");
            exit = true;

        } while (!exit);
    }
    public static void EX3()
    {
        double a, b;
        Console.WriteLine("Enter value a: ");
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Enter a again!!!");
        }
        Console.WriteLine("Enter value b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Enter b again");
        }
        Console.WriteLine($"{a} x {b} = {a * b}");
    }
    public static void EX4()
    {
        bool exit = false;
        double feet;
        do
        {
            Console.Write("Enter value of feet: ");
            while (!double.TryParse(Console.ReadLine(), out feet))
            {
                Console.WriteLine("Enter value of feet again!...");
            }
            double meter;
            meter = feet * 0.3048;
            Console.WriteLine($"{feet} feets = {meter} meters");

            exit = true;
        } while (!exit);

    }
    public static void EX5()
    {
        bool exit = false;
        double Celius;
        const double f = 1.8;
        do
        {
            Console.WriteLine("Enter Celius: ");
            while (!double.TryParse(Console.ReadLine(), out Celius))
            {
                Console.WriteLine("Enter Celius again!!!");
            }
            double F;
            F = Celius * f + 32;
            Console.WriteLine($"{Celius} C = {F} F");

            exit = true;
        } while (!exit);
    }
    public static void EX6()
    {
        Console.WriteLine("sizeof(char)     : {0}", sizeof(char));
        Console.WriteLine("sizeof(byte)     : {0}", sizeof(byte));
        Console.WriteLine("sizeof(sbyte)    : {0}", sizeof(sbyte));
        Console.WriteLine("sizeof(float)    : {0}", sizeof(float));
        Console.WriteLine("sizeof(ushort)   : {0}", sizeof(ushort));
        Console.WriteLine("sizeof(double)   : {0}", sizeof(double));
        Console.WriteLine("sizeof(int)      : {0}", sizeof(int));
        Console.WriteLine("sizeof(bool)     : {0}", sizeof(bool));
        Console.WriteLine("sizeof(short)    : {0}", sizeof(short));
    }
    public static void EX7()
    {
        Console.WriteLine("Enter your character: ");
        int input = int.Parse(Console.ReadLine());
        char inputChar = (char)input;
        Console.WriteLine($"{input} convert to char: {inputChar}");
    }
    public static void EX8()
    {
        bool exit = false;
        uint radius;
        do
        {
            Console.WriteLine("Enter value of radius: ");
            while (!uint.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Enter radius again!!!");
            }
            double area;
            area = Math.Round(Math.Pow(radius, 2) * Math.PI, 2);
            Console.WriteLine($"Area of circle radius = {radius}: {area}");

            exit = true;
        } while (!exit);
    }
    public static void EX9()
    {
        bool exit = false;
        uint size;
        do
        {
            Console.WriteLine("Enter radius: ");
            while (!uint.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Enter value of radius!!!");
            }
            double area;
            area = Math.Round(Math.Pow(size, 2), 2);
            Console.WriteLine($"Area of Square with size = {size}: {area}");

            exit = true;

        } while (!exit);
    }
    public static void EX10()
    {
        bool exit = false;
        int days;
        do
        {
            Console.WriteLine("Enter numbers of day: ");
            while (!int.TryParse(Console.ReadLine(), out days))
            {
                Console.WriteLine("Enter number of days again!");
            }
            int year, week, day;
            year = days / 365;
            week = (days - year * 365) / 7;
            day = (days - year * 365 - week * 7);
            Console.WriteLine($"{year} year {week} week {day} days");

            exit = true;

        } while (!exit);
    }
}