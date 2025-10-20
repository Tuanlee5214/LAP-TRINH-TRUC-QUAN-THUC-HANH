using System.Text;

namespace BaiTap4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Số phần tử của dãy phân số: ");
            int n = int.Parse(Console.ReadLine());

            fraction[] fractionArray = new fraction[n];
            arrImport(fractionArray, n);

            Console.Write("- Dãy phân số vừa nhập là: ");
            arrExport(fractionArray, n);
            Console.WriteLine();

            Console.Write("- Phân số lớn nhất trong dãy là ");
            getMax(fractionArray, n).fractionExport();
            Console.WriteLine();

            Console.Write("- Dãy phân số sau khi sắp xếp từ nhỏ đến lớn là: ");
            reArrange(fractionArray, n);
            arrExport(fractionArray, n);
            Console.ReadKey();
        }
        class fraction
        {
            int numerator;
            int denominator;
            public void fractionImport()
            {
                Console.Write("-  Tử số: ");
                numerator = int.Parse(Console.ReadLine());
                Console.Write("-  Mẫu số: ");
                denominator = int.Parse(Console.ReadLine());
                while (denominator == 0)
                {
                    Console.WriteLine("Mẫu số phải khác 0, vui lòng nhập lại mẫu số!");
                    Console.Write("-  Mẫu số: ");
                    denominator = int.Parse(Console.ReadLine());
                }
                Console.Clear();
            }
            public void fractionExport()
            {
                Console.Write("{0}/{1} ", numerator, denominator);
            }
            public static bool operator >(fraction a, fraction b)
            {
                fraction result = new fraction();
                result.numerator = a.numerator * b.denominator - b.numerator * a.denominator;
                result.denominator = b.denominator * a.denominator;
                double temp = (double)result.numerator / result.denominator;
                return (temp > 0);
            }
            public static bool operator <(fraction a, fraction b)
            {
                fraction result = new fraction();
                result.numerator = a.numerator * b.denominator - b.numerator * a.denominator;
                result.denominator = b.denominator * a.denominator;
                return (result.numerator / result.denominator < 0);
                return true;
            }
        }
        static void arrImport(fraction[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Phân số thứ {0}: ", i + 1);
                arr[i] = new fraction();
                arr[i].fractionImport();
            }
        }
        static void arrExport(fraction[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i].fractionExport();
            }
        }
        static fraction getMax(fraction[] arr, int n)
        {
            fraction max = arr[0];
            for (int i = 0; i < n; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }
        static void reArrange(fraction[] arr, int n)
        {
            void swap(ref fraction a, ref fraction b)
            {
                fraction temp = a;
                a = b;
                b = temp;
            }

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] > arr[j])
                        swap(ref arr[i], ref arr[j]);
        }
    }
}
