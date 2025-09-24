namespace BaiTap4
{
    internal class Program
    {
        //Kiểm tra năm nhuận
        static bool KtraNamNhuan(int nam)
        {
            if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0)) return true;
            return false;
        }

        //Nhập tháng năm
        static void NhapThangNam(out int thang, out int nam)
        {
            Console.WriteLine("Nhap thang : ");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            nam = int.Parse(Console.ReadLine());
        }

        //Hiển thị số ngày của tháng đó
        static void HienThiSoNgayCuaThangHopLe(int thang, int nam)
        {
            if (nam < 0 || thang < 1 || thang > 12)
            {
                Console.WriteLine("Thang hoac nam khong hop le");
                return;
            }

            int maxDay;
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    maxDay = 31;
                    break;
                case 2:
                    if (KtraNamNhuan(nam))
                        maxDay = 29;
                    else maxDay = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    maxDay = 30;
                    break;
                default:
                    maxDay = 0;
                    break;

            }

            if (maxDay >= 1) Console.WriteLine("So ngay cua thang do la: " + maxDay);
            else Console.WriteLine("Khong co ngay hop le");
        }

        static void Main(string[] args)
        {
            int thang, nam;
            NhapThangNam(out thang, out nam);

            HienThiSoNgayCuaThangHopLe(thang, nam);
        }
    }
}
