using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlecome let's start the game");
            Console.WriteLine("What is the result of 22 * 1 + 2");
            int result = Convert.ToInt32(Console.ReadLine());
            while (result > 1)
            {
                if(result == 24)
                {
                    Console.WriteLine("wow");
                }
                else
                {
                    Console.WriteLine("sorry");
                }
                Console.ReadKey();
                return;
                


            }

        }
    }
}
