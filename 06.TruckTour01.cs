using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Tour_01
{
    class TruckTour01
    {
        static void Main(string[] args)
        {
            long pumps = long.Parse(Console.ReadLine());

            Queue<string> moves = new Queue<string>();

            for (long i = 0; i < pumps; i++)
            {
                moves.Enqueue(Console.ReadLine());
            }

            bool isFullCircle = false;

            for (long i = 0; i < pumps; i++)
            {
                long fuel = 0;
                foreach (var item in moves)
                {
                    fuel += item.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(long.Parse)
                        .ToArray()[0];
                    fuel -= item.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(long.Parse)
                        .ToArray()[1];

                    if (fuel < 0)
                    {
                        isFullCircle = false;
                        break;
                    }
                    else
                    {
                        isFullCircle = true;
                    }
                }
                if (isFullCircle)
                {
                    Console.WriteLine(i);
                    return;
                }

                string tmp = moves.Dequeue();
                moves.Enqueue(tmp);
            }

        }  
    }
}
