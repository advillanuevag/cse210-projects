using System;
using System.Collections.Generic;
namespace dj
{

    class Program
    {
        static void Main(string[] args)
        {

            Entry newEntry = new Entry();
            newEntry._date ="05/10/2024";
            newEntry._entryText ="I want to be happy today.";
            newEntry._promptText ="Where do you want to go today?";
            Entry newEntry2 = new Entry();
            newEntry2._date = "06/10/2024";
            newEntry2._entryText = "I will finish my import process this week";
            newEntry2._promptText = "What will you do today?";

            // Creating a List<Entry> and adding the new entry
            List<Entry> myList = new List<Entry>();
            myList.Add(newEntry);  // Adding the new entry to the list
            myList.Add(newEntry2);
            
            // Optionally, you can loop through the list and display entries
            foreach (var entry in myList)//Act
            {
                entry.Display();
            }

            int choice;
 
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
 
            choice = int.Parse(Console.ReadLine());
 
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Write option selected.");
                    break;
                case 2:
                    Console.WriteLine("Display option selected.");
                    break;
                case 3:
                    Console.WriteLine("Load option selected.");
                    break;
                case 4:
                    Console.WriteLine("Save option selected.");
                    break;
                case 5:
                    Console.WriteLine("Quitting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 5);
            
            
            
        }


    }
}