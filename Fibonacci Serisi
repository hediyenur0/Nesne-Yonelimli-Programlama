using System;

//“Fibonacci Serisi” elemanları (sayıları) aşağıdaki gibidir:
//1, 1, 2, 3, 5, 8, 13, 21, 34,….
//Buna göre klavyeden girilen terim sayısına (N) göre,Fibonacci Serisi’nin ilk N terimini bulup ekrana yazan kodu,
//C# dili ile kodlayınız.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Terim sayısını giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 1, b = 1, c;

        Console.Write(a + " " + b + " ");

        for (int i = 3; i <= n; i++)
        {
            c = a + b;
            Console.Write(c + " ");

            a = b;
            b = c;
        }
    }
}
