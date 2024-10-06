using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int largerNumber = 0;
        int enterListOfNumbers = 1;

        // Collect numbers from the user
        while (enterListOfNumbers != 0)
        {
            Console.WriteLine("Enter number or type 0 to quit: ");
            string userNumber = Console.ReadLine();
            enterListOfNumbers = int.Parse(userNumber);

            if (enterListOfNumbers != 0)
            {
                numbers.Add(enterListOfNumbers);
            }
        }

        // Check if there are any numbers entered
        if (numbers.Count > 0)
        {
            // Compute the sum of the numbers
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;

                // Compute the largest number
                if (number > largerNumber)
                {
                    largerNumber = number;
                }
            }

            // Compute the average of the numbers
            float average = ((float)sum) / numbers.Count;

            // Find the smallest positive number
            int? smallestPositive = numbers.Where(n => n > 0).OrderBy(n => n).FirstOrDefault();

            // Stretch Chalenge 2) Sort the list of numbers
            numbers.Sort();

            // Output results
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The Average is: {average}");
            Console.WriteLine($"The Largest Number is: {largerNumber}");

            if (smallestPositive != 0)
            {
                Console.WriteLine($"The Smallest Positive Number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered.");
            }

            // Print the sorted list of numbers
            Console.WriteLine("The sorted list of numbers is: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
