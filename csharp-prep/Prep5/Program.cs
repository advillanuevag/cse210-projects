using System;

class Program
{
    static void Main(string[] args)
    {
        //call the DisplayMessage() function to display a Welcome message.
        
        DisplayMessage();

        //Call the PromptUserName() function and return the userName.
        string userName = PromptUserName();
        
        //Call the PromptUserNumber() function and return the userNumber.
        int userNumber = PromptUserNumber();

        //Call the SquareNumber() function and return the squaredNumber.
        int squaredNumber = SquareNumber(userNumber);

        //Call the DisplayResult() function and prints the userName and the favorite number squared.
        DisplayResult(userName, squaredNumber);
        
        
        //DisplayMessage() Function
        
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        //PromptUserName() function.
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name?: ");
            string userName = Console.ReadLine();
            return userName;
        }
        
        //PromptUserNumber() function.
        static int PromptUserNumber()
        {
            Console.WriteLine("Enter your favorite number: ");
            string userNumber = Console.ReadLine();
            int favoriteNumber = int.Parse(userNumber);
            return favoriteNumber;
        }
        
        //PromptUserNumber() function.
        static int SquareNumber (int number)
            {
                int squared = number * number;
                return squared;
            }
        
        //DisplayResult() function.
        static void DisplayResult (string userName, int squared)
            {
                Console.WriteLine($"{userName}, the square of your number is {squared}");
            }

    }
}