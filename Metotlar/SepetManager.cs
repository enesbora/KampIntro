using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //namingconvention
        // syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebriler Sepete eklendi! : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebriler Sepete eklendi! : " + urunAdi);
        }
    }
}
