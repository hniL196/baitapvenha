using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sothang;
            double laisuat, tiengui,tienlai, tienlai1;

            Console.Write("Số tiền gửi tiết kiệm: ");
            tiengui = Convert.ToInt16(Console.ReadLine());

            do
            {
                Console.Write("Lãi suất năm: ");
                laisuat = Convert.ToDouble(Console.ReadLine());
            } while (laisuat<=0 || laisuat>20);
            
            do
            {
                Console.Write("Số tháng gửi: ");
                sothang = Convert.ToInt16(Console.ReadLine());
            }while (sothang <1 || sothang>12);

            Console.WriteLine("\n");
            Console.Write("Số tháng       Tiền gốc+lãi       Tiền lãi tháng");
            Console.Write("\n");


            for (int i = 1; i <= sothang; i++)
            {
                if (i == 1)
                {
                    tienlai = (laisuat / 12) / 100;
                    Console.Write($"{i}       {tiengui}       {tienlai}");
                    Console.Write("\n");
                }
                else
                    tienlai1 = tiengui + tienlai;
                    Console.Write($"{i}       {tiengui*tienlai1}       {tiengui = (laisuat / 12) / 100}");
                    Console.Write("\n");

            }
        }
    }
}
