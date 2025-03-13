using System;

class Program 
{
    static void Main(string[] args)  
    {
        Console.Write("What is your first name? ");
        string? firstName = Console.ReadLine() ?? "";  // Ensures it's not null

        Console.Write("What is your last name? ");
        string? lastName  = Console.ReadLine() ?? "";  // Ensures it's not null

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
