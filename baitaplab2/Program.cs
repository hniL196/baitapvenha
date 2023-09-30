public class baitap
{
    public static void Main(string[] args)
    {
        int nam;
        int thang;

        Console.Write("Nhap so nam: ");
        nam = Convert.ToInt16(Console.ReadLine());

        Console.Write("Nhap so thang: ");
        thang = Convert.ToInt16(Console.ReadLine());

        switch (thang)
        {
            case 1:
                Console.WriteLine("31 ngay");
                break;
            case 2:
                if (nam % 4 == 0)
                    if (nam % 100 != 0)
                        Console.WriteLine("29 ngay");
                    else
                        Console.WriteLine("28 ngay");
                break;
            case 3:
                Console.WriteLine("31 ngay");
                break;
            case 4:
                Console.WriteLine("30 ngay");
                break;
            case 5:
                Console.WriteLine("31 ngay");
                break;
            case 6:
                Console.WriteLine("30 ngay");
                break;
            case 7:
                Console.WriteLine("31 ngay");
                break;
            case 8:
                Console.WriteLine("31 ngay");
                break;
            case 9:
                Console.WriteLine("30 ngay");
                break;
            case 10:
                Console.WriteLine("31 ngay");
                break;
            case 11:
                Console.WriteLine("30 ngay");
                break;
            case 12:
                Console.WriteLine("31 ngay");
                break;
        }
    }
}
