using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Generates ramdomly the magicNumber.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        //Stretch Challenge 2: ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
        string playAgain = "yes";
        
        while (playAgain == "yes")
            {
                 playAgain = "no";
                 Console.WriteLine("Let´s see if you can guess the magic number...");
        
                 int guess = 0;
                //Stretch Challenge 1: adds a guess counter and show the total number of guess.
                 int guessCounter = 1;

                // Keeps looping while guess does not match magicNumber.
                while (guess != magicNumber) 
                    {
               
                        Console.Write("What is your guess?: ");
                        string guesNumber = Console.ReadLine();
                        guess = int.Parse(guesNumber);

                        if (guess < magicNumber)
                            {
                                Console.WriteLine("Higher ");
                            }
                        else if (guess > magicNumber)
                            {
                                Console.WriteLine("Lower ");
                            }
                        else
                            {
                                Console.WriteLine("You Guessed it!, you are a Dove!! ");
                                Console.WriteLine($"You Guessed {guessCounter} times.");
                            }

                        guessCounter += 1;

                    }
                    
                    Console.WriteLine("Do you want to play again?: ");
                    playAgain = Console.ReadLine();
                    playAgain = playAgain.ToLower();
            }
            Console.WriteLine("Thank you for playing the Guess number game!");

    }
}