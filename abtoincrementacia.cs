using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtoincrementna
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            //���������
            int c1 = a++ + b;
            //����� �� ��������� (a+b) � ���� ���� a=a+1;
            Console.WriteLine(c1);
            // a->a+1 � ���� ���� �� �� ������� b: (++a1+b1) � ������������ �� (a1+1+b1)
            int a1 = 2, b1 = 3;
            //�������������
            int c2 = ++a1 + b1;
            Console.WriteLine(c2);
            int a2 = 2, b2 = 3;
            int c3 = (a2-- + b2);
            Console.WriteLine(c3);// 5
            int a3 = 2, b3 = 5;
            int c4 = (--a3) + b3;// 6
            Console.WriteLine(c4);

        }
    }
}
