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

            int age;
            Console.WriteLine("Nhập tuổi: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Tuổi của tôi là: " + age);

            Console.ReadKey();
        }
    }
}
