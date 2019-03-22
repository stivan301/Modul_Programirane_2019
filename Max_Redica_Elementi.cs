using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Redica_El
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var tempCount = 1;
            var Count = 1;
            var number = 0;
            for (int i = 1; i < arr.Length-1; i++)
            {
                if (arr[i]==arr[i-1])
                {
                    tempCount++; 
                }
                else
                {
                    tempCount = 1;
                }
                if (tempCount>=Count)
                {
                    Count = tempCount;
                    number = arr[i];
                }

            }
            for (int i = 0; i <Count; i++)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine( );

        }
    }
}
