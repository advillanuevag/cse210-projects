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
            
            
            
        }


    }
}