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
            Bolum bolum = new Bolum();
            Console.WriteLine("Hangi alanda eğitim almak istersiniz?");
            var bolumAdi = Console.ReadLine();
            bolum.SetBolumAdi(bolumAdi);
            Console.WriteLine("Bölüm: " + bolum.GetBolumAdi());
        }
    }
}
