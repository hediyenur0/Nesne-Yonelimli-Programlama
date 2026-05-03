using System.Collections.Generic;

/*Kişi ve Araç Bilgileri Yönetim Sistemi
•Bir kişinin birden fazla aracı olabileceği bir sistem tasarlanması isteniyor. Aşağıda sistemin gereksinimleri ve işleyişi açıklanmıştır:
•Araç Bilgileri
•Araç türleri (taksi, kamyon, otobüs vb.) mevcut olacak.
•Her araç için aşağıdaki bilgiler tutulmalıdır:
•Model
•Yıl
•Marka
•Edinme Tarihi
•Edinme Fiyatı/*

/*Kişi Bilgileri
•Kişi ile ilgili olarak aşağıdaki bilgiler gizli tutulmalıdır:
•Adı
•Soyadı
•Doğum Yılı
•TC Kimlik Numarası
•Araç Sahipliği
•Dört adet farklı araç sahibi olunmalıdır.
•İlk aracın 4. sahibi,
•İkinci aracın 5. sahibi,
•Üçüncü aracın 6. sahibi,
•Dördüncü aracın 3. sahibi (yani sizden önceki 2 sahibi) olmalıdır./*

/*Araç Listesi
•"Kişi arabalarımı listele" komutu verildiğinde araçların bilgileri şu formatta gösterilmelidir:
•Şasi Numarası: *A**9
•Sahibi: Murat Taşyürek
•Edinme Tarihi: 01.01.2020
•Model Yılı: [Bir önceki sahibinin adı]
•Genel Gereksinimler
•Tüm veriler dinamik olarak girilmeli.
•Projeler özgün olmalı.
•Tüm işlemler sınıf (class) içerisinde gerçekleştirilmelidir. /*

class Arac
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Yil { get; set; }
    public string SasiNo { get; set; }
    public int KacinciSahibi { get; set; }
}

static void Main(string[] args)
{
    Kisi k = new Kisi();
    k.Ad = "Ali";
    k.Soyad = "Yılmaz";

    Arac a1 = new Arac();
    a1.Marka = "Toyota";
    a1.Model = "Corolla";
    a1.KacinciSahibi = 4;

    k.Araclar.Add(a1);

    k.ArabalarimiListele();
}

class Kisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public List<Arac> Araclar = new List<Arac>();

    public void ArabalarimiListele()
    {
        foreach (Arac a in Araclar)
        {
            Console.WriteLine("Marka: " + a.Marka);
            Console.WriteLine("Model: " + a.Model);
            Console.WriteLine("Sahibi: " + Ad + " " + Soyad);
            Console.WriteLine("Kaçıncı sahibi: " + a.KacinciSahibi);
            Console.WriteLine("----------------");
        }
    }
}
