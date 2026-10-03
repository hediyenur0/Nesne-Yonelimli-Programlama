using System;

//Pisagor teoremini yazan program.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("A kenarını giriniz: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("B kenarını giriniz: ");
        int b = Convert.ToInt32(Console.ReadLine());

        double c;

        c = Math.Sqrt(a * a + b * b);

        Console.WriteLine("Hipotenüs: " + c);
    }
}
