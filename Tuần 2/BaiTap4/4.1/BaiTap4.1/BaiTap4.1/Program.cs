using System.Text;

namespace BaiTap4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Phân số thứ nhất: ");
            fraction a = new fraction();
            a.fractionImport();

            Console.WriteLine("Phân số thứ hai: ");
            fraction b = new fraction();
            b.fractionImport();

            fraction func = a + b;
            Console.Write("Tổng của hai phân số:   ");
            func.fractionExport();

            func = a - b;
            Console.Write("Hiệu của hai phân số:   ");
            func.fractionExport();

            func = a * b;
            Console.Write("Tích của hai phân số:   ");
            func.fractionExport();

            func = a / b;
            Console.Write("Thương của hai phân số: ");
            func.fractionExport();

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
                if (numerator % denominator == 0)
                    Console.WriteLine(numerator / denominator);
                else Console.WriteLine("{0}/{1}", numerator, denominator);
            }
            void simplify()
            {
                for (int i = Math.Abs(numerator); i >= 1; i--)
                    if (numerator % i == 0 && denominator % i == 0)
                    {
                        numerator /= i;
                        denominator /= i;
                        if ((numerator < 0 && denominator < 0) || (numerator > 0 && denominator < 0))
                        {
                            numerator *= -1;
                            denominator *= -1;
                        }
                        break;
                    }
            }
            public static fraction operator +(fraction a, fraction b)
            {
                fraction result = new fraction();
                result.numerator = a.numerator * b.denominator + b.numerator * a.denominator;
                result.denominator = b.denominator * a.denominator;
                result.simplify();
                return result;
            }
            public static fraction operator -(fraction a, fraction b)
            {
                fraction result = new fraction();
                result.numerator = a.numerator * b.denominator - b.numerator * a.denominator;
                result.denominator = b.denominator * a.denominator;
                result.simplify();
                return result;
            }
            public static fraction operator *(fraction a, fraction b)
            {
                fraction result = new fraction();
                result.numerator = a.numerator * b.numerator;
                result.denominator = a.denominator * b.denominator;
                result.simplify();
                return result;
            }
            public static fraction operator /(fraction a, fraction b)
            {
                fraction result = new fraction();
                result.numerator = a.numerator * b.denominator;
                result.denominator = a.denominator * b.numerator;
                result.simplify();
                return result;
            }
        }
    }
}
