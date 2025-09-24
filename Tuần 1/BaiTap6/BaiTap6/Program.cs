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

        }
    }
}
