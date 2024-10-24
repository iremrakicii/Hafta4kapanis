# Üretim Sistemi

Bu proje, basit bir üretim sistemi simülasyonunu gerçekleştirir. Kullanıcı, bilgisayar veya telefon üretebilir ve bu ürünlerin detaylarını görebilir. 

## Özellikler

- **Telefon Üretimi:** Samsung Note 5 bilgileri ile bir telefon üretilebilir.
- **Bilgisayar Üretimi:** Macbook Pro bilgileri ile bir bilgisayar üretilebilir.
- **Ürün Bilgileri Yazdırma:** Üretilen ürünlerin seri numarası, açıklama, işletim sistemi, üretim tarihi gibi bilgileri yazdırılır.
- **USB Giriş Sayısı Kontrolü (Bilgisayar):** Bilgisayar için USB giriş sayısı 2 veya 4 olabilir, aksi takdirde hata mesajı görüntülenir.
- **TR Lisans Kontrolü (Telefon):** Telefonlar için TR lisansı kontrol edilir, geçerli değilse varsayılan bir mesaj yazdırılır.

## Sınıf Yapısı

Proje, aşağıdaki sınıflardan oluşur:

1. **BaseMakine (Soyut Sınıf):** Tüm makineler için ortak özellikleri ve metotları içerir.
    - Özellikler: `UretimTarihi`, `SeriNumarasi`, `Name`, `Aciklama`, `IsletimSistemi`
    - Metotlar: `BilgileriYazdir()`, `UrunAdiGetir(string name)`

2. **Bilgisayar (Türetilmiş Sınıf):** Bilgisayar için spesifik özellik ve metotları içerir.
    - Ek Özellik: `UsbGirişSayisi`
    - USB giriş sayısı 2 veya 4 olabilir. Hatalı girişlerde uyarı verilir.

3. **Telefon (Türetilmiş Sınıf):** Telefon için spesifik özellik ve metotları içerir.
    - Ek Özellik: `TrLisans`
    - TR lisansı boş ise geçersiz lisans mesajı döner.

## Kullanım

1. Program çalıştırıldığında, kullanıcıya bilgisayar mı yoksa telefon mu üretmek istediği sorulur.
2. Kullanıcıdan alınan yanıt doğrultusunda, belirli ürün bilgileri ekrana yazdırılır.
3. Ürün üretildikten sonra kullanıcıya başka bir ürün üretmek isteyip istemediği sorulur. 
    - **Evet** derse süreç tekrar başlar.
    - **Hayır** derse program sonlanır.

## Kod Çalıştırma

Bu projeyi çalıştırmak için bir C# geliştirme ortamına ihtiyacınız var (örneğin: Visual Studio veya .NET SDK).

1. Kodunuzu derleyin ve çalıştırın.
2. Konsol ekranında seçim yapın:
   - Telefon üretmek için `1`
   - Bilgisayar üretmek için `2`
3. Ürünün detayları görüntülendikten sonra, başka bir ürün üretip üretmek istemediğiniz sorulacaktır. Yanıtınızı vererek devam edin.

## Hata Durumları

- USB giriş sayısı hatalı girildiğinde, `UsbGirişSayisi` özelliği `-1` olarak atanır ve hata mesajı verilir.
- TR lisansı boş bırakıldığında, "Geçersiz Lisans" mesajı görüntülenir.

## Kullanılan Araç ve Teknolojiler
Programlama Dili: C# IDE: Visual Studio

