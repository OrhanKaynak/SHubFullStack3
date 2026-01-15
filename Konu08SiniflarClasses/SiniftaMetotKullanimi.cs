using System;
using System.Collections.Generic;
using System.Text;

namespace Konu08SiniflarClasses
{
    internal class SiniftaMetotKullanimi
    {
        string kurucuMetot;
        public SiniftaMetotKullanimi() //ctor yazıp taba basarak kurucu metot-construtor oluşturuyoruz.
        {
            Console.WriteLine();
            kurucuMetot = "Sınıflarda constructor (kurucu metot) özelliği vardır ve bu metotlar sınıftan bir nesne oluşturulduğunda otomatik olarak çalışır ve içerisindeki kodları çalıştırır.";
            Console.WriteLine(kurucuMetot);
            Console.WriteLine();
        }
        public bool LoginKontrol(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "admin" && sifre == "adm123")
            { 
                return true;
            }
            return false;
        }

        public int ToplamaYap(int sayi1, int sayi2)
        { 
            return sayi1 + sayi2; 
        }
    }
}
