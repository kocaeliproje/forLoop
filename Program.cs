﻿
namespace donguler
{
class Program
 {
static void Main(string[]args)
  {
     Console.Write("Lütfen Bir Sayı Giriniz");
    int sayac=int.Parse(Console.ReadLine());
     for (int i=1; i<=sayac; i++)
     {
    if(i%2==1)
    Console.WriteLine(i);
     }
// 1 ile 1000 arasındaki tek ve çift sayıların kendi içinde toplamlarını ekrana yazdır.
    int tekToplam = 0;
    int ciftToplam= 0;
    for(int i=1; i<=1000; i++)
    {
        if(i%2==1)
        tekToplam +=i;
        else
        ciftToplam +=i;
    }
    Console.WriteLine("Tek Toplam"+ tekToplam);
    Console.WriteLine("Çift Tplam"+ciftToplam);

//break contuniue

    for (int i=1; 1<10; i++)
    {
     if(i ==4)
     break;
        Console.WriteLine(i);
    }
    for (int i=1; 1<10; i++)
    {
     if(i==4)
         continue;
        Console.WriteLine(i);
    }
  }

 }
}