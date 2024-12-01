using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Session8_02
    {
        static void Main6(string[] args)
        {
            CreateAndDisplayPredefinedJaggedArray();

            CreateAndProcessUserJaggedArray();

            Console.ReadKey();
        }

        static void CreateAndDisplayPredefinedJaggedArray()
        {
            int[][] jaggedArray = new int[][]
            {
            new int[] {1, 1, 1, 1, 1},
            new int[] {2, 2},
            new int[] {3, 3, 3, 3},
            new int[] {4, 4}
            };

            Console.WriteLine("Predefined Jagged Array:");
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        static void CreateAndProcessUserJaggedArray()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Enter the number of columns for row {i + 1}: ");
                int cols = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element [{i}][{j}]: ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nUser-defined Jagged Array:");
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }


            PrintLargestNumbers(jaggedArray);
            SortRows(jaggedArray);
            PrintPrimes(jaggedArray);
            SearchAndPrintPositions(jaggedArray);
        }

        static void PrintLargestNumbers(int[][] array)
        {
            int globalMax = int.MinValue;
            Console.WriteLine("\nLargest number in each row:");
            foreach (var row in array)
            {
                int rowMax = int.MinValue;
                foreach (var num in row)
                {
                    if (num > rowMax) rowMax = num;
                    if (num > globalMax) globalMax = num;
                }
                Console.WriteLine(rowMax);
            }
            Console.WriteLine($"Largest number in the entire array: {globalMax}");
        }

        static void SortRows(int[][] array)
        {
            Console.WriteLine("\nSorted rows in ascending order:");
            foreach (var row in array)
            {
                Array.Sort(row);
                Console.WriteLine(string.Join(" ", row));
            }
        }

        static void PrintPrimes(int[][] array)
        {
            bool IsPrime(int num)
            {
                if (num < 2) return false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }

            Console.WriteLine("\nPrime numbers in the array:");
            foreach (var row in array)
            {
                foreach (var num in row)
                {
                    if (IsPrime(num)) Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }

        static void SearchAndPrintPositions(int[][] array)
        {
            Console.Write("\nEnter the number to search for: ");
            int searchNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Positions of {searchNumber}:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] == searchNumber)
                    {
                        Console.WriteLine($"[{i}][{j}]");
                    }
                }
            }
        }
    }
}
