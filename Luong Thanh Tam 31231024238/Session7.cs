using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Session7
    {
        public static void Main7()
        {
            Ex1();


            Console.ReadKey();
        }
        public static void Ex1()
        {
            Console.WriteLine("Nhap so gia tri cua mang (N): ");
            int n = int.Parse(Console.ReadLine());
            double[] items = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap gia tri thu {i}: ");
                items[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Day la mang gia tri");
            foreach (int element in items)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n");
            for (int i = 0;i <n; i++)
            {
                items[i] = items[i] + 2;
            }
            Console.WriteLine("Day la mang gia tri sau khi cong 2");
            foreach (int element in items)
            {
                Console.Write(element + " ");
            }
        }
    }
}
