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
            //Console.WriteLine("Nhap 3 chu so cach nhau bang khoang trang: ");
            //string n1 = Console.ReadLine();
            //string[] n1string = n1.Split(' ');
            //int[] n1array = Array.ConvertAll(n1string, int.Parse);
            //List<int> n1list = new List<int>(n1array);
            //int max = FindMax(n1list);
            //Console.WriteLine($"Gia tri max la {max}");


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


            Console.WriteLine("Nhap mot so duong: ");
            int number;
            bool res = int.TryParse(Console.ReadLine(), out number);

            if (res && number > 0)
            {
                Console.WriteLine($" {number} so nguyen to dau tien la:");
                PrintNFirstPrimeNumbers(number);
            }
            else
            {
                Console.WriteLine("Vui long nhap mot so nguyen duong.");
            }


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
            int count = 0;
            int num = 2;

            while (count < n4b)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                    count++;
                }
                num++;
            }
            Console.WriteLine();
        }
        public static void Ex5(int number5)
        public static void Ex6(int number6)
        {

        }
    }
}
