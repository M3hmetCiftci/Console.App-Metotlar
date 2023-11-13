using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar.App
{
    internal class Program
    {
        //geriye değer döndürmeyen metodlar---------------------------------------------------------

        //public static void yazdir()
        //{
        //    Console.Write("Bi bir metottur");
        //    Console.WriteLine();
        //    Console.Write("Metodun başka bir satırı");
        //    Console.WriteLine();
        //}
        //public static void toplamametodu()
        //{
        //    int sayi1 = 24, sayi2 = 30;
        //    int toplam=sayi1 + sayi2;
        //    Console.WriteLine(toplam);
        //}




        //public static void ardisik()
        //{
        //    for (int i = 0; i <= 10; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    yazdir();
        //    Console.Write("***********");
        //    Console.WriteLine();
        //    yazdir();
        //   Console.WriteLine("***********");
        //    toplamametodu();
        //    Console.WriteLine("***********");
        //    ardisik();
        //    Console.Read();
        //}





        //geriye değer döndürmeyen metodlar parametre örneği---------------------------------------------------------
        //static void Metin(string p)
        //{
        //    Console.WriteLine("************");
        //    Console.WriteLine();
        //    Console.WriteLine(p);
        //    Console.WriteLine("*********");
        //}
        //static void Main(string[] args)
        //{
        //    Metin("merhaba");
        //}





        //geriye değer döndürmeyen metodlar dışarıdan gelen değer parametre örneği ------------------------------------

        //public static void Metinyaz1(string p)
        //{
        //    Console.WriteLine("*******");
        //    Console.WriteLine(p);
        //    Console.WriteLine("*********");
        //}
        //public static void Metinyaz2(string parametre)
        //{
        //    Console.WriteLine("*******");
        //    Console.WriteLine(parametre);
        //    Console.WriteLine("*********");
        //}
        //static void Main(string[] args)
        //{
        //  Console.Write("Kelime giriniz: ");
        //    string kelime=Console.ReadLine();
        //    Metinyaz1("parametre dersleri");
        //    Console.WriteLine();
        //    Metinyaz2(kelime);







        //Geriye dDğer Dönüren Metotlar---------------------------------------------------------
        //public static int toplama()
        //{
        //    int sayi1, sayi2, toplam;
        //    sayi1 = 10;
        //    sayi2=20;
        //    toplam = sayi1 + sayi2;
        //    return toplam;
        //}
        //    static void Main(string[] args)
        //    {
        //   Console.Write (toplama());
        //    Console.Read();


        //public static int toplama(int s1,int s2)
        //{
        //    int sonuc;
        //    sonuc = s1+s2;
        //    return sonuc;
        //}

        //    static void Main(string[] args)
        //    {
        //    //Console.WriteLine(toplama(10, 15));
        //    int sayi1, sayi2;
        //    Console.Write("1.Sayıyı giriniz: ");
        //    sayi1=Convert.ToInt32(Console.ReadLine());
        //    Console.Write("2.sayıyı giriniz: ");
        //    sayi2 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("sonuc: "+toplama(sayi1,sayi2));
        //    Console.Read();





        //Metodlar Over Load---------------------------------------------------------
        //public static int ortalama(int s1,int s2)
        //{
        //    int sonuc = (s1 + s2) / 3;
        //    return sonuc;

        //}
        //static void Main(string[] args)
        //{
        //    Console.Write(ortalama(20,10));
        //    Console.Read();
        //}

    }
}
