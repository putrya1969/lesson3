using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "qwe";
            if (str == "qaz")
            {
                Console.WriteLine("string equal qaz");
            }
            else 
            {
                Console.WriteLine("string not equal qaz");
            }

            switch (str)
            {
                case "qaz":
                    Console.WriteLine("string equal qaz");
                    break;
                default:
                    Console.WriteLine("string not equal qaz");
                    break;
            }
            //int i = 1;
            //int sum = 0;
            //while (i <= 10 )
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            int i = 1;
            int sum = 0;
            do
            {
                sum += i;
                i++;
            }
            while (i <= 10);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
