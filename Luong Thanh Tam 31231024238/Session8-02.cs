using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Session8_02
    {
        public static void Main()
        {
            int[][] a;
            Console.Write("Enter numbers of row: "); int rows = int.Parse(Console.ReadLine());
            a = new int[rows][];

            //EX1:
            //NhapMang(a);

            //EX2:
            NhapMangRandom(a);
            XuatMang(a);

            PrintMaxValue(a);

            Console.ReadKey();
        }

        public static void NhapMangRandom(int[][] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Enter numbers of columns for row {i}: ");
                int col = int.Parse(Console.ReadLine());
                a[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    a[i][j] = random.Next(100);
                }
            }
        }
        public static void NhapMang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Enter numbers of columns for row {i}: ");
                int col = int.Parse(Console.ReadLine());
                a[i] = new int[col];
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Enter value of a[{i}][{j}]");
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void XuatMang(int[][] a)
        {
            for(int i = 0;i < a.Length; i++)
            {
                for (int j = 0;j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void PrintMaxValue(int[][] a)
        {
            int max = a[0][0];
            for (int i =0;i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] > max)
                    {
                        max = a[i][j];
                    }
                }
            }
            Console.WriteLine($"Max of this array is: {max}");
            
            for (int i = 0; i < a.Length; i++)
            {
                int max1 = a[i][0];
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] > max1)
                    {
                        max1 = a[i][j];
                    }
                }
                Console.WriteLine($"Max of this array[{i}] is: {max1}");
            }
        }
        public static void SortRow(int[][] a)
        {
            Console.Write("Nhap dong ban muon sort: ");
            int row = int.Parse(Console.ReadLine());
            int[] line = a[row];
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < i - 1; j++)
                    if (line[i] > line[j])
                    {
                        int temp = line[i];
                        line[i] = line[j];
                        line[j] = temp;
                    }
            }

        }
    }
}
