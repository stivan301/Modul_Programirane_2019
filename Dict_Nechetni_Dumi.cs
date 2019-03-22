using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Nechetni_Dumi
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');
            Dictionary<string, int> contents = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (contents.ContainsKey(word))
                {
                    contents[word]++;
                }
                else
                {
                    contents[word] = 1;
                }
            }
            var result = new List<string>();
            foreach (var item in contents)
            {
                if (item.Value%2!=0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(",",result));
        }
    }
}
