using System;

public class bai2
{
    public static void Main(string[] args)
    {
        int a;

        Console.WriteLine("Nhap so bat ky: ");
        a = Convert.ToInt16(Console.ReadLine());

        TimeSpan result = TimeSpan.FromSeconds(a);
        string fromTimeString = string.Format("{0:D2} Gio {1:D2} Phut {2:D2} Giay",result.Hours, result.Minutes,result.Seconds);

        Console.WriteLine(fromTimeString);
    }
}