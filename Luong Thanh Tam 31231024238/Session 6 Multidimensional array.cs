using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Session8
    {
        public static void Main6()
        {
            //int[,] a;
            Console.Write("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); int cols = int.Parse(Console.ReadLine());
            int[,] a = new int[rows, cols];
            NhapMangRandom(a, rows, cols);
            Xuatmang(a);
            //Console.ReadKey();

            //Console.Write("Nhap vi tri cot can in: "); int Nocol = int.Parse(Console.ReadLine());
            //PrintColumn(a, Nocol);
            //Console.ReadKey();

            //Console.Write("Nhap vi tri dong can in: "); int Norow = int.Parse(Console.ReadLine());
            //PrintRow(a, Norow);
            //Console.ReadKey();

            //FindMaxValue(a);
            //Console.ReadKey();

            //Console.Write("Find min value in col/row <C/R>: ");
            //string place = Console.ReadLine();
            //FindMinValue(a, place);
            //Console.ReadKey();

            //Tranpose(a);
            //Console.ReadKey();

            FindDiagonal(a);


        }


        private static void Nhapmang(int[,] a, int rows, int cols)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"Enter value of a[{i},{j}] ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                
            }
        }
        private static void Xuatmang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void NhapMangRandom(int[,] a, int rows, int cols)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(0,100);
                }
            }

        }
        public static void FindIndexElement(int[,] a, int value)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == value)
                    {
                        Console.WriteLine($"{value} xuat hien tai a[{i},{j}]");
                    }
                    else
                    {
                        Console.WriteLine($"Ko ton tai {value}");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void PrintColumn(int[,] a, int Nocol)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine(a[i, Nocol] );
            }
        }
        public static void PrintRow(int[,] a, int Norow)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {Console.Write(a[Norow, j] + "\t");}
            Console.WriteLine();

        }
        public static void FindMaxValue(int[,] a)
        {
            int max = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] > max)
                    {
                        max = a[i,j];
                    }
                    else
                    {
                        max = max;
                    }
                }
            }
            Console.WriteLine($"Max value is {max}");
        }
        private static void FindMinValue(int[,] a, string place)
        {
            if (place == "C")
            {
                
                Console.WriteLine("Nhap vi tri cot: ");
                int cot = int.Parse(Console.ReadLine());
                int min = a[0, cot];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    if (a[i,cot] < min)
                    {
                        min = a[i,cot];
                    }
                }
                Console.WriteLine($"Min value in column {cot} is: {min}");
            }
            if (place == "R")
            {
                Console.WriteLine("Nhap vi tri dong: ");
                int row = int.Parse(Console.ReadLine());
                int min = a[row, 0];
                for (int i = 0; i < a.GetLength(1); i++)
                {
                    if (a[row, i] < min)
                    {
                        min = a[row, i];
                    }
                }
                Console.WriteLine($"Min value in row {row} is: {min}");
            }
        }
        public static void Tranpose(int[,] a)
        {
            Console.WriteLine("After Tranpose!!!");
            int[,] b = new int[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[j, i] = a[i, j];
                }
            }
            Xuatmang(b);
        }
        private static void FindDiagonal(int[,] a)
        {
            if (a.GetLength(0) == a.GetLength(1))
            {
                Console.WriteLine("The main Diagonal");
                for (int i = 0;i < a.GetLength(0); i++)
                {
                    for(int j = 0; j < a.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            Console.Write(a[i, j] + "\t");
                        }
                    }
                }
                Console.WriteLine("\n The secondary Diagonal");
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    Console.Write(a[i, a.GetLength(1) - i - 1] + "\t");
                }
            }
            else
            {
                Console.WriteLine("This's not square matrix!!!");
            }
        }

    }
}
