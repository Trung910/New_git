using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b, c, tong;
            float tich;
            Console.WriteLine("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());
            tong = a + b + c;
            tich = a * b * c;
            Console.WriteLine("Tong la: {0}\nTich la: {1}", tong, tich);
            Console.ReadKey();

        }
    }
}
