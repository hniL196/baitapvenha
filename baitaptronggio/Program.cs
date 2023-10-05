

//nhap vao mảng a có n phần tử và 1 số k bất kì
// tìm kiếm xem số k có trong mảng a hay không
// nếu có, in ra vị trí của phần tử có gia trị là k
// nếu không in ra không có
public class clas
{
    public static void Main(string[] args)
    {
        // Khai báo sô phần tử trong mảng
        int n;
        Console.WriteLine("Nhap so phan tu trong mang");
        n = Convert.ToInt32(Console.ReadLine());

        int[] a = new int[n];

        //Duyệt mảng để thêm giá trị từng vị trí trong mảng a
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"Nhap gia tri cua phan tu thu {i} trong mang a:");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        int k;
        Console.WriteLine("Nhap so bat ki");
        k = Convert.ToInt32(Console.ReadLine());
        int check = 0;

        // Duyệt mảng tìm giá tri
        for (int j = 0; j < a.Length; j++)
        {
            if (k == a[j])
            {
                check = 1;
                Console.WriteLine($"{k} co trong mang tai vi tri {j + 1}");
            }
        }

        if( check == 0)
        {
            Console.WriteLine($"{k} khong co trong mang");
        }
    }
}