using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        // Load scriptures from file
        List<Scripture> scriptures = Scripture.LoadFromFile("scriptures.txt");
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("\nChoose Difficulty Level:");
        Console.WriteLine("1 - Easy (1 word per round)");
        Console.WriteLine("2 - Medium (3 words per round)");
        Console.WriteLine("3 - Hard (5 words per round)");
        Console.Write("Enter choice: ");
        
        int hideCount = int.Parse(Console.ReadLine()) switch
        {
            1 => 1,
            2 => 3,
            3 => 5,
            _ => 1 // Default to Easy
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($"\n{scripture.HiddenPercentage()}% of words hidden.");
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(hideCount);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden! Well done!");
                break;
            }
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> df6b1e3 (Updated Week 3 assignment files)
