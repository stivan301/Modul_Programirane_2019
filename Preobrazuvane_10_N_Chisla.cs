using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preobrazuvane_10_N_ichna
{
    class Program
    {
        static void Main(string[] args)
        {
            var comannd = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var osnova = comannd[0];
            var number = comannd[1];
            List<int> result = new List<int>();
            var digit = 0;
          
            while (number>0)
            {
                digit = number % osnova;
                number = number / osnova;
                result.Add(digit);
            }
            result.Reverse();
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
