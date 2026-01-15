namespace Konu04KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KOnu04 Karar Yapilari");
            /*
            Console.WriteLine("Bir sayı giriniz:");
            var sayi = Convert.ToDecimal(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Sayı pozitif");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Sayı negatif");
            }
            else 
            {
                Console.WriteLine("Sayı sıfır");
            }
            

            Console.WriteLine("Kullanıcı adınız:");
            var kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifreniz:");
            var sifre = Console.ReadLine();

            if (kullaniciAdi == "admin" && sifre == "a123")
            {
                Console.WriteLine("Giriş Başarılı");
                Console.WriteLine("Hoşgeldin admin");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
            }
            */

            int saat = DateTime.Now.Hour;

            if (saat < 18)
            {
                Console.WriteLine("İyi günler, saat:" + saat);
            }
            else
                Console.WriteLine("İyi akşamlar, saat:" + saat);

            Console.WriteLine("Switch Case yapısı ile akış kontrolü");
            int ay = DateTime.Now.Month;
            Console.WriteLine("Bulunduğumuz ay:" + ay);

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar");
                    break;
                default:
                    Console.WriteLine("Bir sorun oluştu");
                    break;
            }
        }
    }
}