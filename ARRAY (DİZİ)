using System;

//SORU: Kullanıcıdan 5 sayı alıp bir diziye atayan ve toplamını yazdıran C# programı yazınız.

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[5];
        int toplam = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write((i + 1) + ". sayıyı giriniz: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());

            toplam += sayilar[i];
        }

        Console.WriteLine("Toplam: " + toplam);
    }
}
