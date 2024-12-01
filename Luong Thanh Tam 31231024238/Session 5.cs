using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Session_5
    {
        public static void Main5()
        {
            Console.WriteLine("Nhap day so cach nhau bang khoang trang");
            string a = Console.ReadLine();
            string[] astring = a.Split(" ");
            int[] numberArray = Array.ConvertAll(astring, int.Parse);

            FindMax(numberArray);

            bool exit1 = false;
            int n2;
            do
            {
                Console.WriteLine("Nhap so nguyen");
                while (!int.TryParse(Console.ReadLine(), out n2))
                {
                    Console.WriteLine("Invalid input");
                }
                exit1 = true;
            } while (!exit1);
            int frac = Fractorial(n2); Console.WriteLine($"Giai thua cua {n2} la {frac}");

            bool res = IsPrime(n2);
            if (res == true)
            {
                Console.WriteLine($"{n2} is a prime number");
            }
            else
            {
                Console.WriteLine($"{n2} is not a prime number");
            }


            bool exit2 = false;
            int n3;
            do
            {
                Console.WriteLine("Nhap N");
                while (!int.TryParse(Console.ReadLine(), out n3))
                {
                    Console.WriteLine("Invalid input n3 (N)");
                }
                exit2 = true;
            } while (!exit2);

            PrintNPrime(n2, n3);

            Console.WriteLine();
            perfectNumber(n3);


            Console.ReadKey();
        }

        public static void perfectNumber(int n3)
        {
            int sum = 0;
            for (int i = 1; i < n3; i++)
            {
                if (n3 % i == 0)
                    sum += i;
            }
            if (sum == n3)
                Console.WriteLine($"{n3} is a perfect number");
            else
                Console.WriteLine($"{n3} is not a perfect number");

            for (int i = 1; i <= 1000; i++)
            {
                int sum1 = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        sum1 += j;
                }
                if (sum1 == i)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        public static void PrintNPrime(int n2, int n3)
        {
            if (n2 > 2 && n3 > 0)
            {
                for (int i = 2; i <= n2; i++)
                {
                    if (IsPrime(i) == true)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine("\n--------------------------------");
                int count = 0;
                int num = 2;
                do
                {
                    if (IsPrime(num) == true)
                    {
                        Console.Write($"{num} ");
                        num++;
                        count++;
                    }
                    else
                    {
                        num++;
                    }
                } while (count < n3);
            }
            else
            {
                Console.WriteLine("Invalid input. n > 1 and N >0");
            }
        }

        public static int Fractorial(int n2)
        {
            int mul = 1;
            if (n2 <= 0)
            {
                Console.WriteLine($"{n2} <= 0. Khong ton tai giai thua!!!");
            }
            else
            {
                for (int i = 1; i <= n2; i++)
                {
                    mul *= i;
                }
            }
            return mul;
        }

        public static void FindMax(int[] numberArray)
        {
            int max = numberArray[0];
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] > max)
                {
                    max = numberArray[i];
                }
            }
            Console.WriteLine($"Max value in this array is {max}");
        }

        public static bool IsPrime(int n2)
        {
            int count = 0;
            if (n2 <= 1)
                return false;
            else
            {
                for (int i = 2; i < n2 / 2; i++)
                {
                    if (n2 % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static void Pangram(string input)
        {
            input = input.ToLower();

            bool[] alphabetTracker = new bool[26];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c >= 'a' && c <= 'z')
                {
                    alphabetTracker[c - 'a'] = true;
                }
            }
            for (int i = 0; i < alphabetTracker.Length; i++)
            {
                if (!alphabetTracker[i])
                {
                    Console.WriteLine("This string is not a pangram.");
                    return;
                }
            }

            Console.WriteLine("This string is a pangram.");
        }
    }
}
