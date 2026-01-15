internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine();

        Console.WriteLine("Merhaba Dunya!");

        Console.Write("Console");

        Console.Write("Write");

        //Console.Read(); //ekran kapanmasin diye

        //Console.ReadLine(); //ekran kapanmasin diye

        //degisken tanimlama
        //tam sayi verileri tipleri
        byte plaka_kodu;      //1 byte 0-255 arasi deger alir
        plaka_kodu = 34;    //deger atama
        Console.WriteLine(plaka_kodu); //ekrana yazdirma

        // Değişkenler tiplerine göre bellekte stack ve heap denilen 2 ayrı bölümde saklanır. Değer tipli değişkenler stack alanında saklanırken referans tipli değişkenler heap bölümünde saklanır.

        byte birSayi, birSayiDaha; //aynı satırda birden fazla degisken tanimlama

        birSayi = 0;
        birSayiDaha = 255;
        Console.WriteLine(birSayi);
        Console.WriteLine(birSayiDaha);

        sbyte eksiBirSayi = -100; //-128 ile 127 arasi deger alir
        short kisaSayi = -32000; //-32,768 ile 32,767 arasi deger alir
        ushort pozitifKisaSayi = 65000; //0 ile 65,535 arasi deger alir
        int tamSayi = -2000000000; //-2,147,483,648 ile 2,147,483,647 arasi deger alir
        uint pozitifTamSayi = 4000000000; //0 ile 4,294,967,295 arasi deger alir
        long uzunSayi = -9000000000000000000; //-9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasi deger alir
        ulong pozitifUzunSayi = 18000000000000000000; //0 ile 18,446,744,073,709,551,615 arasi deger alir

        //ondalikli sayi veri tipleri
        float ondalikliSayi = 3.14f; //4 byte, 7 basamak hassasiyet
        double dahaHassasOndalikliSayi = 3.14159265358979; //8 byte, 15-16 basamak hassasiyet
        decimal paraBirimi = 100.50m; //16 byte, 28-29 basamak hassasiyet

        //char veri tipi
        char karakter = 'A'; //2 byte, tek karakter saklar

        //string veri tipi
        string metin = "Merhaba Dunya"; //sinirsiz karakter saklayabilir
        string degisken1, degisken2;
        string degisken3 = "Deger atayarak tanimlama", degisken4 = "Ayni satirda birden fazla degisken";
        Console.WriteLine(metin);

        //bool veri tipi
        bool islemSonuc = false; //true veya false deger alir

        //işlem başarılı ise
        islemSonuc = true;

        byte? nullableSayi = null; //nullable tip, null deger alabilir eğer null deger atamak istenirse ? kullanılır

        nullableSayi = 45;

        //bir ürünün stokta olup olmadığını kontrol etmek için kullanılacak değişken

        bool? urunStoktaMi = null; //ürün stokta mı bilinmiyor
        urunStoktaMi = true; //ürün stokta

        //var ile degisken tanimlama
        var birDegisken = 100; //derleyici degiskenin tipini atanan degerden anlar

        var birsayi = 100; //int
        var strMetin = "var bir değişken atarsak değişkene değer atamak zorundayız"; //string
        var sonuc = false; //bool

        Console.WriteLine(birDegisken);
        Console.WriteLine(birDegisken.GetType());
        Console.WriteLine(birsayi);
        Console.WriteLine(birsayi.GetType());
        Console.WriteLine(strMetin);
        Console.WriteLine(strMetin.GetType());
        Console.WriteLine(sonuc);
        Console.WriteLine(sonuc.GetType());

        sonuc = true; //var ile tanimlanan degiskenin tipi degismez, sadece degeri degisir

        Console.WriteLine();
        Console.WriteLine("object veri tipi");

        object nesne = "Bu bir nesnedir"; //bu değişken türüne her tür değişken atanabilir.

        nesne = 18; // object ile tanımlanan nesne değiştirilebilir

        Console.WriteLine(nesne);
        Console.WriteLine(nesne.GetType());

        object a = 10; //tam sayi
        object b = 'k'; //karakter
        object c = "metin"; //string
        object d = 12.8f ; //float

        Console.WriteLine();

        //c#da sabit tanimlama
        Console.WriteLine("C# da sabit tanımlama");

        const int kdvOrani = 18; //sabitleri const ile tanimlariz ve program içerisinde kullanabiliriz sabitlerin değeri tanımlandığı yerde verilir sonradan değiştirilemez

        //kdvOrani = 20; //hata verir, sabitlerin değeri değiştirilemez

        const int iskonto = 25;
        Console.WriteLine("KDV Oranı:");
        Console.WriteLine(kdvOrani);

        //ekrandan deger alma
        Console.WriteLine("Ekrandan değer alma:");
        var deger = Console.ReadLine();
        Console.WriteLine("Girdiğini değer:");
        Console.WriteLine(deger);
    }
}