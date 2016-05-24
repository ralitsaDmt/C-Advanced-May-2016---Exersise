using System;
using System.Collections.Generic;

class ReverseNumbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Stack<long> numbers = new Stack<long>();

        foreach (var element in input)
        {
            numbers.Push(int.Parse(element));
        }

        Console.WriteLine(string.Join(" ", numbers));    
    }
}
