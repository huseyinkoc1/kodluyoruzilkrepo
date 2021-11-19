using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adınızı Giriniz.");
            String ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz");
            String soyad = Console.ReadLine();
            Console.WriteLine("Merhaba "+ad+" "+soyad);
            Console.Read();
        }
    }
}
