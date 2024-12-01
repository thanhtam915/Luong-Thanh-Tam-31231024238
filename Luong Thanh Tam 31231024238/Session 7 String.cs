using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luong_Thanh_Tam_31231024238
{
    internal class Session_9_String
    {
        public static void Main()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter another string for comparison:");
            string compareString = Console.ReadLine();

            Console.WriteLine("Enter a substring to check:");
            string substring = Console.ReadLine();

            Console.WriteLine("Choose an option:");
            Console.WriteLine(@"
1. Print the string
2. Find the length of the string
3. Print each character of the string
4. Print each character in reverse order
5. Count total words
6. Compare two strings
7. Count alphabets, digits, and special characters
8. Count vowels and consonants
9. Check if a substring is present
10. Find position of a substring
11. Check if a character is alphabet and its case
12. Count occurrences of a substring
13. Insert a substring before the first occurrence of another string
14. Exit");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PrintString(inputString);
                    break;
                case 2:
                    Console.WriteLine($"Length: {FindLength(inputString)}");
                    break;
                case 3:
                    PrintElement(inputString);
                    break;
                case 4:
                    PrintElementReverse(inputString);
                    break;
                case 5:
                    Console.WriteLine($"Word count: {CountWords(inputString)}");
                    break;
                case 6:
                    CompareStrings(inputString, compareString);
                    break;
                case 7:
                    CountElements(inputString);
                    break;
                case 8:
                    CountVowelsAndConsonants(inputString);
                    break;
                case 9:
                    Console.WriteLine(CheckSubstring(inputString, substring) != -1
                        ? "Substring found."
                        : "Substring not found.");
                    break;
                case 10:
                    Console.WriteLine($"Substring position: {CheckSubstring(inputString, substring)}");
                    break;
                case 11:
                    Console.Write("Enter a character: ");
                    char c = Console.ReadLine()[0];
                    CheckCharacter(c);
                    break;
                case 12:
                    Console.WriteLine($"Occurrences of substring: {CountSubstringOccurrences(inputString, substring)}");
                    break;
                case 13:
                    Console.WriteLine(InsertSubstring(inputString, substring));
                    break;
                case 14:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.ReadKey();
        }

        public static void PrintString(string s)
        {
            Console.WriteLine(s);
        }

        public static int FindLength(string s)
        {
            int count = 0;
            foreach (char _ in s)
            {
                count++;
            }
            return count;
        }

        public static void PrintElement(string s)
        {
            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
        }

        public static void PrintElementReverse(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }

        public static int CountWords(string s)
        {
            return s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static void CompareStrings(string s1, string s2)
        {
            int result = string.Compare(s1, s2, StringComparison.OrdinalIgnoreCase);
            if (result == 0)
                Console.WriteLine("Strings are equal.");
            else if (result > 0)
                Console.WriteLine("First string is greater.");
            else
                Console.WriteLine("Second string is greater.");
        }

        public static void CountElements(string s)
        {
            int alphabets = 0, digits = 0, specialCharacters = 0;
            foreach (char c in s)
            {
                if (char.IsLetter(c)) alphabets++;
                else if (char.IsDigit(c)) digits++;
                else specialCharacters++;
            }

            Console.WriteLine($"Alphabets: {alphabets}, Digits: {digits}, Special Characters: {specialCharacters}");
        }

        public static void CountVowelsAndConsonants(string s)
        {
            int vowels = 0, consonants = 0;
            foreach (char c in s.ToLower())
            {
                if ("aeiou".Contains(c)) vowels++;
                else if (char.IsLetter(c)) consonants++;
            }

            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
        }

        public static int CheckSubstring(string s, string sub)
        {
            return s.IndexOf(sub, StringComparison.Ordinal);
        }

        public static void CheckCharacter(char c)
        {
            if (char.IsLetter(c))
            {
                Console.WriteLine($"Character is an alphabet and is {(char.IsUpper(c) ? "uppercase" : "lowercase")}.");
            }
            else
            {
                Console.WriteLine("Character is not an alphabet.");
            }
        }

        public static int CountSubstringOccurrences(string s, string sub)
        {
            int count = 0, pos = 0;
            while ((pos = s.IndexOf(sub, pos, StringComparison.Ordinal)) != -1)
            {
                count++;
                pos += sub.Length;
            }
            return count;
        }

        public static string InsertSubstring(string s, string sub)
        {
            int pos = CheckSubstring(s, sub);
            return pos != -1 ? s.Insert(pos, sub) : s;
        }
    }
}
