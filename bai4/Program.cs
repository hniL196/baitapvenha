using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a) \n");
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
            }


            Console.Write("\n");
            Console.WriteLine("b) \n");
            for (int i = 6; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                    Console.Write("$ ");
                Console.Write("\n");
            }


            Console.Write("\n");
            Console.WriteLine("c) \n");
            for (int i = 1; i <= 6; i++)
            {

                for (int j = 1; j <= 6 - i; j++)
                {
                    Console.Write("_");
                }


                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

    

