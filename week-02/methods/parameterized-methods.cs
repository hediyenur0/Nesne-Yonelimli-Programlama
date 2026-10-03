using System;

//SORU: Girilen sayının karesini yazdıran bir metot yazınız.

/*class Program
{
    static void Kare(int sayi)
    {
        Console.WriteLine("Karesi: " + sayi * sayi);
    }

    static void Main(string[] args)
    {
        Kare(5);
    }
}/*

//SORU: Bir sayıyı ref ile 2 katına çıkaran metot yazınız.

/*class Program
{
    static void IkiKat(ref int sayi)
    {
        sayi = sayi * 2;
    }

    static void Main(string[] args)
    {
        int x = 5;

        IkiKat(ref x);

        Console.WriteLine(x);
    }
} /*

//SORU: Bir dikdörtgenin alan ve çevresini out ile döndüren metot yazınız.

class Program
{
    static void Hesapla(int a, int b, out int alan, out int cevre)
    {
        alan = a * b;
        cevre = 2 * (a + b);
    }

    static void Main(string[] args)
    {
        int alan, cevre;

        Hesapla(5, 10, out alan, out cevre);

        Console.WriteLine("Alan: " + alan);
        Console.WriteLine("Çevre: " + cevre);
    }
}




