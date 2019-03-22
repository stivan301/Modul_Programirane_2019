using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;

namespace lab3.PhoenxGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex valid = new Regex(@"^([^\s_]{3})([\.]{1}[^\s_]{3})*$");
            
            while(input != "ReadMe")
            {
                if (valid.IsMatch(input))
                {
                    
                    if (isPilandrome(input))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
                
                input = Console.ReadLine();
            }
        }

        private static bool isPilandrome(string input)
        {
            int count = 0;
            int startIndex = 0;
            int lastIndex = input.Length - 1;
            for (int i = 0; i < input.Length; i++)
            {
                char start = input[startIndex];
                char last = input[lastIndex];

               if (input[startIndex] != input[lastIndex])
                {
                    return false;
                }
                else
                {
                    count++;
                    startIndex++;
                    lastIndex--;
                }
                if (count == input.Length / 2)
                {
                    break;
                }
            }
            return true;
        }
    }
}