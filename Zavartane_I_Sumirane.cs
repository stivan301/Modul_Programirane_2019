using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavartane_I_Sumirane
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = int.Parse(Console.ReadLine());
            var sum = new int[numbers.Length];
            while (k>0)
            {
                RotateArray(numbers);
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum[i] += numbers[i];
                }
                k--;
            }
            Console.WriteLine(string.Join(" ",sum));  
        }
        //end global metod
        static void RotateArray(int[] arr)
        {
            var bufer = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = bufer;

        }

    }
}
