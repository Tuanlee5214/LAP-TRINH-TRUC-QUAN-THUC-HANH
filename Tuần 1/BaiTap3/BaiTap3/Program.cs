using System.Linq.Expressions;

namespace BaiTap3
{
    
    internal class Program
    {
        //Kiểm tra năm nhuận
        static bool KtraNamNhuan(int nam)
        {
            if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0)) return true;
            return false;
        }

        static void Main(string[] args)
        {
            int ngay, thang, nam;
            Console.WriteLine("Nhap ngay ban muon : ");
            ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang ban muon: ");
            thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam ban muon: ");
            nam = int.Parse(Console.ReadLine());
            if (nam <= 0 || thang < 1 || thang > 12)
            {
                Console.WriteLine("Ngay thang nam khong hop le!!!");
                return;
            }
            int maxDay;
            switch(thang)
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
                    if(KtraNamNhuan(nam))
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

            if (ngay >= 1 && ngay <= maxDay) Console.WriteLine("Ngay thang nam hop le");
            else Console.WriteLine("Ngay thang nam khong hop le");
            
        }
    }
}
