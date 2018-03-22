using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page245
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ahmed", "Ali", "Abdul", "Sam", "Susie", "Zhanha", "Mark", "Iris", };
            var qureyResults =
                from n in names
                where n.StartsWith("S")
                select n;
            Console.WriteLine("Names strat with (S)");
            foreach(var item in qureyResults)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
