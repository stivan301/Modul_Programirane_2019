using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Spisak_S_Imena
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine().Split(',').ToList();
            name.Reverse();
            var result = new List<string>();
            for (int i = 0; i < name.Count; i++)
            {
                result = name[i].Split(' ').ToList();
                result.Reverse();
                Console.WriteLine(string.Join(" ",result));
            }
            
        }
    }
}
