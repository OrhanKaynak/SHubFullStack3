namespace Konu03Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu03 Operatorler");
            Console.WriteLine("1- Aritmetik Operatörler");

            double sayi1 = 3;
            double sayi2 = 4;
            double sayi3 = 5;

            Console.WriteLine();
            Console.WriteLine($"Sayılar sayı 1: {sayi1} sayı 2: {sayi2} sayı 3: {sayi3}"); //string tırnağının önüne $ işareti koyarak değişkenlerin değerlerini süslü parantez içinde yazdırabiliriz
            Console.WriteLine("1234" + sayi3); //string ile int toplanırsa stringe dönüştürülür ve yan yana yazılır
            Console.WriteLine();
            Console.WriteLine("Hesaplama İşlemleri:");
            Console.WriteLine("Sayi 1 + Sayi 2:" + (sayi1 + sayi2));
            Console.WriteLine("Sayi 1 - Sayi 2:" + (sayi1 - sayi2));
            Console.WriteLine("Sayi 1 * Sayi 2:" + (sayi1 * sayi2));
            Console.WriteLine("Sayi 1 / Sayi 2:" + (sayi1 / sayi2));
            Console.WriteLine("Sayi 1 % Sayi 2:" + (sayi1 % sayi2));

            Console.WriteLine();

            Console.WriteLine("Arttırım ve azaltım operatörleri");

            sayi2++; //değeri 1 arttırır
            Console.WriteLine("Sayı 2:" + sayi2);
            sayi2--;
            Console.WriteLine("Sayı 2:" + sayi2);

            Console.WriteLine();

            Console.WriteLine("Atama operatörleri");
            Console.WriteLine($"Sayılar sayı 1: {sayi1} sayı 2: {sayi2} sayı 3: {sayi3}");
            Console.WriteLine("Sayi 1 += Sayi 2:" + (sayi1 += sayi2));
            Console.WriteLine("Sayi 1 -= Sayi 2:" + (sayi1 -= sayi2));
            Console.WriteLine("Sayi 1 *= Sayi 2:" + (sayi1 *= sayi2));
            Console.WriteLine("Sayi 1 /= Sayi 2:" + (sayi1 /= sayi2));
            Console.WriteLine("Sayi 1 %= Sayi 2:" + (sayi1 %= sayi2));

            Console.WriteLine();

            Console.WriteLine("İlişkisel Operatörler"); //birden fazla değeri karşılaştırmak için kullanılır
            Console.WriteLine($"Sayılar sayı 1: {sayi1} sayı 2: {sayi2} sayı 3: {sayi3}");
            Console.WriteLine("Sayi 1 == Sayi 2:" + (sayi1 == sayi2));
            Console.WriteLine("Sayi 1 != Sayi 2:" + (sayi1 != sayi2));
            Console.WriteLine("Sayi 1 > Sayi 2:" + (sayi1 > sayi2));
            Console.WriteLine("Sayi 1 < Sayi 2:" + (sayi1 < sayi2));
            Console.WriteLine("Sayi 1 <= Sayi 2:" + (sayi1 <= sayi2));
            Console.WriteLine("Sayi 1 >= Sayi 2:" + (sayi1 >= sayi2));
            
            Console.WriteLine();

            Console.WriteLine("Turnery Operatörü"); //eğer karşılaştırma için 2 değer kullanacaksak karşılaştırmanın kısayolu olarak kullanılır
            Console.WriteLine("Turnery: ");
            Console.WriteLine((sayi1 == sayi2) ? "sayılar eşit" : "sayılar eşit değil" );

            Console.WriteLine();

            Console.WriteLine("Mantıksal Operatörler");
            Console.WriteLine("And & Operatörü");
            Console.WriteLine("& operatörü her iki şartın da sağlanmasını ister ister:");
            string email = "admin@site.co", sifre = "adm123";
            Console.WriteLine("Email adresinizi giriniz:");
            var girilenMail = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz:");
            var girilenSifre = Console.ReadLine();
            Console.WriteLine();
            //Console.WriteLine(email == girilenMail && girilenSifre == sifre ? "Giriş Başarılı" : "Giriş Başarısız");

            Console.WriteLine();

            Console.WriteLine("Veya | Operatörü");
            Console.WriteLine("| operatörü her iki şarttan birinin sağlanmasını ister ister:");
            Console.WriteLine(email == girilenMail || girilenSifre == sifre ? "Giriş Başarılı" : "Giriş Başarısız");
        }
    }
}
