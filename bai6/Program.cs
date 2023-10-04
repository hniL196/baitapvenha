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
            int[] list = new int[11];

            for (int a = 0; a < 11; a++)
            {
                list[a] = (a + 1);
            }

            Console.WriteLine($"{list[3]}");

            for (int i = 1; i <= 6; i++)
            {
                // In ra các khoảng trống trước hàng i để tạo thành hình tam giác
                for (int j = 1; j <= 6 - i; j++)
                {
                    Console.Write("_");
                }

                // In ra các dấu * cho hàng thứ i
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write($"{k}");
                }
                Console.WriteLine();
            }
        }
    }
}

