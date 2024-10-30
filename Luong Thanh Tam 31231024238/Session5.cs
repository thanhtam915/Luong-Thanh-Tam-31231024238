using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Session5
    {
        public static void Main()
        {
            //EX1
            //Console.WriteLine("Nhap 3 chu so cach nhau bang khoang trang: ");
            //string n1 = Console.ReadLine();
            //string[] n1string = n1.Split(' ');
            //int[] n1array = Array.ConvertAll(n1string, int.Parse);
            //List<int> n1list = new List<int>(n1array);
            //int max = FindMax(n1list);
            //Console.WriteLine($"Gia tri max la {max}");
            //----------------------------------------------------------------------------------------------


            //EX2
            //int n;
            //do
            //{
            //    Console.WriteLine("Nhap gia tri n:");
            //    bool res = int.TryParse(Console.ReadLine(), out n);
            //    if (!res)
            //        Console.WriteLine("Nhap mot so nguyen, khong phai chuoi.");
            //    else if (n < 0)
            //        Console.WriteLine("Nhap mot so nguyen duong.");
            //    else
            //    {
            //        break;
            //    }
            //} while (true);

            //Console.WriteLine($"n = {n}, fractorial = {CaculateFactorial(n)}");
            //----------------------------------------------------------------------------------------------


            //EX3
            //Console.WriteLine("Nhap mot so duong: ");
            //int number;
            //bool res = int.TryParse(Console.ReadLine(), out number);

            //if (res && number > 0)
            //{
            //    Console.WriteLine($"Cac so nguyen to nho hon {number} la:");
            //    PrintPrimeNumberLessThan(number);
            //}
            //else
            //{
            //    Console.WriteLine("Vui long nhap mot so nguyen duong.");
            //}
            //-----------------------------------------------------------------------------------------------


            //EX4
            //int n4a;
            //do
            //{
            //    Console.WriteLine("Nhap mot so duong N (n4a):");
            //} while (!int.TryParse(Console.ReadLine(), out n4a) || n4a <= 0);

            //Console.WriteLine($"Cac so nguyen to < {n4a}:");
            //PrintPrimeNumberLessThan(n4a); // In ra các số nguyên tố nhỏ hơn n4a

            //// In N số nguyên tố đầu tiên
            //int n4b;
            //do
            //{
            //    Console.WriteLine("In N so nguyen to dau tien");
            //    Console.WriteLine("Nhap mot so duong N (n4b):");
            //} while (!int.TryParse(Console.ReadLine(), out n4b) || n4b <= 0);

            //Console.WriteLine($"Cac so nguyen to dau tien ({n4b} so):");
            //PrintNFirstPrimeNumbers(n4b);
            //----------------------------------------------------------------------------------------------

            //EX5
            //int n5;
            //Console.WriteLine("Kiem tra so hoan hao");
            //do
            //{
            //    Console.WriteLine("Nhap gia tri n5 nguyen duong:");
            //    bool res = int.TryParse(Console.ReadLine(), out n5);
            //    if (!res)
            //        Console.WriteLine("Nhap mot so nguyen, khong phai chuoi.");
            //    else if (n5 < 0)
            //        Console.WriteLine("Nhap mot so nguyen duong.");
            //    else
            //    {
            //        Ex5(n5);
            //        break;
            //    }
            //} while (true);
            //----------------------------------------------------------------------------------------------


            Console.WriteLine("Enter a string");
            string string6 = Console.ReadLine();
            Ex6(string6);



            Console.ReadKey();
        }
        public static int FindMax(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                throw new ArgumentException("Danh sách không được rỗng và phải có ít nhất một phần tử.");

            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }

            return max;
        }
        public static int CaculateFactorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static bool IsPrime (int number3)
        {
            if (number3 <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number3); i++)
            {
                if (number3 % i == 0)
                    return false;
            }

            return true;
        }
        public static void PrintPrimeNumberLessThan(int number4a)
        {
            for (int i = 2; i < number4a; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        public static void PrintNFirstPrimeNumbers(int n4b)
        {
            int count = 0; // Biến đếm số lượng số nguyên tố đã in
            int num = 2;   // Số bắt đầu để kiểm tra tính nguyên tố

            // Vòng lặp tiếp tục cho đến khi đã in ra đủ số nguyên tố
            while (count < n4b)
            {
                // Kiểm tra xem số hiện tại có phải là số nguyên tố hay không
                if (IsPrime(num))
                {
                    Console.Write(num + " "); // In ra số nguyên tố
                    count++;                   // Tăng biến đếm lên 1
                }
                num++; // Tăng số hiện tại để kiểm tra số tiếp theo
            }
            Console.WriteLine();
        }
        public static void Ex5(int number5)
        {
            int sum = 0;

            for (int i = 1; i <= Math.Sqrt(number5); i++)
            {
                if (number5 % i == 0)
                {
                    if (i == 1)
                        sum += i;
                    else
                    {
                        sum += i;
                        if (i != number5 / i)
                            sum += number5 / i;
                    }
                }
            }
            if (sum == number5)
                Console.WriteLine($"{number5} is a perfect number!");
            else
                Console.WriteLine($"{number5} is not a perfect number!");
            Console.WriteLine("Danh sach cac so hoan hao < 1000:");
            for (int i = 1; i < 1000; i++)
            {
                int sum2 = 0;
                for (int j = 1; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        if (j == 1)
                            sum2 += j;
                        else
                        {
                            sum2 += j;
                            if (j != i / j)
                                sum2 += i / j;
                        }
                    }
                }
                if (sum2 == i)
                    Console.WriteLine($"{i}");
            }
        }
        public static void Ex6(string input)
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
