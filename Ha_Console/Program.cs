using System;
using System.Collections.Generic;
using System.Text;
using DLL;
namespace Ha_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            Console.WriteLine("===== Máy tạo châm ngôn cá nhân =====");
            Console.Write("Nhập tên của bạn: ");
            string name = Console.ReadLine();

            string proverb = Cham_Ngon.GetProverb(name);

            Console.WriteLine("\n Châm ngôn cho bạn:");
            Console.WriteLine(proverb);

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
