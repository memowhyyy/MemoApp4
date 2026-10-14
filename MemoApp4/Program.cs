
namespace MemoApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // sinema adini tanimla ve deger ver
            string sinemaAdi;
            sinemaAdi = "lucifer";

            // fiyat ve kisi degiskenleri
            decimal biletFiyati = 270m;
            decimal misirFiyati = 100m;
            int kisiSayisi = 7;
            int filmSuresi = 120;

            //bilete 30 tl zam yap
            decimal eskiFiyat = biletFiyati;
            biletFiyati = +30m;

            //toplamı hesapla 
            decimal toplamBilet = biletFiyati * kisiSayisi;
            decimal toplamMisir = misirFiyati * kisiSayisi;
            decimal genelToplam = toplamBilet * toplamBilet;
            decimal kisiBasi = genelToplam / kisiSayisi;

            //Film suresini saat ve dakikaya cevir
            int saat = filmSuresi / 60;
            int dakika = filmSuresi % 60;

            //bir kisi geldi diger biri gelmedi
            kisiSayisi++;
            kisiSayisi--;

            //cuzdandaki paradan knedi payini dus
            decimal cuzdan = 1000m;
            cuzdan -= kisiBasi;

            //yas ve ogrenci bilgisi
            int yas = 20;
            bool ogrenciMi = true;

            //karsılastırma mantıksal islemler
            bool resitMi = yas >= 18;
            bool paraYeterliMi = cuzdan > kisiBasi;
            bool indirimHakki = ogrenciMi || yas < 25;
            bool sonrakiFilmeGidebilirMi = resitMi && paraYeterliMi;
            bool ogrenciDegilMi = !ogrenciMi;

            //mesaj olustur
            string mesaj = "iyi seyirler";
            mesaj += " - " + sinemaAdi;
            mesaj += " - kisi sayisi: " + kisiSayisi;

            //sonucları ekrana yazdir
            Console.WriteLine("===== SINEMA HESAPLAMA =====");
            Console.WriteLine($"Sinema adi: {sinemaAdi}");
            Console.WriteLine($"eski bilet fiyati: {eskiFiyat}");
            Console.WriteLine($"yeni bilet fiyati: {biletFiyati}");
            Console.WriteLine($"misir fiyati: {misirFiyati}");
            Console.WriteLine($"kisi sayisi: {kisiSayisi}");
            Console.WriteLine($"film suresi: {saat} saat {dakika} dakika");

            Console.WriteLine("\n==== UCRETLER =====");
            Console.WriteLine($"toplam bilet: {toplamBilet}");
            Console.WriteLine($"toplam misir: {toplamMisir}");
            Console.WriteLine($"genel toplam: {genelToplam}");
            Console.WriteLine($"kisi basi: {kisiBasi} TL");

            Console.WriteLine("\n===== CUZDAN =====");
            Console.WriteLine($"kalan para: {cuzdan} TL'dir");

            Console.WriteLine("\n==== KONTROLLER =====");
            Console.WriteLine($" resit mi: {resitMi}");
            Console.WriteLine($"parasi yeterli mi: {paraYeterliMi}");
            Console.WriteLine($"indirim hakki var mi: {indirimHakki}");
            Console.WriteLine($"sonraki filme gidebilir mi: {sonrakiFilmeGidebilirMi}");
            Console.WriteLine($"ogrenci degil mi: {ogrenciDegilMi}");

            Console.WriteLine("\n" + mesaj);    







        }

        
    }
}
