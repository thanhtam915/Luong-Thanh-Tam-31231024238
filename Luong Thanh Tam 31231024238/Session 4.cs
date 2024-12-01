using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Session_4
    {
        public static void Main4()
        {
            bool exit = false;
            int choice;
            do
            {
                Console.WriteLine(
                    "1. Odd or even number\n" +
                    "2. Find max in array\n" +
                    "3. Tim toa do phan tu\n" +
                    "4. Kiem tra tam giac can, deu, khong deu\n" +
                    "5. Sum/ Average of number array \n" +
                    "6. Bang cuu chuong\n" +
                    "7. In tam giac so\n" +
                    "8. Day so\n" +
                    "9. Perfect number\n" +
                    "10. Find square number\n"
                    );
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please enter your choice again!!! (integer)");
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
            Console.ReadKey();
        }

        private static void EX10()
        {
            int n10;
            Console.WriteLine("Enter a number");
            while (!int.TryParse(Console.ReadLine(), out n10))
            { Console.WriteLine("Invalid input!!"); }

            if (n10 < 2)
            {
                Console.WriteLine($"{n10} khong phai la so nguyen to");
            }
            int count = 0;
            for (int i = 2; i < Math.Sqrt(n10); i++)
            {
                if (n10 % 2 == 0)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"{n10} la so nguyen to");
            }
            else
                Console.WriteLine($"{n10} khong phai la so nguyen to");
        }

        private static void EX9()
        {
            int a, b;
            Console.WriteLine("Enter value of a");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input");
            }
            Console.WriteLine("Enter value of b");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input");
            }
            List<int> perfectlist = new List<int>();
            for (int i = a; i <= b; i++)
            {
                int sum = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == i)
                {
                    perfectlist.Add(i);
                }
            }
            Console.WriteLine($"Mang co {perfectlist.Count} perfect numbers: {string.Join(", ", perfectlist)}");
        }

        private static void EX8()
        {
            int n8;
            Console.WriteLine("Enter your number");
            while (!int.TryParse(Console.ReadLine(), out n8))
            {
                Console.WriteLine("Enter number again. Invalid input");
            }
            double sum = 1;
            Console.Write("1");
            for (int i = 2; i <= n8; i++)
            {
                Console.Write($" + 1/{i}");
                double temp = 1.0 / i;
                sum += temp;
            }
            Console.WriteLine($" = {sum}");
        }

        private static void EX7()
        {
            int n7;
            Console.WriteLine("Enter your numbers");
            while (!int.TryParse(Console.ReadLine(), out n7))
            {
                Console.WriteLine("Enter you value again. Invalid Input!!!");
            }
            for (int i = 1; i <= n7; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        private static void EX6()
        {
            int n6;
            Console.WriteLine("Enter your number: ");
            while (!int.TryParse(Console.ReadLine(), out n6))
            {
                Console.WriteLine("Please enter again! Invalid input!!!");
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n6} x {i} = {n6 * i}");
            }
        }

        private static void EX5()
        {
            Console.WriteLine("Enter your array number seperated by spaces: ");
            string n5 = Console.ReadLine();
            string[] stringarray5 = n5.Split(" ");
            int[] numberarray5 = Array.ConvertAll(stringarray5, int.Parse);
            int sum = 0;
            for (int i = 0; i < numberarray5.Length; i++)
            {
                sum += numberarray5[i];
            }
            double avg = sum / numberarray5.Length;
            Console.WriteLine($"Sum: {sum}\nAverage: {avg}");
        }
        private static void EX4()
        {
            bool exit = false;
            int[] numberarray3;
            do
            {
                Console.WriteLine("Enter 3 size of triangle seperated by spaces: ");
                string n3 = Console.ReadLine();
                string[] n3array = n3.Split(" ");
                numberarray3 = Array.ConvertAll(n3array, int.Parse);
                if (numberarray3[0] + numberarray3[1] > numberarray3[2] &&
                    numberarray3[0] + numberarray3[2] > numberarray3[1] &&
                    numberarray3[1] + numberarray3[2] > numberarray3[0])
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Your these 3 numbers are not a triangle!!!");
                }
            } while (!exit);
            if (numberarray3[0] == numberarray3[1] || numberarray3[0] == numberarray3[2] ||
                numberarray3[1] == numberarray3[2])
            {
                if (numberarray3[0] == numberarray3[1] && numberarray3[0] == numberarray3[2])
                {
                    Console.WriteLine("Tam giac deu");
                }
                else
                {
                    Console.WriteLine("Tam giac can");
                }
            }
            else
            {
                Console.WriteLine("Tam giac khong deu");
            }
        }

        private static void EX3()
        {
            bool exit = false;
            int a, b;
            do
            {
                Console.WriteLine("Enter value of x: ");
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Enter value of a again!!!");
                }
                Console.WriteLine("Enter value of y: ");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Enter value of y again!!!");
                }
                if (a > 0)
                {
                    if (b > 0)
                    {
                        Console.WriteLine($"({a} , {b}) goc phan tu thu nhat");
                    }
                    else
                    {
                        Console.WriteLine($"({a} , {b}) goc phan tu thu tu");
                    }
                }
                else
                {
                    if (b > 0)
                    {
                        Console.WriteLine($"({a} , {b}) goc phan tu thu hai");
                    }
                    else
                    {
                        Console.WriteLine($"({a} , {b}) goc phan tu thu ba");
                    }
                }
                exit = true;
            } while (!exit);
        }

        private static void EX2()
        {
            string[] array2;
            int[] arraynumber2;
            bool exit = false;
            do
            {
                Console.Write("Enter your array number seperated by spaces: ");
                string n2 = Console.ReadLine();
                array2 = n2.Split(" ");
                arraynumber2 = Array.ConvertAll(array2, int.Parse);
                int max = arraynumber2[0];
                for (int i = 0; i < arraynumber2.Length; i++)
                {
                    if (max < arraynumber2[i])
                    {
                        max = arraynumber2[i];
                    }
                }
                for (int j = 0; j < arraynumber2.Length; j++)
                {
                    if (arraynumber2[j] == max)
                        Console.WriteLine($"Place of max in this array is {j}");
                }
                exit = true;
            } while (!exit);
        }

        private static void EX1()
        {
            bool exit = false;
            int n1;
            do
            {
                Console.WriteLine("Enter your number: ");
                while (!int.TryParse(Console.ReadLine(), out n1))
                {
                    Console.WriteLine("Enter your number again!!!");
                }
                if (n1 % 2 == 0)
                {
                    Console.WriteLine($"{n1} is an even number");
                }
                else
                {
                    Console.WriteLine($"{n1} is an odd number");
                }
                exit = true;
            } while (!exit);
        }
    }
}
