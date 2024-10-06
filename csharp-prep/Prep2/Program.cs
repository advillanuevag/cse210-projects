using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade:? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";  
        string sign = "";       
        
        // Determine the student Letter based on a given grade. 
        if (number >= 90)
        {
            letter = "A";
            int lastDigit = number % 10; // Stretch Challenge
            if (lastDigit >= 7)
            {
                sign = "";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            
        }
        else if (number >= 80)
        {
            letter = "B";
            int lastDigit = number % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            
        }
        else if (number >= 70)
        {
            letter = "C";
            int lastDigit = number % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            
        }
        else if (number >= 60)
        {
            letter = "D";
            int lastDigit = number % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            
        }
        else
        {
            letter = "F";
            int lastDigit = number % 10;
            if (lastDigit >= 7)
            {
                sign = "";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            
        }
        
        // Show in the console the student grade.
        Console.WriteLine($"Your Grade is: {letter}{sign}.");
        
        // Validate if the student passed or not
        if (number >= 70)
        {
            Console.WriteLine("Congratulations!, you are in the other side!!");
        }
        else
        {
            Console.WriteLine("Oops!, something went wrong: Houston, we have a problem!!");

        }
    }
}