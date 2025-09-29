namespace BaiTap6
{
    internal class Program
    {
        //Nhập kích thước ma trận
        static void NhapKichThuocMtran(out int hang, out int cot)
        {
            Console.WriteLine("Nhap so hang cho ma tran: ");
            hang = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot cho ma tran: ");
            cot = int.Parse(Console.ReadLine());
        }
        static void NhapMaTran(int hang, int cot, int[,] matran)
        {
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    matran[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        //a.Duyệt ma trận
        static void DuyetMaTran(int hang, int cot, int[,] matran)
        {
            Console.WriteLine("Cac phan tu cua ma tran la :");
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write(matran[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        //b.Tìm phần tử lớn nhất, nhỏ nhất
        static int TimPhanTuMaxMaTran(int hang, int cot, int[,] matran)
        {
            int max = int.MinValue;
            for(int i = 0; i < hang; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    if (matran[i, j] > max)
                        max = matran[i, j];
                }
            }
            return max;
        }

        //c.Tìm dòng có phần tử lớn nhất
        static int TimDongCoTongPhanTuLonNhat(int hang, int cot, int[,] matran)
        {
            int maxTongDong = 0;
            int tongDong = 0;
            int hangTongMax = -1;
            for(int i = 0; i < hang; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    tongDong += matran[i, j];
                }
                if (tongDong > maxTongDong)
                {
                    maxTongDong = tongDong;
                    hangTongMax = i + 1;
                }
                else continue;
            }
            return hangTongMax;
        }

        //Kiểm tra số nguyên tố
        static bool CheckSoNgTo(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        //d.Tính tổng các số không phải là số nguyên tố
        static int TongCacSoKoLaSoNgTo(int hang, int cot, int[,] matran)
        {
            int tong = 0;
            for(int i = 0; i < hang; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    if (!CheckSoNgTo(matran[i, j]))
                        tong += matran[i, j];
                }
            }
            return tong;
        }

        //e. Xóa dòng thứ k trong ma trận
        static int[,] XoaDongThuKTrongMatran(int hang, int cot, int[,] matran, int k)
        {
            int[,] matran1 = new int[hang - 1, cot];
            bool checkXoa = false;
            for(int i = 0; i < hang - 1; i++)
            {
                if (i + 1 == k) checkXoa = true;
                for (int j = 0; j < cot; j++)
                {   if (checkXoa)
                        matran1[i, j] = matran[i + 1, j];
                    else
                        matran1[i, j] = matran[i, j];
                }
            }
            return matran1;
        }

        //Cột của phần tử lớn nhất trong ma trận nằm ở đâu
        static int TimCotCuaPTuLonNhat(int hang, int cot, int[,] matran)
        {
            int max = int.MinValue;
            int cotCT = -1;
            for(int i = 0; i < hang; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    if (matran[i, j] > max)
                    {
                        max = matran[i, j];
                        cotCT = j;
                    }
                }
            }
            return cotCT + 1;
        }

        //f.Xóa cột chứa phần tử lớn nhất nằm trong ma trận
        static int[,] XoaCotPTuMaxTrongMatran(int hang, int cot, int[,] matran, int cotCX)
        {
            int[,] matran1 = new int[hang, cot - 1];
            bool checkXoa = false;
            for (int i = 0; i < hang; i++)
            {             
                for (int j = 0; j < cot - 1; j++)
                {
                    if (j + 1 == cotCX) checkXoa = true;
                    if (checkXoa)
                    {
                        matran1[i, j] = matran[i, j + 1];
                        checkXoa = false;
                    }    
                    else
                        matran1[i, j] = matran[i, j];
                }
            }
            return matran1;
        }

        static int TimPtuMinMaTran(int hang, int cot, int[,] matran)
        {
            int min = int.MaxValue;
            for(int i = 0; i < hang; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    if (matran[i, j] < min)
                        min = matran[i, j];
                }
            }
            return min;
        }

static void Main(string[] args)
        {
            //Khai báo kích thước ma trận
            int hang, cot;
            NhapKichThuocMtran(out hang,out cot);

            //Khai báo ma trận
            int[,] matran = new int[hang, cot];
            Console.WriteLine("Nhap cac phan tu cua ma tran: ");
            Console.WriteLine("Moi phan tu la mot dong, xuong hang moi nhap tiep!!");

            //Nhập phần tử của ma trận từ bàn phím 
            NhapMaTran(hang, cot, matran);

            //a.Duyệt ma trận
            DuyetMaTran(hang, cot, matran);

            //b.Tìm phần tử lớn nhất, nhỏ nhất
            Console.WriteLine("Phan tu lon nhat cua ma tran la: " + TimPhanTuMaxMaTran(hang, cot, matran));
            Console.WriteLine("Phan tu nho nhat cua ma tran la: " + TimPtuMinMaTran(hang, cot, matran));

            //c.Tìm dòng có tổng lớn nhất 
            Console.WriteLine("Dong co tong lon nhat la :" + TimDongCoTongPhanTuLonNhat(hang, cot, matran));

            //d.Tính tổng các số không phải là số nguyên tố
            Console.WriteLine("Tong cac so khong phai la so nguyen to trong ma tran la : " + TongCacSoKoLaSoNgTo(hang, cot, matran));

            //e.Xóa dòng thứ k trong ma trận
            //Nhập số dòng cần xóa ở ma trận
            int k;
            Console.WriteLine("Nhap so dong can xoa o ma tran");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Ma tran sau khi xoa dong thu k la: ");
            DuyetMaTran(hang - 1, cot, XoaDongThuKTrongMatran(hang, cot, matran, k));

            //f.Xóa cột chứa phần tử max trong ma trận
            int cotCT = TimCotCuaPTuLonNhat(hang, cot, matran);
            Console.WriteLine("Ma tran sau khi xoa cot chua phan tu lon nhat la: ");
            DuyetMaTran(hang, cot - 1, XoaCotPTuMaxTrongMatran(hang, cot, matran, cotCT));

        }
    }
}
