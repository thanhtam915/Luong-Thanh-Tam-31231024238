using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Subsession
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            generateRandomArray(a);
            PrintArray(a);
            Console.ReadKey();

            Console.WriteLine("Nhap so can tim: ");
            int soCanTim = int.Parse(Console.ReadLine());
            int pos = FindIndexofValue(a, soCanTim);
            if (pos == -1)
            {
                Console.WriteLine($"So {soCanTim} khong ton tai trong mang");
            }
            else if (pos != -1)
            {
                Console.WriteLine($"So {soCanTim} tai vi tri {pos}");
            }
        }
        static void Input(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap phan tư {i}");
                int v = int.Parse( Console.ReadLine() );
                a[i] = v;
            }
        }
        static void generateRandomArray(int[] a)
        {
            Random rnd = new Random();
            for (int i = 0;i < a.Length;i++)
            {
                a[i] += rnd.Next(0,100);
            }
        }
        static void PrintArray(int[] a)
        {
            foreach (int items in a)
            {
                Console.Write($"{items} ");
            }
        }
        static int FindIndexofValue(int[] a, int socantim)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == socantim)
                    return i;
            }
            return -1;
        }
    }
}
