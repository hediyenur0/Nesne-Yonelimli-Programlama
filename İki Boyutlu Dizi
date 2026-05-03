using System;

//2x2’lik bir dizi oluşturunuz ve bütün elemanlarını kullanıcıdan alarak, toplamını yazdıran
C# programı yazınız.

class Program
{
    static void Main(string[] args)
    {
        int[,] matris = new int[2, 2];
        int toplam = 0;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Eleman giriniz: ");
                matris[i, j] = Convert.ToInt32(Console.ReadLine());

                toplam += matris[i, j];
            }
        }

        Console.WriteLine("Toplam: " + toplam);
    }
}
