using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> productPriceQuantity = new Dictionary<string, List<double>>();
            var command = Console.ReadLine().Split(' ').ToArray();
            var name = " ";var price = 0.0; var quantity = 0.0;
            while (command[0]!="stocked")
            {
                name = command[0];
                price = double.Parse(command[1]);
                quantity = double.Parse(command[2]);
                if (productPriceQuantity.ContainsKey(name))
                {
                    foreach (var item in productPriceQuantity)
                    {
                        if (item.Key==name)
                        {
                            if (item.Value[0]!=price)
                            {
                                item.Value[0] = price;
                                item.Value[1] = quantity+item.Value[1];
                            }
                            else
                            {
                                item.Value[1] = quantity + item.Value[1];
                            }
                        }
                    }
                }
                else
                {
                    List<double> ProductPrice = new List<double>();
                    ProductPrice.Add(price);
                    productPriceQuantity.Add(name, ProductPrice);
                    ProductPrice.Add(quantity);
                    productPriceQuantity[name] = ProductPrice;
                }
                //Следващ цикъл на командите!
                command = Console.ReadLine().Split(' ').ToArray();
            }
            double sum = 0;
            foreach (var item in productPriceQuantity)
            {
                Console.WriteLine("{0}: ${1:F2} * {2} = ${3:F2}",item.Key,item.Value[0],item.Value[1],item.Value[0]*item.Value[1]);
                sum=sum+item.Value[0] * item.Value[1];
            }
            Console.WriteLine(new string('-',30));
            Console.WriteLine("Grand Total: ${0:F2}",sum);
        }
    }
}
