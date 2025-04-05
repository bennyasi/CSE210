using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine()?.Trim();

        while (string.IsNullOrWhiteSpace(name)) // Prevent empty input
        {
            Console.Write("Name cannot be empty! Please enter your name: ");
            name = Console.ReadLine()?.Trim();
        }

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number;

        // Validate input to ensure it's a number
        while (!int.TryParse(input, out number))
        {
            Console.Write("Invalid input! Please enter a valid number: ");
            input = Console.ReadLine();
        }

        return number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}
