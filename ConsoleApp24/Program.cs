using ConsoleApp24;
using System;

public class Program
{

    public static void Main()
    {
        Bebek bebek1 = new Bebek();
        Console.WriteLine("Bebek 1:");
        Console.WriteLine($"Ad :{bebek1.Ad}");
        Console.WriteLine($"Soyad :{bebek1.SoyAd}");
        Console.WriteLine($"Dogum tarihi :{bebek1.DogumTarihi}");

        //paremetleri constructor ile bebek nesnesi oluşturmamız gerek şimdi de 

        Bebek bebek2 = new Bebek("Ali","Veli");
        Console.WriteLine("\nBebek 2: ");
        Console.WriteLine($"Ad:{bebek2.Ad}");
        Console.WriteLine($"Soyad:{bebek2.SoyAd}");
        Console.WriteLine($"dogum tarihi :{bebek2.DogumTarihi}");
    } 


}