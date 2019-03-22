using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistika_Na_Masiv_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result1 = numbers.Min();
            var result2 = numbers.Max();
            var result3 = numbers.Sum();
            var result4 = numbers.Average();
            Console.WriteLine("Min={0}",result1);
            Console.WriteLine("Max={0}",result2);
            Console.WriteLine("Sum={0}",result3);
            Console.WriteLine("Average={0}",result4);
        }
    }
}
