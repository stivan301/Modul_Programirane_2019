using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Icarus_Finall
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var start = int.Parse(Console.ReadLine());  
            var commands = Console.ReadLine().Split(' ').ToArray();
            var damaget = 1;
            while (commands[0]!="Supernova")
            {
                if (commands[0]=="left")
                {
                    var step = int.Parse(commands[1]);
                    while (step>0)
                    {
                        if ((start - 1) == -1)
                        {
                            damaget++;
                            start = elements.Length - 1;
                            elements[start] -= damaget;
                            step--;
                        }
                        else
                        {
                            elements[start - 1] -= damaget;
                            start--;
                            step--;
                        }
                        
                       
                    }
                }

                    //Проверка за движение на дясно!
                    if (commands[0] == "right")
                    {
                        var step = int.Parse(commands[1]);
                        while (step > 0)
                    {
                        if ((start+1)==elements.Length)
                        {
                            damaget++;
                            start = 0;
                            elements[start] -= damaget;
                            step--;
                        }
                        else
                        {
                            elements[start + 1] -= damaget;
                            start++;
                            step--;
                        }
                           
                        }
                    }
                
                commands = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
