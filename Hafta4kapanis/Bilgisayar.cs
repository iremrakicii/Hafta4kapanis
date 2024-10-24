namespace Hafta4kapanis
{
    public class Bilgisayar : BaseMakine
    {
        private int usbGirişSayisi;
        private DateTime uretimTarihi;
        public int UsbGirişSayisi
        {
            get
            {
                return usbGirişSayisi;
            }
            set
            {
                if (usbGirişSayisi == 2 || usbGirişSayisi == 4)
                {
                    usbGirişSayisi = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız.Usb giriş sayı 2 ya da 4 olmalıdır. ");
                    usbGirişSayisi = -1;
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
            Console.WriteLine($"Bilgisayarınızın adı: ------> {Name}");
        }

        public override void BilgileriYazdir()
        {
            Console.WriteLine($"Ürünün seri numarası:{SeriNumarasi}");
            Console.WriteLine($"Ürünün açıklaması: {Aciklama}");
            Console.WriteLine($"Ürünün işletim sistemi: {IsletimSistemi}");
            Console.WriteLine($"Ürünün üretim tarihi: {UretimTarihi}");
            Console.WriteLine($"Ürünün USB giriş sayısı: {UsbGirişSayisi}");
        }

    }
}
