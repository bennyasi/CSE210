﻿using System;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("What is your first name? ");
            string first = Console.ReadLine() ?? "";

            Console.Write("What is your last name? ");
            string last = Console.ReadLine() ?? "";

            Console.WriteLine($"Your name is {last}, {first} {last}.");
        }
    }
}
