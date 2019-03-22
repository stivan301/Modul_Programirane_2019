using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tel_Pthonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> pthonebook = new Dictionary<string, string>();
            var command = Console.ReadLine().Split(' ').ToArray();
            string name; string tel;
            while (command[0]!="END")
            {  //Да се допише липсващия код
                if (command[0]=="A")
                {
                    name = command[1];
                    tel = command[2];
                    if (pthonebook.ContainsKey(name))
                    {
                        pthonebook[name] = tel;
                    }
                    else
                    {
                        pthonebook.Add(name, tel);
                    }
                }
                if (command[0]=="S")
                {
                   var name1 = command[1];
                    //Търсим човек с такова име
                    if (pthonebook.ContainsKey(name1))
                    {
                        foreach (var item in pthonebook)
                        {
                            if (item.Key==name1)
                            {
                                Console.WriteLine("{0}->{1}",item.Key,item.Value);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.",name1);
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }//end while
           
        }
    }
}
