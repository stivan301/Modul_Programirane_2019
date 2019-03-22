using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dvumeren_Masiv
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var row = int.Parse(Console.ReadLine());
           
            var col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, col];
            //Въвеждаме елементите на матрицата
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   
                    matrix[i, j] = int.Parse(Console.ReadLine());
                   
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double sum = 0;
                int count = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+" ");
                    sum = sum + matrix[i, j];
                    count++;
                }
                Console.Write("{0:f2}",sum/count);
                Console.WriteLine();
            }
        }
    }
}
