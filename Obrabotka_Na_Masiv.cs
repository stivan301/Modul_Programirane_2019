using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrabotka_na_Masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(' ').ToArray();
            var n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                var command = Console.ReadLine().Split(' ').ToArray();
                if (command[0]== "Reverse")
                {
                    Array.Reverse(text);
                }
                if (command[0]== "Distinct")
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        for (int j = i+1; j <=text.Length-1; j++)
                        {
                            if (text[i]==text[j])
                            {
                                Array.Clear(text, j, 1);
                            }
                        }
                        if (text.Length-(text.Length-i)==0)
                        {
                            break;
                        } 
                    }
                }
                if (command[0]== "Replace")
                {
                    var index = int.Parse(command[1]);
                    var strZam = command[2];
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (i==index)
                        {
                            Array.Clear(text, index, 1);
                            text[i] = strZam;
                            break;
                        }
                    }
                }
                n--;
            }
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i]==null)
                {

                }
                else if(text[i]!=text[text.Length-1])
                {
                    Console.Write(text[i] + ",");
                }
                else
                {
                    Console.Write(text[i]);
                } 
            }
            Console.WriteLine();
        }
    }
}
