using System;
using System.Collections.Generic;

//Bir List int koleksiyonu tanımlayınız ve içerisinde asal sayıların ilk 10 sayısını ekleyiniz

class Program
{
    static bool AsalMi(int sayi)
    {
        if (sayi < 2) return false;

        for (int i = 2; i * i <= sayi; i++)
        {
            if (sayi % i == 0)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        List<int> asallar = new List<int>();

        int sayi = 2;

        while (asallar.Count < 10)
        {
            if (AsalMi(sayi))
                asallar.Add(sayi);

            sayi++;
        }

        foreach (int a in asallar)
        {
            Console.WriteLine(a);
        }
    }
}
