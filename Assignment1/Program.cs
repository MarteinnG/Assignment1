using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Good morning!");
            Console.Write("Write a number: ");

            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                    Console.Write("Write another number:");
                }
                else if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                else 
                {
                    Console.Write("Please enter a NUMBER, not a name or anything containing a letter or a sign: ");
                }
            }

            if(numbers.Count == 0) 
            {
                Console.WriteLine("No numbers available");
            } else
            {
                int lowest = numbers[0];
                int highest = numbers[0];

                foreach (int number in numbers) 
                {
                    if(number < lowest)
                    {
                        lowest = number;
                    }
                    if(number > highest)
                    {
                        highest = number;
                    }
                }

                Console.WriteLine($"The lowest number: {lowest}");
                Console.WriteLine($"The highest number: {highest}");
            }
            

        }

       
    }
}

