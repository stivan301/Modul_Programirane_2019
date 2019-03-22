using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Sgani_I_Sabery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тук ще поставим кода за решение на задачата!
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            var k = numbers.Length / 4;
            var result1 = numbers.Take(k).Reverse().ToArray();
            var result2 = numbers.Skip(3 * k).Take(k).Reverse().ToArray();
            var arr1 = result1.Concat(result2).ToArray();
            var arr2 = numbers.Skip(k).Take(2 * k).ToArray();
            int[] sum = new int[arr1.Length];
            for (int i = 0; i < 2*k; i++)
            {
                sum[i] = arr1[i] + arr2[i];
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
