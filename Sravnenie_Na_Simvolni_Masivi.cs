using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sravnenie_Na_Simvolni_Masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = Console.ReadLine().Split(' ').ToArray();
            var str2 = Console.ReadLine().Split(' ').ToArray();
            var n1 = str1.Length;
            var n2 = str2.Length;
            var n = 0;
            if (n1<n2)
            {
                n = n1;
            }
            else
            {
                n = n2;
            }
            var br = 0;
            for (int i = 0; i < n; i++)
            {
                if (str1[i]==str2[i])
                {
                    br++;
                }
            }
            if (br==n)
            {
                Console.WriteLine(string.Join(" ",str1));
                Console.WriteLine(string.Join(" ",str2));
            }
        }
    }
}
