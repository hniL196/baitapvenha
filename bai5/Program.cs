using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Nhap canh a: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Nhap canh b: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Nhap canh c: ");
            c = Convert.ToInt16(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
                Console.WriteLine("3 cạnh bạn vừa nhập không cấu thành hình tam giác");
            else if (a == b && b == c)
                Console.WriteLine("Tam giác đều");
            else if (a == b && a != c || a == c && a != b)
                Console.WriteLine("Tam giác cân");
            else if (a*a + b*b  == c*c || a*a + c*c == b*b || b*b + c*c == a*a )
                Console.WriteLine("Tam giác vuông");
        }
    }
}
