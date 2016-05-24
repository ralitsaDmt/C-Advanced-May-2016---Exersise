using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementsToEnqueue = input[0];
            int elementToDequeue = input[1];
            int elementToChecFor = input[2];

            Queue<int> numbers = new Queue<int>();

            //Enqueue elements
            int[] tmp = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            EnqueueElements(tmp, numbers);
            DequeueElements(numbers, elementToDequeue);
            CheckForElement(numbers, elementToChecFor);
        }

        private static void CheckForElement(Queue<int> numbers, int elementToChecFor)
        {
            int min = int.MaxValue;
            if (numbers.Count > 0)
            {
                while (numbers.Count != 0)
                {
                    if (elementToChecFor == numbers.Peek())
                    {
                        Console.WriteLine("true");
                        return;
                    }
                    else
                    {
                        if (min > numbers.Peek())
                        {
                            min = numbers.Peek();                        
                        }
                        numbers.Dequeue();
                    }
                }
                Console.WriteLine(min);
                return;
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        private static void DequeueElements(Queue<int> numbers, int elementToDequeue)
        {
            for (int i = 0; i < elementToDequeue; i++)
            {
                numbers.Dequeue();
            }
        }

        private static void EnqueueElements(int[] tmp, Queue<int> numbers)
        {
            foreach (var element in tmp)
            {
                numbers.Enqueue(element);
            }
        }
    }
}
