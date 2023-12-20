class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap chieu dai mang");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n+1];
        Console.WriteLine("Nhap cac gia tri cua mang");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Gia tri cua mang la: ");
        for(int i = 0;i < n; i++)
        {
            Console.Write(array[i] + "  ");
        }
        Console.WriteLine("Nhap gia tri can them: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vi tri can them: ");
        int p = int.Parse(Console.ReadLine());
        for (int i = n; i >=p; i--)
        {
            array[i] = array[i-1];
        }
        array[p - 1] = x;
        Console.WriteLine("Mang moi la: ");
        for (int i = 0; i<n; i++)
        {
            Console.Write(array[i] + "  ");
        }
    }
}