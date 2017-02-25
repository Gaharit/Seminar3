using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void ChessTest(string position1, string position2)
        {
            Console.WriteLine("\nPossibility of this turn:\n");
            Console.Write("For bishop: ");
            if (Math.Abs(position2[0] - position1[0]) == Math.Abs(position2[1] - position1[1]) &&
                (position2[0] - position1[0])*(position2[1] - position1[1]) != 0)
                Console.WriteLine("possible");
            else Console.WriteLine("impossible");

            Console.Write("For knight: ");
            if (Math.Abs(position2[0] - position1[0]) == 2 && Math.Abs(position2[1] - position1[1]) == 1 ||
                Math.Abs(position2[0] - position1[0]) == 1 && Math.Abs(position2[1] - position1[1]) == 2)
                Console.WriteLine("possible");
            else Console.WriteLine("impossible");

            Console.Write("For rook:   ");
            if (position2[0] == position1[0] ^ position2[1] == position1[1])
                Console.WriteLine("possible");
            else Console.WriteLine("impossible");

            Console.Write("For queen:  ");
            if ((Math.Abs(position2[0] - position1[0]) == Math.Abs(position2[1] - position1[1]) &&
                       (position2[0] - position1[0]) * (position2[1] - position1[1]) != 0) ||
              position2[0] == position1[0] ^ position2[1] == position1[1])
                Console.WriteLine("possible");
            else Console.WriteLine("impossible");

            Console.Write("For king:   ");
            if (Math.Max(Math.Abs(position2[0] - position1[0]), Math.Abs(position2[1] - position1[1])) == 1)
                Console.WriteLine("possible");
            else Console.WriteLine("impossible");
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter position 1 and position 2: ");
                string[] input = Console.ReadLine().Split(' ');
                ChessTest(input[0], input[1]);
                Console.WriteLine("\nAgain?");
            } while (Console.ReadLine() != "no");
        }
    }
}
