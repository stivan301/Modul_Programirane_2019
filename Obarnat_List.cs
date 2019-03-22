using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obarnat_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split(' ').ToList();
            List<int> reversArr = new List<int>();
            for (int index = 0; index < elements.Count; index++)
            {
                var result = new List<char>(elements[index].ToCharArray());
                result.Reverse();
                var str = "";
                for (int i = 0; i < result.Count; i++)
                {
                    str = str + result[i];
                }
                reversArr.Add(int.Parse(str));

            }
            Console.WriteLine(reversArr.Sum());
            Console.WriteLine(string.Join(" ", reversArr));
        }
    }
}
