namespace Konu02TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 02 Tip Döünüşümleri");
            //Implicit Casting (Otomatik Dönüşüm)
            //Excplicit Casting (Manuel Dönüşüm)
            Console.WriteLine("Implicit Casting (Otomatik Dönüşüm)");
            Console.WriteLine("Implicit Castingde daha küçük boyutlu bir türü daha büyük bir boyut dürüne geçirirken dönüşüm otomatik olarak yapılır");
            int sayi = 18;
            double kesirliSayi = sayi; //int to double (otomatik dönüşüm)

            Console.WriteLine("Sayı değeri:");
            Console.WriteLine(sayi);
            Console.WriteLine("Kesirli Sayı değeri (int to double otomatik dönüşüm sonrası):");
            Console.WriteLine(kesirliSayi);

            Console.WriteLine();
            Console.WriteLine("Excplicit Casting (Manuel Dönüşüm)");

            double kesirlisayi = 18;
            int tamsayi = (int)kesirlisayi; //double to int (manuel dönüşüm)

            Console.WriteLine("Kesirli sayı:");
            Console.WriteLine(kesirlisayi);
            Console.WriteLine("Tamsayı:");
            Console.WriteLine(tamsayi);
            Console.WriteLine();

            Console.WriteLine("Diğer tüm dönüştürme yöntemleri");
            int tamSayi2 = 10;
            double kesirliSayi3 = 5.25;
            bool islemSonuc = true;

            Console.WriteLine("Lütfen bir değer giriniz:");
            var girilenDeger = Console.ReadLine();
            Console.WriteLine("Girilen değerin veri tipi:");
            Console.WriteLine(girilenDeger.GetType());

            var parsayi = int.Parse(girilenDeger); //string to int
            Console.WriteLine(parsayi + tamsayi);
            Console.WriteLine(double.Parse(girilenDeger) + kesirliSayi3);
            Console.WriteLine(decimal.Parse(girilenDeger) + tamSayi2);
            Console.WriteLine();

            Console.WriteLine("Convert sınıfı metotlarıyla tip dönüştürme");
            Console.WriteLine(tamSayi2.GetType());
            Console.WriteLine(Convert.ToString(tamSayi2).GetType());
            Console.WriteLine(Convert.ToDouble(tamSayi2).GetType()); //tam sayıyı stringe dönüştürme ve tipini gösterme
            Console.WriteLine(Convert.ToInt32(kesirliSayi3).GetType());
            Console.WriteLine(Convert.ToString(islemSonuc).GetType());

            Console.WriteLine();

            object nesne = "123456";
            Console.WriteLine("Nesnenin veri tipi:" + nesne.GetType());
            nesne = Convert.ToDecimal(nesne);
            Console.WriteLine("Nesnenin veri tipi:" + nesne.GetType());
            Console.WriteLine("Nesnenin değeri:" + nesne);
        }
    }
}
