namespace Hafta4kapanis
{
    public class Telefon : BaseMakine
    {
        private string _trLisans;
        private DateTime uretimTarihi;

        public string TrLisans
        {
            get
            {
                return _trLisans;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _trLisans = value;
                }
                else
                {

                    _trLisans = "Geçersiz Lisans";

                }
            }

        }

        public DateTime UretimTarihi
        {
            get
            {
                return DateTime.Now;
            }
            set
            {
                uretimTarihi = value;
            }
        }
        public override void UrunAdiGetir(string Name)
        {
            Console.WriteLine($"Telefonunuzun adı: ------> {Name}");
        }

        public override void BilgileriYazdir()
        {
            Console.WriteLine($"Ürünün seri numarası:{SeriNumarasi}");
            Console.WriteLine($"Ürünün açıklaması: {Aciklama}");
            Console.WriteLine($"Ürünün işletim sistemi: {IsletimSistemi}");
            Console.WriteLine($"Ürünün üretim tarihi: {UretimTarihi}");
            Console.WriteLine($"Ürünün TR lisansı: {TrLisans}");
        }


    }
}
