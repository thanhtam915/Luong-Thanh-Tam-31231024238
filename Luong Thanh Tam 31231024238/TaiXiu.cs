using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class TaiXiu
    {
        public static void Main()
        {
            gameengine();
        }

        public static int RollDice()
        {
            Random rnd = new Random();
            int die1 = rnd.Next(6) + 1;
            int die2 = rnd.Next(6) + 1;
            int die3 = rnd.Next(6) + 1;
            int sumofDie = die1 + die2 + die3;
            return sumofDie;
        }

        public static void playOneRound()
        {
            int comDice = RollDice();
            Console.Write("Ban doan tai hay xiu <T/X>: ");
            string userguessing = Console.ReadLine();
            Console.WriteLine($"KQ cua may la {comDice}");
            if (userguessing.ToUpper().Equals("T"))
            {
                if (comDice >= 10)
                    Console.WriteLine("You win!");
                else
                    Console.WriteLine("You lose!");
            }
            else if (userguessing.ToUpper().Equals("X"))
            {
                if (comDice < 10)
                    Console.WriteLine("You win!");
                else
                    Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("Vui long nhap dung!");
            }
        }

        public static void gameengine()
        {
            do
            {
                playOneRound();
                Console.WriteLine("Ban choi tiep khong <C/K>? ");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals("K"))
                {
                    Console.WriteLine("See you again! Byeeee");
                    break;
                }
            } while (true);
        }
    }
}
