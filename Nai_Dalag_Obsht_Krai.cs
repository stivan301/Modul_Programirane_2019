using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nai_Dalag_Obsht_Krai
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = Console.ReadLine().Split(' ').ToArray();
            var str2 = Console.ReadLine().Split(' ').ToArray();
            var n1 = str1.Length;
            var n2 = str2.Length;
            var n = n1 - n2;
            if (n<0)
            {
                n = str1.Length;
            }
            else
            {
                n = str2.Length;
            }
            var br1 = 0;
            var br2 = 0;
            // Да се допише кода!!!
            for (int i = 0; i < n; i++)
            {
                if (str1[i]==str2[i])
                {
                    br1++;
                }
            }
            //Обратно сканиране
            var index = 0;
            if (n1<=n2)
            {
                index++;
                for (int i = n-1; i >=0 ; i--)
                {
                    if (str1[i]==str2[n2-index])
                    {
                        br2++;
                    }
                    index++;
                }
            }
            else if (n2<n1)
            {
                index++;
                for (int i = n - 1; i >= 0; i--)
                {
                    if (str1[n1-index] == str2[i])
                    {
                        br2++;
                    }
                    index++;
                }
            }
            if (br1>=br2)
            {
                Console.WriteLine(br1);
            }
            else
            {
                Console.WriteLine(br2);
            }

        }
    }
}
