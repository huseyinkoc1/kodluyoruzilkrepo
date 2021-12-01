using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte b = 5; //1 byte
            sbyte c = -5; //1 byte

            short s = 5; //2 byte
            ushort us = 5; //2  byte

            Int16 i16 = 2; //2 byte
            int i = 2;   //4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; //8 byte
            

            uint ui = 2; //4 byte
            long l = 4;  //8 byte
            ulong ul = 4; //8 byte

            //Reel Sayılar
            float f = 5;  //4 byte
            double d = 5; //8 byte
            decimal de = 5; //16 byte


            char ch = '2'; //2 byte
            string str = "Hüseyin"; //sınırsız

            bool b1 = true;

            DateTime dt = DateTime.Now;

            System.Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler

            string str1 = string.Empty;
            str1 = "Hüseyin Koç";
            string ad = "Hüseyin";
            string soyad= "Koç";
            string tamIsim = ad+" "+soyad;

            //Integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1*integer2;

            bool bl1 = 10>2;

            //Değişken Dönüşümleri

            string str20 ="20";
            int int20 = 20;
            string yeniDeger = str20+int20.ToString();
            Console.WriteLine(yeniDeger); // Çıktısı 40

            int int21 = int20 + Convert.ToInt32(str20);
            System.Console.WriteLine(int21); //Çıktısı 40

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            System.Console.WriteLine(datetime2);

            //saat
            string hour = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(hour);

            Console.Read();
        }
    }
}
