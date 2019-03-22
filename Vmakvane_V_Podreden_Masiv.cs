using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vmakvame_V_Podreden_Masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Count; i++)
            {
                if (num>=arr[i]&&num<arr[i+1])
                {
                    arr.Insert(i+1, num);
                    break;
                }
                else if(num>=arr[arr.Count-1])
                {
                    arr.Add(num);
                    break;
                }
            }
            Console.WriteLine(string.Join(" ",arr));
           
                    
        }
    }
}
