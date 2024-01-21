using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UcusRezervasyon_Final
{
    
    internal class Program

    {

        static string ConvertToCsv(Rezervasyon rezervasyon)
        {
           
            List<string> fields = new List<string>
            {
                rezervasyon.UcusBilgisi.Lokasyon.Havalimani,
                rezervasyon.UcusBilgisi.Lokasyon.Sehir,
                rezervasyon.UcusBilgisi.UcakBilgisi.Model,
                rezervasyon.UcusBilgisi.Tarih.ToString(),
                rezervasyon.Ad,
                rezervasyon.Soyad,
                rezervasyon.Yas.ToString()
              
            };

            string csvLine = string.Join(",", fields);
            return csvLine;
        }
        static void Main(string[] args)
        {
            Ucak ucak1 = new Ucak { Id = 1, Model = "Boeing 747", Marka = "Boeing", SeriNo = "12345", Kapasite = 300 };
            Lokasyon lokasyon1 = new Lokasyon { Id = 1, Sehir = "İstanbul", Ulke= "Türkiye", Havalimani = "Atatürk"};
            Ucus ucus1 = new Ucus { Id = 1, Lokasyon = lokasyon1,Tarih = DateTime.Now, UcakBilgisi = ucak1 };
            Rezervasyon rezervasyon1 = new Rezervasyon { Id = 1, UcusBilgisi = ucus1, Ad = "Ahmet", Soyad = "Yılmaz", Yas = 25 };
            
            
            int otoid = 40;
            string otoliman = "Sabiha Gökçen";
            string sehir;
            string ulke;
            string havalimani;

            
            
                Console.WriteLine("********** Uçuş Rezervasyon Uygulaması **********");

                        //Yolcu Kişisel Bilgileri
                        Console.WriteLine("Yolcu Adı: ");
                        string ad = Console.ReadLine();
                        Console.WriteLine("Yolcu Soyadı: ");
                        string soyad = Console.ReadLine();
                        Console.WriteLine("Yolcunun Yaşı: ");
                        int yas = Convert.ToInt32(Console.ReadLine());
                        //devam etmeli


                        // Yolculuk Bilgileri
                        Console.WriteLine("Gitmek İstenilen Şehir: ");
                        sehir = Console.ReadLine();
                        Console.WriteLine("Gitmek İstenilen Ülke");
                        ulke = Console.ReadLine();
                        Console.WriteLine("Kalkış Yapılacak Havalimanı: ");
                        havalimani = Console.ReadLine();


                Lokasyon lokasyon2 = new Lokasyon { Id = 2, Sehir = sehir, Ulke = ulke, Havalimani = otoliman };
                Ucus ucus2 = new Ucus { Id = 2, Lokasyon = lokasyon2, Tarih = DateTime.Now, UcakBilgisi = ucak1 };
                Rezervasyon rezervasyon2 = new Rezervasyon { Id = 2, UcusBilgisi = ucus2, Ad = ad, Soyad = soyad, Yas = yas };
                rezervasyon2.RezervasyonYap();

                string csvRezervasyon = ConvertToCsv(rezervasyon2);
                Console.WriteLine("Rezervasyon CSV Formatı:\n" + csvRezervasyon);

                Console.ReadKey();













        }
    }
}
