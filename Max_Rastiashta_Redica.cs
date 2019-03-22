using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Rastiashta_redica
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int len = 1, bestlen = 1, bestStart = 0, lastElement = 0;

            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i]+1 ==arr[i + 1])
                {
                    len++;
                    if (len > bestlen)
                    {
                        bestlen = len;
                        lastElement = i + 1;
                        bestStart = lastElement - bestlen + 1;
                    }
                }
                else len = 1;
            }

            for (int i = bestStart; i < bestlen + bestStart; i++) Console.Write( arr[i]+" ");
        }
    }
}
