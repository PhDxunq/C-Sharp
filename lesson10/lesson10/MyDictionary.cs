using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10
{
    internal class MyDictionary
    {
        static void Main(string[] args)
        {
            Dictionary myDict = new Dictionary();
            while (true)
            {
                try
                {
                    Console.WriteLine("\n==== Dictionary Menu ====");
                    Console.WriteLine("1. Add a Word");
                    Console.WriteLine("2. Edit a Word");
                    Console.WriteLine("3. Remove a Word");
                    Console.WriteLine("4. List all Words");
                    Console.WriteLine("5. Search a Word");
                    Console.WriteLine("6. Clear Screen");
                    Console.WriteLine("7. Exit");
                    Console.Write("Choose an option: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter word: ");
                            string word = Console.ReadLine();
                            Console.Write("Enter meaning: ");
                            string meaning = Console.ReadLine();
                            myDict.AddWord(word, meaning);
                            break;

                        case "2":
                            Console.Write("Enter word to edit: ");
                            string editWord = Console.ReadLine();
                            Console.Write("Enter new meaning: ");
                            string newMeaning = Console.ReadLine();
                            myDict.EditWord(editWord, newMeaning);
                            break;

                        case "3":
                            Console.Write("Enter word to remove: ");
                            string removeWord = Console.ReadLine();
                            myDict.RemoveWord(removeWord);
                            break;

                        case "4":
                            myDict.ListWords();
                            break;

                        case "5":
                            Console.Write("Enter word to search: ");
                            string searchWord = Console.ReadLine();
                            myDict.SearchWord(searchWord);
                            break;

                        case "6":
                            Console.Clear();
                            break;

                        case "7":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please choose again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
