using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrashtane_Na_Niz
{
    class Program
    {
        static void Main(string[] args)
        {
            string vhod = Console.ReadLine();
            var result = vhod.Reverse();
            Console.WriteLine(new string('-',15));
            Console.WriteLine(string.Join("",result));
        }
    }
}
