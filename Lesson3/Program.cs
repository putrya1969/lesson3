using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!CheckInput("X", out int X) || !CheckInput("Y", out int Y))
            {
                Console.WriteLine("Invalid input");
                Console.ReadKey();
                return;
            }

            if (X > Y)
            {
                int temp = X;
                X = Y;
                Y = temp;
            }

            int sum = 0;
            while (X <= Y)
            {
                sum += X;
                X++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static bool CheckInput(string variableName, out int arg)
        {
            Console.WriteLine($"Enter {variableName}:");
            return int.TryParse(Console.ReadLine(), out arg);
        }
    }
}
//checked
