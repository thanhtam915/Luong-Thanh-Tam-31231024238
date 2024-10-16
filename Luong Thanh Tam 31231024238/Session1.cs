internal class Program
{
    private static void Main1()
    {
        Console.WriteLine(@"Choose your function: 
        1. Add Two Numbers
        2. Swap Values of Two Variables
        3. Multiply Two Floating Point Numbers
        4. Convert feet to meter
        5. Celcius to Farenheit and vice versa
        6. Find the size of data types
        7. Print ASCII value
        8. Calculate area of circle
        9. Calculate area of square
        10. Convert days to year, week, days");
        Question_1();
        //Question_2();
        //Question_3();
        //Question_4();
        //Question_5();
        //Question_6();
        //Question_7();
        //Question_8();
        //Question_9();
        //Question_10();

        Console.ReadKey();
    }
    private static void Question_1()
    {
        Console.Write("Enter your a number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter your a number: ");
        int b = int.Parse(Console.ReadLine());
        int c = a + b;
        Console.Write($"{a} + {b} = {c}");

    }
    private static void Question_2()
    {
        Console.Write("Enter number a: ");
        string a = Console.ReadLine();
        Console.Write("Enter number b: ");
        string b = Console.ReadLine();

        Console.WriteLine($"Before a: {a} , b: {b}");

        string c = a;
        a = b;
        b = c;

        Console.WriteLine($"After a: {a} , b: {b}");
    }

    private static void Question_3()
    {
        Console.Write("please, enter your number a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("please, enter your number b: ");
        float b = float.Parse(Console.ReadLine());

        float c = a * b;
        Console.WriteLine(c);
    }

    private static void Question_4()
    {
        const float feetToMeter = 0.3408f;
        Console.Write("Nhap so feet: ");
        float feet = float.Parse(Console.ReadLine());

        float meter = feet * feetToMeter;

        Console.WriteLine($"{feet} = {meter}");
    }
    private static void Question_5()
    {
        const float f = 1.8f;
        Console.Write("Nhap so do C: ");
        float C = float.Parse(Console.ReadLine());

        float DoF = C * f + 32;
        Console.WriteLine(DoF);
    }
    private static void Question_6()
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
    private static void Question_7()
    {
        Console.Write("Nhap ki tu vao: ");
        int inputKey = Console.Read();
        char character = (char)inputKey;
        Console.WriteLine($"Gia tri ASCII cua '{character}' la {inputKey}");
    }
    private static void Question_8()
    {
        Console.Write("Nhap ban kinh hinh tron: ");
        double radius = double.Parse(Console.ReadLine());
        double areaCircle = radius * radius * Math.PI;
        Console.WriteLine($"Dien tich hinh tron la {areaCircle}");
    }
    private static void Question_9()
    {
        Console.Write("Nhap do dai hinh vuong: ");
        double side = double.Parse(Console.ReadLine());
        double areaSquare = side * side;
        Console.WriteLine($"Dien tich hinh vuong {areaSquare}");
    }
    private static void Question_10()
    {
        Console.Write("Nhap so ngay: ");
        int days = int.Parse(Console.ReadLine());
        int year = days / 365;
        int wd = days - year * 365;
        int week = wd / 7;
        int day = days / 7;
        Console.WriteLine($"{days} ngay co: {year} years, {week} weeks, {day} days");
    }
}