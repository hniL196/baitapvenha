using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d;
            d = 2 * 6 - 1;

            for (int a = 1; a <= 6; a++)
            {
                Console.WriteLine();
                for (int b = 1; b <= d; b++)
                {
                    int x = 2 * a - 1;
                    if (b == 6)
                    {
                        if (x > 9)
                            x = x - ((x / 10) * 10);
                        Console.Write(x);
                    }

                    if (b > 6 - a && b < 6 + a)
                    {
                        for (int c = 1; c <= a; c++)
                        {
                            if (b == 6 - c || b == 6 + c)
                            {
                                int y = x - c;
                                if (y > 9)
                                {
                                    y = y - ((y / 10) * 10);
                                }
                                Console.Write(y);
                            }
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}


