using System;

class Program
{
    static void Main(string[] args)
    {
        Araba a = new Araba();
        a.Calistir();
        a.Durdur();
    }
}

class Motor
{
    public void Calistir()
    {
        Console.WriteLine("Motor çalıştı");
    }

    public void Durdur()
    {
        Console.WriteLine("Motor durdu");
    }
}

class Araba
{
    public Motor motor = new Motor(); // HAS-A

    public void Calistir()
    {
        motor.Calistir();
        Console.WriteLine("Araba çalıştı");
    }

    public void Durdur()
    {
        motor.Durdur();
        Console.WriteLine("Araba durdu");
    }
}
