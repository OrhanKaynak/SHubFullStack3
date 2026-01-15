namespace Konu05Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu05 Metotlar");
            Console.WriteLine();
            ToplamaYap(10, 8);
            Console.WriteLine();
            Console.WriteLine("Geriye değer döndüren metot");
            int sonuc = ToplamaYap(6, 6, 6);
            Console.WriteLine("Sayıların toplamı: " + sonuc);
            Console.WriteLine();
            Console.WriteLine("Lütfen mail adresi giriniz: ");
            var email = Console.ReadLine();
            var mailGonderildiMİ = mailGonder(email);
            if (mailGonderildiMİ == true)
            {
                Console.WriteLine("Mail gönderme işlemi başarılı.");
            }
            else
            {
                Console.WriteLine("Mail gönderme işlemi başarısız.");
            }
        }
        static void ToplamaYap()
        {
            //void metotlar geriye değer döndürmezler
            Console.WriteLine(10 + 8);
        }

        static void ToplamaYap(int sayi1 , int sayi2) // Parametreli metot örneği
        {
            //void metotlar geriye değer döndürmezler
            Console.WriteLine(sayi1 + sayi2);
        }

        static int ToplamaYap(int sayi1, int sayi2, int sayi3) // Parametreli metot örneği
        {
            //void metotlar geriye değer döndürmezler
           return sayi1 + sayi2 + sayi3;
        }

        static bool mailGonder (string mail)
        { 
            if (!string.IsNullOrEmpty(mail)) 
            {
                return true;
            }
            return false;
                
        }
    }
}
