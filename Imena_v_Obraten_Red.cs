using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imena_V_Obraten_Red
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(string.Join(";",names.Reverse()));
        }
    }
}
