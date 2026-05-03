using System;

//Girilen sayıya kadar olan asal sayıları listeleyen program.

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
        Console.Write("Bir sayı giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            if (AsalMi(i))
                Console.WriteLine(i);
        }
    }
}
