using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenligi
            // Do not repeat yourself
            // deger tutucu alias

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000; // tam sayilari tutar
            double faizOrani = 1.45;   // ondalikli sayilari tutar
            bool isOnline = true;     // dogru ya da yanlis saklinde verileri tutar
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }



            if (isOnline == true)
            {
                Console.WriteLine("Kullanici Ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
