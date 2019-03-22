using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniorska_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            var index = 1;
            Dictionary<string, List<int>> metalsQuantity = new Dictionary<string, List<int>>();
            var command = Console.ReadLine();
            while (command!="stop")
            {
                if (index%2!=0)
                {
                    var metal = command;
                    var quantity = int.Parse(Console.ReadLine());
                    if (metalsQuantity.ContainsKey(metal))
                    {
                        foreach (var item in metalsQuantity)
                        {
                            if (item.Key==metal)
                            {
                                item.Value.Add(quantity);
                            }
                            break;
                        }
                    }
                    else
                    {
                        List<int> kolichestvo = new List<int>();
                        kolichestvo.Add(quantity);
                        metalsQuantity.Add(metal, kolichestvo);
                    }
                }
                command = Console.ReadLine();
                index = index + 2; ;
            }
            foreach (var item in metalsQuantity)
            {
                Console.WriteLine("{0}->{1}",item.Key,string.Join(" ",item.Value.Sum()));
            }
        }
    }
}
