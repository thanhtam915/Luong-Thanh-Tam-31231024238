using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Session_6
    {
        private static object arrayRemove;

        public static void Main()
        {
            int n;
            bool exit = false;
            do
            {
                Console.Write("Nhap so phan tu (n): ");
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Invalid input!!!");
                }
                exit = true;
            } while (!exit);

            int[] array = new int[n];
            //Input(array, n);

            InputRandom(array, n);
            Print(array);

            bool exit1 = false;
            int soCanTim;
            do
            {
                Console.WriteLine("Nhap so can tim: ");
                while (!int.TryParse(Console.ReadLine(), out soCanTim))
                {
                    Console.WriteLine("Invalid input!!!");
                }
            } while (!exit);
            int index = FindArrayElement(array, soCanTim);
            if (index == -1)
                Console.WriteLine($"{soCanTim} khong ton tai trong array!!!");
            else
                Console.WriteLine($"{soCanTim} nam o vi tri {index}");

            Console.WriteLine("Nhap so can xoa: ");
            int removedNumber = int.Parse(Console.ReadLine());
            int[] arrayRemove = removeNumber(array, removedNumber);

            Print(arrayRemove);

            var (max, min) = FindMaxMin(array);
            Console.WriteLine($"Max: {max}\nMin: {min}");

            int[] reArray = Reverses(array);
            Print(reArray);

            int[] dupNumber = FindDuplicate(array);
            Console.WriteLine("Duplicated number: ");
            Print(dupNumber);

            int[] nonduplicate = removeDuplicate(array, dupNumber);
            Console.Write("Removed Array: ");
            Print(nonduplicate);

            SelectionSort1(array);
            Print(array);

            SelectionSort2(array);
            Print(array);

            Console.ReadKey();
        }

        private static void SelectionSort2(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] > array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        private static int[] removeDuplicate(int[] array, int[] dupNumber)
        {
            if (dupNumber.Length == 0)
            {
                return array;
            }
            List<int> list = new List<int>();
            foreach (int item in array)
            {
                if (dupNumber.Contains(item) == false || list.Contains(item) == false)
                {
                    list.Add(item);
                }

            }
            return list.ToArray();
        }

        private static int[] FindDuplicate(int[] array)
        {
            List<int> dup = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        if (!dup.Contains(array[i]))
                        {
                            dup.Add(array[i]);
                        }
                    }
                }
            }
            return dup.ToArray();
        }

        private static int[] Reverses(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[index++] = array[array.Length - 1 - i];
            }
            return reversedArray;

        }

        private static (int max, int min) FindMaxMin(int[] array)
        {
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return (max, min);
        }

        private static int[] removeNumber(int[] array, int removeNumber)
        {
            int count = 0;
            foreach (int i in array)
            {
                if (i != removeNumber)
                    count++;
            }
            int[] result = new int[count];
            int index = 0;
            foreach (int item in array)
                if (item != removeNumber)
                    result[index++] = item;
            return result;
        }

        private static int FindArrayElement(int[] array, int soCanTim)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == soCanTim)
                    return i;
            }
            return -1;
        }

        private static void InputRandom(int[] array, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
        }

        private static void Print(int[] array)
        {
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        private static void Input(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap a[{i}] : ");
                Console.WriteLine();
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        private static void SelectionSort1(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }


    }
}
