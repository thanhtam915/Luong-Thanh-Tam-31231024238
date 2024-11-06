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
        public static void Main1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Ex4();

            Console.ReadKey();

        }
        public static void Ex1()
        {
            Console.WriteLine("Nhap day so cach nhau bang space: ");
            string n1String = Console.ReadLine();
            string[] n1array = n1String.Split(' ');
            int[] n1intArray = Array.ConvertAll(n1array, int.Parse);
            int sum = 0;
            for (int i = 0; i < n1intArray.Length; i++)
            {
                sum += n1intArray[i];
            }
            Console.WriteLine($"Average of Array is {sum / n1intArray.Length}");
        }
        public static void Ex2()
        {
            Console.WriteLine("Nhap mang gia tri cua ban cach nhau bang space: ");
            string n2String = Console.ReadLine();
            string[] n2Array = n2String.Split(" ");
            Console.WriteLine("Nhap gia tri muon do: ");
            string value2 = Console.ReadLine();
            bool chuaGiaTri = false;
            
            foreach(string phanTu in n2Array)
{
                if (phanTu == value2)
                {
                    chuaGiaTri = true;
                    break;
                }
            }

            if (chuaGiaTri)
            {
                Console.WriteLine("Mảng chứa giá trị này.");
            }
            else
            {
                Console.WriteLine("Mảng không chứa giá trị này.");
            }
            
        }
        public static void Ex3()
        {
            Console.WriteLine("Nhap mang gia tri cach nhau bang space: ");
            string n3String = Console.ReadLine();
            string[] n3Array = n3String.Split(" ");
            Console.WriteLine("Nhap gia tri can tim do: ");
            string value3 = Console.ReadLine();
            int viTri = 0;
            for (int i = 0;i < n3Array.Length; i++)
            {
                if (n3Array[i] == value3)
                {
                    Console.WriteLine($"Vi tri cua gia tri can tim la {i}");
                }
                else if (i == n3Array.Length - 1)
                {
                    Console.WriteLine("Mang khong chua gia tri nay!");
                }
            }
        }
        public static void Ex4()
        {
            Console.WriteLine("Nhap so gia tri cua mang (N): ");
            int n = int.Parse(Console.ReadLine());
            int[] randomArray = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                randomArray[i] = rnd.Next(1, 101);
            }
            foreach (int item in randomArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
