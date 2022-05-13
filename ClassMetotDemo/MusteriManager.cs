using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musterı musterı)
        {
            Console.WriteLine("Müşteri Eklendi "+ musterı.Adi);
        }
        public void MusteriListele(Musterı musterı)
        {
            Console.WriteLine("Müşteriler listelendi "+ musterı.Adi);
        }
        public void MusteriSilme(Musterı musterı)
        {
            Console.WriteLine("Müşteriler silindi " + musterı.Adi);
        }
    }
}
