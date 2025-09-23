namespace BaiTap1
{
    internal class Program
    {
        //a.Tính tổng các số lẻ trong mảng
        static int TinhTongSoLeTrongMang(int[] mang)
        {
            int tong = 0;
            for(int i = 0; i < mang.Length; i++)
            {
                if (mang[i] % 2 != 0)
                    tong += mang[i];
            }
            return tong;
        }

        //b.Đếm số nguyên tố trong mảng
        static bool KtraSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static int DemSoNguyenToTrongMang(int[] mang)
        {
            int dem = 0;
            for(int i = 0; i < mang.Length; i++)
            {
                if (KtraSoNguyenTo(mang[i]))
                    dem++;
            }
            return dem;
        }

        //c.Tìm số chính phương nhỏ nhất
        static bool KtraSoChinhPhuong(int n)
        {
            int x = (int)Math.Sqrt(n);
            return x * x == n;
        }

        static int TimSoChinhPhuongNhoNhat(int[] mang)
        {
            int soCanTim = int.MaxValue;
            for(int i = 0; i < mang.Length; i++)
            {
                if (KtraSoChinhPhuong(mang[i]) && mang[i] < soCanTim)
                    soCanTim = mang[i];
            }
            if (soCanTim == int.MaxValue) return -1;
            else return soCanTim;
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so luong phan tu cua mang : ");
            n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            Console.WriteLine("Nhap cac phan tu cua mang : ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + (i + 1) + " cua mang: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tong cac so le o trong mang la: " + TinhTongSoLeTrongMang(mang));
            Console.WriteLine("So cac so nguyen to trong mang la: " + DemSoNguyenToTrongMang(mang));
            Console.WriteLine("So chinh phuong nho nhat trong mang la: " + TimSoChinhPhuongNhoNhat(mang));
        }
    }
}
