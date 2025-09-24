namespace BaiTap5
{
    internal class Program
    {
        //Kiểm tra năm nhuận
        static bool KtraNamNhuan(int nam)
        {
            if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0)) return true;
            return false;
        }

        //Nhập ngày tháng năm
        static void NhapNgayTN(out int ngay, out int thang, out int nam)
        {
            Console.WriteLine("Nhap ngay ban muon : ");
            ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang ban muon: ");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam ban muon: ");
            nam = int.Parse(Console.ReadLine());
        }

        //Hiển thị thứ trong tuần ứng với ngày tháng
        static void HienThiThuTrongTuan(int ngay, int thang, int nam)
        {
            if (nam <= 0 || thang < 1 || thang > 12)
            {
                Console.WriteLine("Ngay thang nam khong hop le!!!");
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
                    {
                        maxDay = 29;
                    }
                    else
                    {
                        maxDay = 28;
                    }
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
            int month, year, yearOfCentury, century;

            if (ngay >= 1 && ngay <= maxDay)
            {
                if (thang == 1)
                {
                    month = 13;
                    year = nam - 1;
                }
                else if (thang == 2)
                {
                    month = 14;
                    year = nam - 1;
                }
                else
                {
                    month = thang;
                    year = nam;
                }
                yearOfCentury = year % 100;
                century = year / 100;

                int giaTri = (ngay + (13 * (month + 1)) / 5 + yearOfCentury + yearOfCentury / 4 + century / 4 + 5 * century) % 7;

                string[] Thu = { "Thu Bay", "Chu Nhat", "Thu Hai", "Thu Ba", "Thu Tu", "Thu Nam", "Thu Sau" };

                Console.WriteLine("Thu trong tuan la : " + Thu[giaTri]);

            }
            else Console.WriteLine("Ngay thang nam khong hop le");
        }
        static void Main(string[] args)
        {
            int ngay, thang, nam;
            NhapNgayTN(out ngay, out thang, out nam);

            HienThiThuTrongTuan(ngay, thang, nam);
        }
    }
}
