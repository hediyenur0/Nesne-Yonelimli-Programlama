using System;
using System.Collections.Generic;

//Kullanıcıdan girilen sayılar 0 girilene kadar List’e eklensin ve en büyük sayı yazdırılsın.

class Program
{
    static void Main(string[] args)
    {
        List<int> sayilar = new List<int>();
        int sayi;

        do
        {
            Console.Write("Sayı giriniz (çıkmak için 0): ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi != 0)
                sayilar.Add(sayi);

        } while (sayi != 0);

        int enBuyuk = sayilar[0];

        foreach (int s in sayilar)
        {
            if (s > enBuyuk)
                enBuyuk = s;
        }

        Console.WriteLine("En büyük sayı: " + enBuyuk);
    }
}
