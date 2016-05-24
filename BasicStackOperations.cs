using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Stack_Operations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> numbers = new Stack<int>();

            int count = input[0];
            int toPop = input[1];
            int present = input[2];

            int[] tmp = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < count; i++)
            {
                numbers.Push(tmp[i]);
            }

            for (int i = 0; i < toPop; i++)
            {
                numbers.Pop();
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (numbers.Contains(present))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }

        }
    }
}
