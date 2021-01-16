using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            // array --> dizi

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi", "Programlamaya baslangic icin temel kurs",
            "Java", "Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR ENDED");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
