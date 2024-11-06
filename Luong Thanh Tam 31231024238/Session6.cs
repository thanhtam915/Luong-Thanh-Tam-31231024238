using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Session_6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            generateRandomArray(a);
            PrintArray(a);
            Console.ReadKey();

            //EX1: To caculate the average value of array elements
            double Avg = Average(a);
            Console.WriteLine($"Avarage of this integer array is {Avg}");

            //EX2: To test if an array contains a specific value
            Console.WriteLine("Nhap gia tri can tim");
            int soCanTim0 = int.Parse(Console.ReadLine());
            bool pos1 = ValidValueInArray(a, soCanTim0);
            if (pos1 == true)
                Console.WriteLine($"This array include number {soCanTim0}");

            //EX3: To find the index of an array element
            Console.WriteLine("Nhap so can tim: ");
            int soCanTim = int.Parse(Console.ReadLine());
            int pos2 = FindIndexofValue(a, soCanTim);
            if (pos2 == -1)
            {
                Console.WriteLine($"So {soCanTim} khong ton tai trong mang");
            }
            else if (pos2 != -1)
            {
                Console.WriteLine($"So {soCanTim} tai vi tri {pos2}");
            }

            //EX4: To remove a specific element from an array
            Console.WriteLine("Enter removed element: ");
            int removedElement = int.Parse(Console.ReadLine());
            int[] newArray = RemoveElement(a, removedElement);
            PrintArray(newArray);

            //EX: To find the maximum and minimum value of value
            var (max, min) = FindMaxAndMin(a);
            Console.WriteLine($"Max: {max}\nMin: {min}");

        }



        static void Input(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tư {i}");
                int v = int.Parse(Console.ReadLine());
                a[i] = v;
            }
        }
        static void generateRandomArray(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] += rnd.Next(0, 100);
            }
        }
        static void PrintArray(int[] a)
        {
            foreach (int items in a)
            {
                Console.Write($"{items} ");
            }
        }

        public static double Average(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            double Average = (double)sum / a.Length;
            return Average;
        }

        public static bool ValidValueInArray(int[] a, int soCanTim)
        {
            foreach (int item in a)
            {
                if (item == soCanTim)
                {
                    return true;
                }
            }
            return false;
        }
        public static int FindIndexofValue(int[] a, int socantim)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == socantim)
                    return i;
            }
            return -1;
        }
        public static int[] RemoveElement(int[] a, int elementRemoved)
        {
            int count = 0;
            foreach (int item in a)
            {
                if (item != elementRemoved)
                    count++;
            }
            int[] result = new int[count];
            int index = 0;

            foreach (int item in a)
            {
                if (item != elementRemoved)
                {
                    result[index++] = item;
                }
            }
            return result;
        }
        public static (int max, int min) FindMaxAndMin(int[] a)
        {
            if (a == null || a.Length == 0)
            {
                throw new ArgumentException("Invalid Value, Empty Array!");
            }

            int max = a[0];
            int min = a[0];

            foreach (int item in a)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }
            return (max, min);
        }

    }
}
