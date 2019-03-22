using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masiv_V_Chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = nums.Length;
            while (n>1)
            {
                int[] condenset = new int[nums.Length-1];
               
                for (int i = 0; i < nums.Length-1; i++)
                {
                    condenset[i] = nums[i] + nums[i + 1];
                    nums[i] = condenset[i];
                }
                n--;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
