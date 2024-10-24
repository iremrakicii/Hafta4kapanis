namespace Hafta4kapanis
{
    public abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; set; }

        public string SeriNumarasi { get; set; }

        public string Name { get; set; }

        public string Aciklama { get; set; }

        public string IsletimSistemi { get; set; }

        public abstract void BilgileriYazdir();

        public abstract void UrunAdiGetir(string name);
    }

}
