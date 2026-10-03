using System;

//Kullanıcının seçimine göre sayının 10 dan büyük olup olmadığını kontrol eden kodu yazınız.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi > 10)
        {
            Console.WriteLine("10'dan büyük");
        }
        else
        {
            Console.WriteLine("10'dan büyük değil");
        }
    }
}
