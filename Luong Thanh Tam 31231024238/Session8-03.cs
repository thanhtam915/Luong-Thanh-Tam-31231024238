using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Session8_03
    {
        public static void Main()
        {
            InitializeMembers();
            MainMenu();
        }
        static void InitializeMembers()
        {
            object[][][] groups = new object[3][][];
            groups[0] = new object[][]
            {
        new object[] { 1, "An", 10 },
        new object[] { 2, "Binh", 15 },
        new object[] { 3, "Cuong", 7 },
        new object[] { 4, "Duy", 12 },
        new object[] { 5, "Em", 9 }
            };
            groups[1] = new object[][]
            {
        new object[] { 6, "Phuc", 14 },
        new object[] { 7, "Giang", 8 },
        new object[] { 8, "Hoa", 13 }
            };
            groups[2] = new object[][]
            {
        new object[] { 9, "Vy", 11 },
        new object[] { 10, "Khanh", 17 },
        new object[] { 11, "Kim", 6 },
        new object[] { 12, "Long", 20 },
        new object[] { 13, "Minh", 5 },
        new object[] { 14, "Nam", 10 }
            };
        }

        // Display main menu
        static void MainMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. Display all members");
                Console.WriteLine("2. Display member by ID");
                Console.WriteLine("3. Display member with most tasks completed");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayAllMembers();
                        break;
                    case 2:
                        DisplayMemberByID();
                        break;
                    case 3:
                        DisplayMemberWithMostTasks();
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 0);
        }

        // Display all members
        static void DisplayAllMembers()
        {
            Console.WriteLine("\n--- List of all members ---");
            foreach (var groupMembers in groups)
            {
                foreach (var member in groupMembers)
                {
                    Console.WriteLine($"ID: {member[0]}, Name: {member[1]}, Tasks completed: {member[2]}");
                }
            }
        }

        // Display member by ID
        static void DisplayMemberByID()
        {
            Console.Write("Enter member ID: ");
            int id = int.Parse(Console.ReadLine());
            bool found = false;

            foreach (var groupMembers in groups)
            {
                foreach (var member in groupMembers)
                {
                    if ((int)member[0] == id)
                    {
                        Console.WriteLine($"ID: {member[0]}, Name: {member[1]}, Tasks completed: {member[2]}");
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                Console.WriteLine("Member not found.");
            }
        }

        // Display member with the most tasks completed
        static void DisplayMemberWithMostTasks()
        {
            object[] topMember = null;

            foreach (var groupMembers in groups)
            {
                foreach (var member in groupMembers)
                {
                    if (topMember == null || (int)member[2] > (int)topMember[2])
                    {
                        topMember = member;
                    }
                }
            }

            if (topMember != null)
            {
                Console.WriteLine($"\n--- Member with the most tasks completed ---");
                Console.WriteLine($"ID: {topMember[0]}, Name: {topMember[1]}, Tasks completed: {topMember[2]}");
            }
        }

    }
}
