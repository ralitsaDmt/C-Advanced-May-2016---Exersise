using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> sequence = new Stack<int>();
            Stack<int> maxElements = new Stack<int>();
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                switch (command[0])
                {
                    case 1:
                        {
                            sequence.Push(command[1]);
                            if (command[1] > max)
                            {
                                max = command[1];
                                maxElements.Push(command[1]);
                            }
                            break;
                        }
                    case 2:
                        {
                            if (sequence.Count != 0 && maxElements.Count != 0)
                            {
                                if (sequence.Peek() == maxElements.Peek())
                                {
                                    maxElements.Pop();
                                    if (maxElements.Count > 0)
                                    {
                                        max = maxElements.Peek();
                                    }
                                    else
                                    {
                                        max = int.MinValue;
                                    } 
                                }
                                sequence.Pop();
                            }
                            break;      
                        }
                    case 3: Console.WriteLine(maxElements.Peek()); break;
                }

            }
        }
    }
}
