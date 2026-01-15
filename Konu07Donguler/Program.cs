namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu07Donguler");

            Console.WriteLine("1 - For Döngüsü");
            for (int i = 0; i <= 5; i++) // i adında bir sayaç değişkeni tanımlanır ve 0'dan başlayarak 5'e kadar (5 dahil) artar.
            {
                Console.WriteLine("i değişkeninin değeri {0}: ", i); // Her döngüde i değişkeninin değeri ekrana yazdırılır.
            }
            Console.WriteLine();

            Console.WriteLine("2 - While Döngüsü");
            int j = 0; // j adında bir sayaç değişkeni tanımlanır ve 0 olarak başlatılır.
            while (j < 5)
            {
                Console.WriteLine("j değişkeninin değeri: {0}", j);
                j++;
            }

            Console.WriteLine();

            Console.WriteLine("3 - Do While Döngüsü");

            int toplam = 5; // toplam adında bir değişken tanımlanır.
            do
            {
                Console.WriteLine("Toplam değişkeninin değeri: {0}", toplam);
                toplam++;
            }
            while (toplam < 5); // Koşul sağlanmasa bile do bloğu en az bir kez çalışır.

            Console.WriteLine();

            Console.WriteLine("4 - Foreach Döngüsü");
            string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon", "Beyaz Eşya", "Kitap" };
            Console.WriteLine("katogeriler: ");
            foreach (string kategori in kategoriler) // kategoriler dizisindeki her bir eleman için döngü çalışır.
            {
                Console.WriteLine(kategori); // Her döngüde kategori değişkeni dizinin bir elemanını temsil eder ve ekrana yazdırılır.
            }
            Console.WriteLine();

            Console.WriteLine("İç içe döngü kullanımı");
            string[] urunler = { "Ürun 1", "Ürün 2", "Ürün 3" }; // Ürünler dizisi tanımlanır.

            foreach (string urun in kategoriler)  // kategoriler dizisindeki her bir eleman için dış döngü çalışır.
            {
                Console.WriteLine(urun);
                foreach (string kategori in urunler) // urunler dizisindeki her bir eleman için iç döngü çalışır.
                {
                    Console.WriteLine("\t" + kategori);
                }
            }
            Console.WriteLine();

            Console.WriteLine("İç içe For Döngüsü");
            for (int a = 0; a < 5; a++) // Dış döngü 1'den 3'e kadar çalışır.
            {
                Console.WriteLine("Dış Döngü A Değeri: {0}", a);
                for (int b = 0; b < 3; b++) // İç döngü 1'den 2'ye kadar çalışır.
                {
                    Console.WriteLine("\tİç Döngü B Değeri: {0}", b);
                }
            }
        }
    }
}
