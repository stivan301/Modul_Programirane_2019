using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrashtane_na_Masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i <n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            var result = arr.Reverse();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
