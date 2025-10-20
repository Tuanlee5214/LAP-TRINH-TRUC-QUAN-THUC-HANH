using System;
using System.Text;
namespace BaiTap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("  Số hàng của ma trận: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("  Số cột của ma trận: ");
            int n = int.Parse(Console.ReadLine());
            while (m <= 0 && n <= 0 || m * n < 0)
            {
                Console.Clear();
                Console.WriteLine("Không tồn tại ma trận để thực hiện tiếp, vui lòng nhập lại");
                Main(args);
            }
            int[,] matrix = new int[m, n];
            choose(m, n, matrix);
        }
        static void matrixImport(int r, int c, int[,] matrix)
        {
            Random random = new Random();
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    matrix[i, j] = random.Next(10, 99); ;
        }
        static void matrixExport(int r, int c, int[,] matrix)
        {
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write(" " + matrix[i, j]);
                Console.WriteLine();
            }
        }
        static void findKey(int r, int c, int[,] matrix)
        {
            Console.Write("  Phần tử cần tìm nằm ở hàng: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("  Phần tử cần tìm nằm ở cột: ");
            int y = int.Parse(Console.ReadLine());
            Console.Clear();
            if (x >= r || x < 0 || y >= c || y < 0)
            {
                Console.WriteLine("Không tồn tại phần tử tại tọa độ ({0},{1})", x, y);
                return;
            }
            else Console.WriteLine("Phần tử tại tọa độ ({0},{1}) là {2}", x, y, matrix[x, y]);
        }
        static bool isPrime(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i < x - 1; i++)
                if (x % i == 0)
                    return false;
            return true;
        }
        static void primeExport(int r, int c, int[,] matrix)
        {
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    if (isPrime(matrix[i, j]))
                        Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        static int maxPrimeAmountCollum(int r, int c, int[,] matrix)
        {
            int primeCount(int row)
            {
                int count = 0;
                for (int j = 0; j < c; j++)
                    if (isPrime(matrix[row, j]))
                        count++;
                return count;
            }
            int max = 0;
            for (int i = 0; i < r; i++)
                if (primeCount(i) > primeCount(max))
                    max = i;
            return max;
        }
        static void menu()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("  (1) Tạo ma trận");
            Console.WriteLine("  (2) Tìm một phần tử tại vị trí (x,y)");
            Console.WriteLine("  (3) Xuất các phần tử là số nguyên tố");
            Console.WriteLine("  (4) Cho biết dòng nào có nhiều số nguyên tố nhất");
            Console.WriteLine("  (5) Thoát");
            Console.WriteLine("-------------------------------------------------------");
        }
        static void choose(int r, int c, int[,] matrix)
        {
            menu();
            Console.Write("   Lựa chọn của bạn là: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    matrixImport(r, c, matrix);
                    matrixExport(r, c, matrix);
                    choose(r, c, matrix);
                    break;
                case 2:
                    findKey(r, c, matrix);
                    choose(r, c, matrix);
                    break;
                case 3:
                    Console.Write("Các số nguyên tố trong ma trận là: ");
                    primeExport(r, c, matrix);
                    choose(r, c, matrix);
                    break;
                case 4:
                    Console.WriteLine("Dòng {0} có nhiều số nguyên tố nhất", maxPrimeAmountCollum(r, c, matrix));
                    choose(r, c, matrix);
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ");
                    choose(r, c, matrix);
                    break;
            }
        }
    }
}
