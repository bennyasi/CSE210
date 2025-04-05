using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber;
while (true)
{
    Console.Write("Enter a number (0 to quit): ");
    
    if (int.TryParse(Console.ReadLine(), out userNumber)) // Validate and parse in one step
    {
        if (userNumber == 0) break; // Exit loop if user enters 0
        numbers.Add(userNumber);
    }
    else
    {
        Console.WriteLine("Invalid input! Please enter a valid integer.");
    }
}


        if (numbers.Count > 0) // Ensure the list isn't empty before calculations
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max) max = number;
            }
            Console.WriteLine($"The max is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
