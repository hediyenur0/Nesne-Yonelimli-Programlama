using System;

//Aşağıdaki koşulları sağlayan bir C# konsol programı yazınız.
//1. 1’den 10 ’a kadar sayıları ekrana yazdıran bir for döngüsü kurunuz.
//Eğer sayı 5 olduğunda ekrana 5 'e gelindi, döngüden çıkılıyor yazsın ve break komutu ile döngü
//tamamen sonlansın.
//2. 1’den 10 ’a kadar olan sayılardan sadece tek sayıları ekrana yazdırınız.
//Bunun için continue komutunu kullanınız (çift sayılar atlanmalıdır.)
//3.Bir sayaç değişkeni tanımlayınız.
//Sayaç 0 ’dan başlayıp her adımda 1 artsın.
//goto komutunu kullanarak sayaç 3 ’e ulaşana kadar ekrana yazdırmaya devam edin.
//Sayaç 3 ’e ulaştığında program goto örneği bitti mesajını versin.

class Program
{
    static void Main(string[] args)
    {
      for (int i = 1; i <= 10; i++) //For+Break
       {
        if (i == 5)
       {
        Console.WriteLine("5'e gelindi, döngü bitiyor");
        break;
        }

       Console.WriteLine(i);
       }

     for (int i = 1; i <= 10; i++) //Continue
      {
      if (i % 2 == 0)
        continue;

      Console.WriteLine(i);
      }

     int sayac = 0; //GOTO

     basla:

    Console.WriteLine(sayac);
    sayac++;

    if (sayac < 3)
        goto basla;
    
    Console.WriteLine("Goto örneği bitti");
   }
}
