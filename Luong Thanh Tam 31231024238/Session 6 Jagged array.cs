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
        static Random rand = new Random();
        static string[] randomNames = { "Alice", "Bob", "Charlie", "Diana", "Eve" };

        static void Main8-3()
        {
            int[] columnSizes = { 5, 3, 6 };
            int rowSize = 3;
            List<List<object[]>> database = InitializeDatabase(rowSize, columnSizes);

            while (true)
            {
                Console.WriteLine(@"
Choose a function: 
1. List of all members
2. Member information by ID
3. Most productive member
4. Exit");

                if (!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > 4)
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        ListAllMembers(database);
                        break;
                    case 2:
                        FindMemberById(database);
                        break;
                    case 3:
                        DisplayMostProductiveMember(database);
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                }
            }
        }

        static List<List<object[]>> InitializeDatabase(int rows, int[] colSizes)
        {
            var database = new List<List<object[]>>();

            for (int i = 0; i < rows; i++)
            {
                var row = new List<object[]>();
                for (int j = 0; j < colSizes[i]; j++)
                {
                    object[] staffInfo = new object[3]
                    {
                    rand.Next(0, 30),                                // ID
                    randomNames[rand.Next(randomNames.Length)],      // Name
                    rand.Next(50, 200)                              // Tasks
                    };
                    row.Add(staffInfo);
                }
                database.Add(row);
            }

            return database;
        }

        static void ListAllMembers(List<List<object[]>> database)
        {
            foreach (var row in database)
            {
                foreach (var member in row)
                {
                    Console.WriteLine($"ID: {member[0]}, Name: {member[1]}, Tasks: {member[2]}");
                }
            }
        }

        static void FindMemberById(List<List<object[]>> database)
        {
            Console.Write("Enter member ID: ");
            if (!int.TryParse(Console.ReadLine(), out int searchId))
            {
                Console.WriteLine("Invalid ID. Please enter a number.");
                return;
            }

            foreach (var row in database)
            {
                foreach (var member in row)
                {
                    if ((int)member[0] == searchId)
                    {
                        Console.WriteLine($"ID: {member[0]}, Name: {member[1]}, Tasks: {member[2]}");
                        return;
                    }
                }
            }
            Console.WriteLine("Member not found.");
        }

        static void DisplayMostProductiveMember(List<List<object[]>> database)
        {
            object[] mostProductiveMember = null;
            int maxTasks = int.MinValue;

            foreach (var row in database)
            {
                foreach (var member in row)
                {
                    if ((int)member[2] > maxTasks)
                    {
                        maxTasks = (int)member[2];
                        mostProductiveMember = member;
                    }
                }
            }

            if (mostProductiveMember != null)
            {
                Console.WriteLine($"Most Productive Member -> ID: {mostProductiveMember[0]}, Name: {mostProductiveMember[1]}, Tasks: {mostProductiveMember[2]}");
            }
            else
            {
                Console.WriteLine("No members found.");
            }
        }
    }
