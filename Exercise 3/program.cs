using System;

class Programm
{
    static void Main()
    {
        // Generate a random magic number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            
            // Ensure valid input
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.Write("Invalid input! Enter a valid number: ");
            }

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}




