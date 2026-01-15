using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Konu08SiniflarClasses
{

    internal class Ev
    {
        internal string sokakAdi;
        internal int kapiNo;
    }

    /*
        Erişim belirteçleri 4 ana sınıfa ayrılır:
        1. public: Her yerden erişilebilir.
        2. private: Sadece tanımlandığı sınıf içinden erişilebilir.
        3. protected: Sadece tanımlandığı sınıf ve türetilmiş sınıflar içinden erişilebilir.
        4. internal: Sadece aynı proje içinden erişilebilir.
    */

    public class deneme
    {
        public string urunAdi = "Public üyeye herkes erişebilir.";

        protected class test
        {
            string urunAdi;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu08 Sınıflar Classes");
            #region Ornek1
            Ev ilkEv = new Ev(); // soyut olan Ev sınıfından ilkEv adında bir nesne türettik.
            ilkEv.sokakAdi = "İstiklal Caddesi";
            ilkEv.kapiNo = 10;
            Console.WriteLine("İlk Ev Sokak Adı: " + ilkEv.sokakAdi);
            Console.WriteLine("İlk Ev Kapı No: " + ilkEv.kapiNo);
            Console.WriteLine();

            Ev yazlikEv = new();
            yazlikEv.sokakAdi = "Deniz Sk.";
            yazlikEv.kapiNo = 18;

            Console.WriteLine("Yazlık Ev Sokak Adı: " + yazlikEv.sokakAdi);
            Console.WriteLine("Yazlık Ev Kapı No: " + yazlikEv.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new()
            {
                sokakAdi = "Köy Yolu Cd.",
                kapiNo = 5
            };
            Console.WriteLine("Köy Evi Sokak Adı: " + koyEvi.sokakAdi);
            Console.WriteLine("Köy Evi Kapı No: " + koyEvi.kapiNo);
            #endregion

            #region Ornek2
            Kullanici kullanici = new()
            {
                name = "Ahmet",
                surname = "Yılmaz",
                userName = "ayilmaz",
                Password = "12345",
                Id = 1,

            };
            Console.WriteLine("Kullanıcı Adınız: ");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz: ");
            var sifre = Console.ReadLine();

            if (kullanici.userName == kullaniciAdi && kullanici.Password == sifre)
            {
                Console.WriteLine($"Giriş Başarılı! Hoşgeldiniz {kullanici.name} {kullanici.surname} ");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı!");
            }
            #endregion

            #region Örnek 3
            Araba araba = new()
            {
                Id = 1,
                Marka = "Togg",
                KasaTipi = "Suv",
                Model = "T10x",
                Renk = "Kırmızı",
                ModelYili = 2025
            };

            Araba araba2 = new()
            {
                Id = 2,
                Marka = "Togg",
                KasaTipi = "Sedan",
                Model = "T10F",
                Renk = "Beyaz",
                ModelYili = 2023
            };
            #endregion

            #region Örnek 4
            Kategori kategori = new()
            { 
                Id = 3,
                KategoriAdi = "Elektronik"
            };
            Kategori kategori2 = new()
            { 
                Id = 4,
                KategoriAdi = "Bilgisayar"
            };
            Kategori kategori3 = new()
            { 
                Id = 5,
                KategoriAdi = "Telefon"
            };
            Console.WriteLine();
            Console.WriteLine($"Anasayfa Hakkımızda {kategori.KategoriAdi} {kategori2.KategoriAdi} {kategori3.KategoriAdi} İletişim");
            #endregion
        }
    }

    class Kullanici
    {
        internal int Id;
        internal string userName;
        internal string Password;
        internal string Email;
        internal string name;
        internal string surname;
    }

    class Araba
    {
        internal int Id;
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakıtTipi;
        internal string VitesTipi;
        internal string Renk;
        internal int ModelYili;
    }
}
