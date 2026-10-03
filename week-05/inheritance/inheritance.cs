//Çokgenlerin alanlarını ve çevrelerini bulmayı içeren kodlamayı yapınız.

class Program
{
    static void Main(string[] args)
    {
        Kare k = new Kare();
        k.Kenar = 5;

        Console.WriteLine("Alan: " + k.AlanHesapla());
        Console.WriteLine("Çevre: " + k.CevreHesapla());
    }
}

class NormalCokgen
{
    public int Kenar;

    public virtual double AlanHesapla()
    {
        return 0;
    }

    public virtual double CevreHesapla()
    {
        return 0;
    }
}

class Kare : NormalCokgen
{
    public override double AlanHesapla()
    {
        return Kenar * Kenar;
    }

    public override double CevreHesapla()
    {
        return 4 * Kenar;
    }
}

class Dikdortgen : NormalCokgen
{
    public int KisaKenar;

    public override double AlanHesapla()
    {
        return Kenar * KisaKenar;
    }

    public override double CevreHesapla()
    {
        return 2 * (Kenar + KisaKenar);
    }
}














