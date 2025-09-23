namespace BaiTap2
{
    internal class Program
    {
        static bool KtraSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so nguyen duong n: ");
            n = int.Parse(Console.ReadLine());
            int tong = 0;
            for (int i = 1; i < n; i++)
            {
                if (KtraSoNguyenTo(i))
                    tong += i;
            }
            Console.WriteLine("Tong cac so nguyen to nho hon n la : " + tong);
        }
    }
}
