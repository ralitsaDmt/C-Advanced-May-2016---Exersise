using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _05.Sequence_With_Queue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Queue<long> seq = new Queue<long>();

            EnqueueSequece(seq, n);

            PrintSequence(seq);
        }

        private static void PrintSequence(Queue<long> seq)
        {
            Console.WriteLine(string.Join(" ", seq));
        }

        private static void EnqueueSequece(Queue<long> seq, long n)
        {
            seq.Enqueue(n);
            int count = 0;
            Queue<long> nextItem = new Queue<long>();
            nextItem.Enqueue(n);
            long item = nextItem.Peek();

            for (int i = 2; i <= 50; i++)
            {                
                if (i % 50 == 2 + count * 3 || i % 50 == 0)
                {
                    seq.Enqueue(item + 1); 
                }
                else if (i % 50 == 3 + count * 3)
                {
                    seq.Enqueue(2 * item + 1);           
                }
                else if (i % 50 == 4 + count * 3)
                {
                    seq.Enqueue(item + 2);
                }

                if (i % 3 == 1)
                {
                    count++;
                    nextItem.Dequeue();
                    item = nextItem.Peek();
                }
                nextItem.Enqueue(seq.Last());
            }
        }
    }
}
