using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indeks_Na_Bukva
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] leters = new char[26];
            int index = 0;
            //Въвеждаме масива от букви
            for (char i = 'a'; i <='z'; i++)
            {
                leters[index] = i;
                index++;
            }
            var word = Console.ReadLine().ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < leters.Length; j++)
                {
                    if (word[i]==leters[j])
                    {
                        Console.WriteLine("{0}->{1}",word[i],j);
                    }
                }
            }
        }
    }
}
