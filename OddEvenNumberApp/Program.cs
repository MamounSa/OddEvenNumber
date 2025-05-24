using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Sample array of numbers
        int[] numbers = { 3, 8, 15, 22, 7 };

        // Call OddEvenNumber function with a title and the array
        PrintNumber("Odd-Even Classification", numbers);
        PrintNumber("", numbers.Where(x => x % 2 == 0));
        PrintNumber("", numbers.Where(x => x % 2 != 0));

    }

    // Function to classify numbers as Odd or Even
    static void PrintNumber(string title, IEnumerable<int> numbers)
    {
        Console.WriteLine($"\n{title}");
        Console.WriteLine("Hi mamoun salousi");
        foreach (var num in numbers)
        {
            Console.WriteLine($"{num} is {(num % 2 == 0 ? "Even" : "Odd")}");
        }
    }
    static int Add(int x,int y)
    {
        return x + y;
    }
    static int Sup(int x,int y)
        { return x - y; }
}