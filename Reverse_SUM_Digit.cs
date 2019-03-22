using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revers_Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            var ch = "";

            List<string> charList = new List<string>();
            var num = 0;
            var digit =0;
            for (int index = 0; index < elements.Count; index++)
            {
                
                num = elements[index];
                while (num>0)
                {
                    digit = num % 10;
                    result.Add(digit);
                    num = num / 10;       
                }
                foreach (var item in result)
                {
                    ch = ch + item.ToString();  
                }
                charList.Add(ch);
                ch.Remove(index,elements.Count);
            }
            Console.WriteLine(string.Join(" ",charList));
        }
    }
}
