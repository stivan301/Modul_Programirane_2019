using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nai_Sreshtano_Chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var tempNum = 0;
            var tempBr = 0;
            var numFinish = 0;
            var brFinish = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j <numbers.Length; j++)
                {
                    if (numbers[i]==numbers[j])
                    {
                        tempNum = numbers[i];
                        tempBr++;
                    }
                    if (j==0)
                    {
                        break;
                    } 
                }
                if (tempBr>brFinish)
                {
                    brFinish = tempBr;
                    numFinish = tempNum;
                }
                

            }
            Console.WriteLine("{0}->{1}",numFinish,brFinish);
        }
    }
}
