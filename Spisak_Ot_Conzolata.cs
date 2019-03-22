using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisak_Ot_Konzolata
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            //Извеждаме списъка с пореден номер на елементите
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("list[{0}]={1}",i,list[i]);
            }
        }
    }
}
