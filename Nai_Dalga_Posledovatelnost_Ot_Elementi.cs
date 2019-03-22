using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nai_Dalga_Posl_Ot_Elementi
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var tempLen = 1;
           
            var number = 0;
            var maxLen = 1;
           
            for (int i = 1; i < elements.Length-1; i++)
            {
                if (elements[i]==elements[i-1])
                {
                    tempLen++;
                }
                else
                {
                    tempLen = 1;
                   
                }
                if (tempLen>maxLen)
                {
                    maxLen = tempLen;
                    number = elements[i];
                }
            }
            if (maxLen<elements.Length-1&&number!=elements[elements.Length-1])
            {
                for (int i = 0; i < maxLen; i++)
                {
                    Console.Write(number+" ");
                }
            }
            else
            {
                for (int i = 0; i <= maxLen; i++)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
