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
            float laisuatthang, tienlaithang, tiengui, sothang, laisuat;

            Console.Write("So tien gui tiet kiem: ");
            tiengui = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write("Lãi suất năm: ");
                laisuat = Convert.ToInt16(Console.ReadLine());
            } while (laisuat<=0 || laisuat>20);

            Console.Write("Số tháng gửi: ");
            sothang = Convert.ToInt16(Console.ReadLine());

            laisuatthang = (laisuat / 12) / 100;
            
            Console.WriteLine(laisuatthang);

            Console.WriteLine("\n");
            Console.Write("Số tháng       Tiền gốc+lãi       Tiền lãi tháng");
            Console.Write("\n");


            for (int i = 1; i <= sothang; i++)
            {
                {
                    Console.Write($"   {i}               {tiengui}             {tienlaithang=(tiengui*laisuatthang)}");
                    tiengui += tienlaithang;
                    Console.Write("\n");
                }               
            }
        }
    }
}
