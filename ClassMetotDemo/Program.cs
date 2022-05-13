using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musterı musterı1 = new Musterı();
            musterı1.Adi = "Ahmet";
            musterı1.Soyadi = "İzmir";
            musterı1.Yasi = 24;
            musterı1.DogumYeri = "Sivas";

            Musterı musterı2 = new Musterı();
            musterı2.Adi = "Ali";
            musterı2.Soyadi = "İhsan";
            musterı2.Yasi = 24;
            musterı2.DogumYeri = "Zondulgag";

            Musterı musterı3 = new Musterı();
            musterı3.Adi = "Hakan";
            musterı3.Soyadi = "Emiran";
            musterı3.Yasi = 24;
            musterı3.DogumYeri = "Rize";

            Musterı[] musteriler = new Musterı[] { musterı1, musterı2, musterı3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine(musteri.DogumYeri);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musterı1);
            musteriManager.MusteriListele(musterı2);
            musteriManager.MusteriSilme(musterı3);

        }
    }
}
