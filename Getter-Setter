using System.Collections.Generic;

/*Sistem içerisinde toplam
3 oyuncu yer almaktadır:
2 adet bilgisayar programcılığı öğrencisi (kullanıcı kontrollü oyuncular)
1 adet bilgisayar kontrollü oyuncu (yapay oyuncu)
Bu oyuncular, klasik iskambil kartları ile oynanan Blöf oyununu birlikte oynamaktadır.
Oyunun Temel Kuralları
Oyun, standart bir 52 kartlık deste ile oynanır.
Oyun başlangıcında kartlar rastgele karıştırılır.
Her oyuncuya eşit sayıda olacak şekilde 13 kart dağıtılır .
Oyuncular sırasıyla hamle yaparak oyunu sürdürür./*

/*Oyuncu Türleri ve Davranışları
1. Kullanıcı Kontrollü Oyuncular (Öğrenciler)
Hamleler doğrudan kullanıcıdan alınır.
Kullanıcıdan;
Hangi kartı oynayacağı,
Blöf yapıp yapmayacağı,
Rakibin hamlesine karşı “blöf” deyip demeyeceği gibi bilgiler istenir.
2. Bilgisayar Kontrollü Oyuncu
Kararlarını otomatik olarak verir.
Daha önce oynanan hamleleri analiz ederek stratejik davranır.
Blöf yapma veya karşı tarafın blöfünü yakalama kararlarını,
Oyun geçmişine,
Olasılık hesaplarına dayanarak verir./*

/*Teknik Gereksinimler
Proje C# dili ile geliştirilmelidir.
Uygulama, Nesne Yönelimli Programlama prensiplerine uygun olarak tasarlanmalıdır./*

class Program
{
    static void Main(string[] args)
    {
        Oyun oyun = new Oyun();

        KullaniciOyuncu k1 = new KullaniciOyuncu();
        k1.Ad = "Ali";

        KullaniciOyuncu k2 = new KullaniciOyuncu();
        k2.Ad = "Ayşe";

        BilgisayarOyuncu b1 = new BilgisayarOyuncu();
        b1.Ad = "Bot";

        oyun.Oyuncular.Add(k1);
        oyun.Oyuncular.Add(k2);
        oyun.Oyuncular.Add(b1);

        oyun.Baslat();
    }
}
class Deste
{
    public List<Kart> Kartlar = new List<Kart>();

    public void Karistir()
    {
        // basit karıştırma (detay şart değil sınavda)
    }

    public void Dagit(List<Oyuncu> oyuncular)
    {
        // oyunculara kart dağıt
    }
}

class Kart
{
    public string Tur { get; set; }   // kupa, karo vs
    public string Deger { get; set; } // A, K, 10 vs
}

class Oyuncu
{
    public string Ad { get; set; }

    public List<Kart> El = new List<Kart>();

    public virtual void HamleYap()
    {
        Console.WriteLine("Hamle yapılıyor...");
    }
}

class KullaniciOyuncu : Oyuncu
{
    public override void HamleYap()
    {
        Console.WriteLine("Kullanıcı hamle yaptı");
    }
}

class BilgisayarOyuncu : Oyuncu
{
    public override void HamleYap()
    {
        Console.WriteLine("Bilgisayar hamle yaptı");
    }
}

class Oyun
{
    public List<Oyuncu> Oyuncular = new List<Oyuncu>();
    public Deste deste = new Deste();

    public void Baslat()
    {
        Console.WriteLine("Oyun başladı");

        foreach (var oyuncu in Oyuncular)
        {
            oyuncu.HamleYap();
        }
    }
}

