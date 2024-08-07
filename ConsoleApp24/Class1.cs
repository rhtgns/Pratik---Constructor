using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    public class Bebek 
    {
        public DateTime DogumTarihi { get; set; }
        public string Ad { get; set; }

        public string SoyAd { get; set; }

        // bu kısımda deger verilmedği için kendi degerimizi  gecerli sayacagız ve default 
        // constructor kullanacagız 
        public Bebek()
        {
            DogumTarihi = DateTime.Now;
            Console.WriteLine("Ingaaa");
            //burda tam zamanlı gerı dönmeyen bir bebek nesnesi oluşturduk 
        }
         //şimdi ise bir paramtere alan constructor olulşturalım  bebek nesensi oluşturacagız 

        public  Bebek(string ad,string soyad)
        {
            DogumTarihi = DateTime.Now;
            Ad = ad;
            SoyAd = soyad;
            Console.WriteLine("Ingaaa");



        }

    }
}
