using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incrementacia
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 5;
            Increment(num, 15);
            Console.WriteLine(num);
        }
        static void Increment(int num,int value)
        {
            num += value;
        }
    }
}
