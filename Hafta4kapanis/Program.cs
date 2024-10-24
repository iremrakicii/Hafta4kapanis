using Hafta4kapanis;

class Program
{
    static void Main()
    {
    baslangic:
        Console.WriteLine("Merhabalar, Hoşgeldiniz!");
        Console.WriteLine("Telefon üretmek için 1 butonuna, Bilgisayar üretmek için 2 butonuna basınınız. ");
        int cevap = Convert.ToInt32(Console.ReadLine());
        Telefon telefon1 = new Telefon();
        Bilgisayar bilgisayar1 = new Bilgisayar();


        if (cevap == 1)
        {
            telefon1.UrunAdiGetir("Samsung Note 5");
            telefon1.Aciklama = "Samsung Galaxy Note 5, Samsung'un 2015 yılında piyasaya sürdüğü üst düzey bir akıllı telefondur. Note serisinin önceki modelleri gibi, büyük ekranı ve kalem desteği (S Pen) ile dikkat çeker. ";
            telefon1.IsletimSistemi = "Android";
            telefon1.SeriNumarasi = "M323321";
            telefon1.UretimTarihi = DateTime.Now;
            telefon1.TrLisans = "";
            telefon1.BilgileriYazdir();

        }
        else
        {
            bilgisayar1.UrunAdiGetir("Macbook Pro");
            bilgisayar1.Aciklama = "MacBook Pro Apple tarafından üretilen ve özellikle profesyoneller için tasarlanan bir dizüstü bilgisayardır. Genel olarak üstün performansı, kaliteli ekranları ve dayanıklı yapısıyla bilinir.  ";
            bilgisayar1.IsletimSistemi = "Apple Inc";
            bilgisayar1.SeriNumarasi = "M5435367";
            bilgisayar1.UretimTarihi = DateTime.Now;
            bilgisayar1.UsbGirişSayisi = -5;
            bilgisayar1.BilgileriYazdir();

        }

    baslangic2:
        Console.WriteLine("Ürününüz başarılı bir şekilde üretildi! Başka bir ürün oluşturmak ister misiniz? evet/hayır");
        string cevap2 = Console.ReadLine();

        if (cevap2.ToLower() == "evet")
        {
            goto baslangic;
        }
        else if (cevap2.ToLower() == "hayır")
        {
            Console.WriteLine("Teşekkür eder, iyi günler dileriz!");

        }
        else
        {
            Console.WriteLine("Geçersiz cevap. Lütfen 'evet' ya da 'hayır' yazın.");
            goto baslangic2;
        }


    }
}
