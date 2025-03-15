
using System;
class Programr
{
    static void Main()
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine() ?? "0";

        int percent;
        while (!int.TryParse(answer, out percent) || percent < 0 || percent > 100)
        {
            Console.Write("Invalid input! Please enter a valid number (0-100): ");
            answer = Console.ReadLine() ?? "0";
        }

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}