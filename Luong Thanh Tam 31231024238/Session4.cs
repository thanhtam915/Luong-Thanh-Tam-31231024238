using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Session04
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
            //Ex8();
            //Ex9();
            Ex10();
            Console.ReadKey(true);
        }

        public static void Ex1() // Exercise 1: odd or even number
        {
            int n1;
            while (true)
            {
                Console.WriteLine("Enter an int number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out n1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            if (n1 % 2 == 0)
            {
                Console.WriteLine($"{n1} is an even number");
            }
            else
            {
                Console.WriteLine($"{n1} is an odd number");
            }
        }
        public static void Ex2()
        {
            Console.WriteLine("Enter your numbers array seperated by spaces: ");
            string n2 = Console.ReadLine();
            string[] n2Array = n2.Split(' ');
            int[] intarray = Array.ConvertAll(n2Array, int.Parse);

            int placeholder = 0;
            for (int i = 1; i < intarray.Length; i++)
            {
                if (intarray[i] > intarray[i - 1])
                {
                    placeholder = intarray[i];
                }
                else
                {
                    placeholder = intarray[i - 1];
                }
            }
            Console.WriteLine($"The largest number is {placeholder}");
        }
        public static void Ex3()
        {
            int x = 0, y = 0;
            bool invalidInput = true;

            while (invalidInput)
            {
                try
                {
                    Console.Write("Enter a x: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Enter a y: ");
                    y = int.Parse(Console.ReadLine());
                    invalidInput = false;
                }
                catch (FormatException) // Bắt lỗi nếu đầu vào không phải số nguyên
                {
                    Console.WriteLine("Invalid Input. Please, enter a & b are integer.");
                }
            }

            // Xác định vị trí tọa độ
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Diem toa do (0,0) nam tai goc toa do.");
            }
            else if (x > 0) // Nếu x dương
            {
                if (y > 0)
                {
                    Console.WriteLine($"Diem toa do ({x},{y}) nam trong goc phan tu thu nhat");
                }
                else
                {
                    Console.WriteLine($"Diem toa do ({x},{y}) nam trong goc phan tu thu tu");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine($"Diem toa do ({x},{y}) nam trong goc phan tu thu hai");
                }
                else
                {
                    Console.WriteLine($"Diem toa do ({x},{y}) nam trong goc phan tu thu ba");
                }
            }
        }
        public static void Ex4()
        {
            string[] n4Array = new string[0];
            int[] intarray = new int[0];
            bool invalidInput = true;

            while (invalidInput)
            {
                try
                {
                    Console.Write("Nhap canh cua tam giac, cach nhau boi dau cach: ");
                    string n4 = Console.ReadLine();
                    n4Array = n4.Split(' ');
                    intarray = Array.ConvertAll(n4Array, int.Parse);
                    invalidInput = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input. Please, enter inputs are integer!");
                }
            }

            if (intarray.Length != 3)
            {
                Console.WriteLine("Chi nhap 3 chu so");
                return;
            }


            if (intarray[0] + intarray[1] > intarray[2] &&
                intarray[0] + intarray[2] > intarray[1] &&
                intarray[1] + intarray[2] > intarray[0])
            {

                if (intarray[0] == intarray[1] && intarray[1] == intarray[2])
                {
                    Console.WriteLine("Tam giac la Tam giac deu");
                }
                else if (intarray[0] == intarray[1] || intarray[0] == intarray[2] || intarray[1] == intarray[2])
                {
                    Console.WriteLine("Tam giac la Tam giac can");
                }
                else
                {
                    Console.WriteLine("Tam giac la Tam giac khong deu");
                }
            }
            else
            {
                Console.WriteLine("Day khong phai la tam giac");
            }
        }
        public static void Ex5()
        {
            string[] n5Array = new string[0];
            int[] intarray = new int[0];
            bool invalidInput = true;

            while (invalidInput)
            {
                try
                {
                    Console.Write("Nhap day so: ");
                    string n4 = Console.ReadLine();
                    n5Array = n4.Split(' ');
                    intarray = Array.ConvertAll(n5Array, int.Parse);
                    invalidInput = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input. Please, enter inputs are integer!");
                }
            }
            double sum = 0;
            for (int i = 0; i < intarray.Length; i++)
            {
                sum += intarray[i];
            }
            double avg = Math.Round(sum / (intarray.Length + 1), 2);
            Console.WriteLine($"Sum of array is {sum}");
            Console.WriteLine($"Average of array is {avg}");
        }
        public static void Ex6()
        {
            int n6 = 0;
            bool invalidInput = true;
            while (invalidInput)
            {
                try
                {
                    Console.WriteLine("Input an integer: ");
                    n6 = int.Parse(Console.ReadLine());
                    invalidInput = false;
                }
                catch
                {
                    Console.WriteLine("Invalid Input. Please enter integer value: ");
                }
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{n6} x {i} = {n6 * i}");
            }
        }
        public static void Ex7()
        {
            int n7 = 0;
            bool invalidInput = true;
            while (invalidInput)
            {
                try
                {
                    Console.Write("Enter an integer: ");
                    n7 = int.Parse(Console.ReadLine());
                    invalidInput = false;
                }
                catch
                {
                    Console.WriteLine("Invalid Input. Please enter integer value: ");
                }
            }
            for (int i = 1; i <= n7; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine(" ");
            }
        }
        public static void Ex8()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter n terms: ");
            int n8 = int.Parse(Console.ReadLine());

            double sum = 1;
            Console.Write("1");
            for (int i = 2; i <= n8; i++)
            {
                Console.Write($" + 1/{i}");
                double temp = 1 / i;
                sum += temp;
            }
            Console.Write($" = {sum}");
        }
        public static void Ex9()
        {
            int n9start = 0;
            int n9end = 0;
            bool invalidInput = true;

            while (invalidInput)
            {
                try
                {
                    Console.Write("Nhập số bắt đầu của khoảng: ");
                    n9start = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số kết thúc của khoảng: ");
                    n9end = int.Parse(Console.ReadLine());

                    // Kiểm tra xem n9start có nhỏ hơn n9end không
                    if (n9start > n9end)
                    {
                        Console.WriteLine("Giá trị bắt đầu phải nhỏ hơn hoặc bằng giá trị kết thúc. Vui lòng nhập lại.");
                        continue; // Quay lại vòng lặp nếu điều kiện không thỏa mãn
                    }

                    invalidInput = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập các giá trị là số nguyên!");
                }
            }

            List<int> perfnum = new List<int>();
            for (int i = n9start; i <= n9end; i++)
            {
                int sum = 0; // Thay float thành int cho tổng
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    perfnum.Add(i);
                }
            }

            Console.WriteLine("Các số hoàn hảo trong khoảng là: ");
            foreach (int num in perfnum)
            {
                Console.Write($"{num}, "); // In ra danh sách số hoàn hảo
            }

            // Để tránh in ra dấu phẩy cuối cùng, có thể kiểm tra thêm
            if (perfnum.Count == 0)
            {
                Console.WriteLine("Không có số hoàn hảo nào trong khoảng này.");
            }
            else
            {
                Console.WriteLine(); // In xuống dòng sau khi in xong các số
            }
        }
        public static void Ex10()
        {
            Console.Write("Nhập một số: ");
            int n10 = int.Parse(Console.ReadLine());

            if (n10 < 2)
            {
                Console.WriteLine($"{n10} không phải là số nguyên tố");
                return;
            }
            else
            {
                int count = 0;
                for (int i = 2; i <= Math.Sqrt(n10); i++)
                {
                    if (n10 % i == 0)
                    {
                        count++;
                        break; // Nếu tìm thấy ước số, không cần tiếp tục kiểm tra
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine($"{n10} là số nguyên tố");
                }
                else
                {
                    Console.WriteLine($"{n10} không phải là số nguyên tố");
                }
            }
        }
    }
}
