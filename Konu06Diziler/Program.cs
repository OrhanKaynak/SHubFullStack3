namespace Konu06Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu06 Diziler");

            //Dizi tanımlama

            int[] sayi;
            int[] ogrenciler = new int[6]; // 6 elemanlı bir dizi tanımlandı. dizinin eleman sayısı sabittir.
            //Dizilerde indeksleme 0'dan başlar.

            ogrenciler[0] = 100;
            ogrenciler[1] = 200;
            ogrenciler[2] = 300;
            ogrenciler[3] = 400;
            ogrenciler[4] = 500;
            ogrenciler[5] = 500; //dizi değerleri aynı olabilir.

            Console.WriteLine("ogrenciler[5]: " + ogrenciler[5]);
            ogrenciler[5] = 550;
            Console.WriteLine("ogrenciler[5]: " + ogrenciler[5]);
            //ogrenciler[6] = 600; //Hata: Dizi boyutunu aştık.
            string[] isimler = new string[6];
            isimler[0] = "Alp";
            isimler[1] = "Ali";
            isimler[2] = "Murat";
            isimler[3] = "Yılmaz";
            Console.WriteLine("isimler[2]: " + isimler[2]);
            Console.WriteLine();
            int[] ogrenciler2 = {100, 200, 300, 400, 500, 600 }; //Dizi tanımlama ve değer atama aynı satırda yapılabilir.
            Console.WriteLine("Ogrenciler2[3]" + ogrenciler2[3]);
            ogrenciler2[3] = 550;
            Console.WriteLine("ogrenciler2[3]" + ogrenciler2[3]);

            Console.WriteLine();

            string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon", "Beyaz Eşya", "Kitap" };
            Console.WriteLine("Kategoriler 1: " + kategoriler[1]);
            kategoriler[1] = "Mutfak Eşyaları";
            Console.WriteLine("Kategoriler 1: " + kategoriler[1]);
            Console.WriteLine();

            string[] urunler = { "Ürun 1", "Ürün 2", "Ürün 3"} ;
            Console.WriteLine("Ürün 1: " + urunler[0]);
        }
    }
}
