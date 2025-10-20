using System.Text;

namespace BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("  Đường dẫn đến thư mục là: ");
            string directoryPath = Console.ReadLine();
            DirectoryInfo directory = new DirectoryInfo(directoryPath);

            Console.WriteLine();

            Console.WriteLine("Các tệp tin trong thư mục '{0}' là:", directoryPath);
            foreach (FileInfo file in directory.GetFiles())
                Console.WriteLine("-  " + file.Name);

            Console.WriteLine("\n");

            Console.WriteLine("Các thư mục con trong thư mục '{0}' là:", directoryPath);
            foreach (DirectoryInfo subDirectory in directory.GetDirectories())
                Console.WriteLine("-  " + subDirectory.Name);
            Console.ReadKey();
        }
    }
}
