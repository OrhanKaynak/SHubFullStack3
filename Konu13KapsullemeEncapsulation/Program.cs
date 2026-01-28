namespace Konu13KapsullemeEncapsulation
{
    internal class Bolum
    {
        private string BolumAdi; // dışarıdan erişime kapalı değişkenimiz.

        public string GetBolumAdi()
        { 
            return BolumAdi; //GetBolumAdi çağırılınca BolumAdi değişkenini yolla 
        }

        public void SetBolumAdi(string istenenEgitim)
        {
            if (istenenEgitim == "Yazılım Eğitimi") // Mutator (setter) seçilen eğitime izin verildi. 
            {
                BolumAdi = istenenEgitim;
            }
            else
            {
                Console.WriteLine("Kurumumuzda bu eğitim verilmemektedir");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu13 Kapsulleme Encapsulation");
            Console.WriteLine("Metot ile Kapsulleme");
            Bolum bolum = new Bolum(); //Bolum classından bolum adında bir nesne üret
            Console.WriteLine("Hangi alanda eğitim almak istersiniz?");
            var bolumAdi = Console.ReadLine(); // ekrandan girilecek değeri oku
            bolum.SetBolumAdi(bolumAdi); // girilen değeri bolum nesnesindeki set metoduna gonder
            Console.WriteLine("Bölüm: " + bolum.GetBolumAdi()); // bolum nesnesindeki metotla private değişkenin değerini oku

            Console.WriteLine();

            // property ile kapsülleme
            Console.WriteLine("property ile kapsülleme");
            Fakulte fakulteNesnesi = new Fakulte();
            fakulteNesnesi.Bolum = bolumAdi; // veri atama: set bloğunu çalıştırır.
            Console.WriteLine("Bölüm: " + fakulteNesnesi.Bolum); // veri okuma: get bloğunu çalıştırır
        }
    }
    public class Fakulte
    {
        private string bolum;
        public string Bolum
        { 
            get { return bolum;}
            set 
            {
                if(value == "Yazılım Eğitimi")  // eğer gönderilen değer Yazılı Eğitimi ise
                {
                    bolum = value; // property e değer atamasına izin ver
                }
                else 
                {
                    Console.WriteLine("Kurumumuzda bu eğitim verilmemektedir!");
                }
            }
        }
    }
}
