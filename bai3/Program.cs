using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 999; i++)
            {
                int a = i / 100;
                int b = (i / 10) % 10;
                int c = i % 10;

                if ((a + b + c) % 2 == 0)
                Console.WriteLine(i);
            }
            //tính thử để tìm hàng trăm,chục,đơn vị
            //int d = 757;
            //Console.WriteLine(d/100);
            //Console.WriteLine((d / 10) % 10);
            //Console.WriteLine(d%10);
            
        }
    }
}
