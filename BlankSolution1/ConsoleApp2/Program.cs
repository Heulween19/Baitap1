using System;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập tên: ");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("tên tôi là: " + name);

            Console.ReadKey();
        }
    }
}
